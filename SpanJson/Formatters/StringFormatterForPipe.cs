using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpanJson.Formatters
{
    public sealed class StringFormatterForPipe<TResolver> : BaseFormatter where TResolver : IJsonFormatterResolver<byte, TResolver>, new()
    {
        public async ValueTask SerializeAsync(string input, Pipe pipe, CancellationToken cancellationToken = default)
        {
            while (true)
            {
                try
                {
                    var memory = pipe.Writer.GetMemory();
                    var state = WriteString(memory.Span, input, out var bytesWritten);
                    if (state == WriterState.NeedBiggerBuffer)
                    {
                        //TODO later
                    }
                    pipe.Writer.Advance(bytesWritten);

                    if (state == WriterState.Finished)
                    {
                        pipe.Writer.Complete();
                        break;
                    }
                }
                finally
                {
                    await pipe.Writer.FlushAsync(cancellationToken).ConfigureAwait(false); ;
                }
            }
        }

        private static WriterState WriteString(Span<byte> buffer, ReadOnlySpan<char> input, out int bytesWritten)
        {
            if (buffer.Length < input.Length + 2)
            {
                bytesWritten = default;
                return WriterState.NeedBiggerBuffer;
            }

            var pos = 0;
            buffer[pos++] = (byte) JsonConstant.DoubleQuote;
            for (int i = 0; i < input.Length; i++)
            {
                buffer[pos++] = (byte) input[i];
            }

            buffer[pos++] = (byte) JsonConstant.DoubleQuote;
            bytesWritten = pos;
            return WriterState.Finished;
        }

        public async ValueTask<string> DeserializeAsync(Pipe pipe, CancellationToken cancellationToken = default)
        {
            string result = null;
            while (true)
            {
                var readResult = await pipe.Reader.ReadAsync(cancellationToken).ConfigureAwait(false);
                try
                {
                    if (readResult.IsCompleted && readResult.Buffer.IsEmpty)
                    {                     
                        break;
                    }

                    if (TryFindEndOfUtf8String(readResult.Buffer, out var slice, out var cursor))
                    {
                        result = EncodeUtf8(slice);
                    }
                }
                finally
                {
                    pipe.Reader.AdvanceTo(readResult.Buffer.End);
                }
            }

            return result;
        }

        private string EncodeUtf8(in ReadOnlySequence<byte> sequence)
        {
            var length = (int) sequence.Length;
            var result = new string('\0', length);
            ref var c = ref MemoryMarshal.GetReference(result.AsSpan());
            var counter = 0;
            foreach (var memory in sequence)
            {
                var currentSpan = memory.Span;
                for (int i = 0; i < currentSpan.Length; i++)
                {
                    Unsafe.Add(ref c, counter++) = (char) currentSpan[i];
                }
            }

            return result;
        }

        private bool TryFindEndOfUtf8String(ReadOnlySequence<byte> sequence, out ReadOnlySequence<byte> slice, out SequencePosition cursor)
        {
            var seek = 0;
            var start = sequence.Start;
            if (!sequence.TryGet(ref start, out var firstMemory, false) || sequence.IsEmpty || firstMemory.Span[0] != JsonConstant.DoubleQuote)
            {
                throw new InvalidDataException();
            }

            sequence = sequence.Slice(1);

            foreach (var memory in sequence)
            {
                var currentSpan = memory.Span;
                for (int i = 0; i < currentSpan.Length; i++)
                {
                    if (currentSpan[i] == JsonConstant.DoubleQuote)
                    {
                        cursor = sequence.GetPosition(seek);
                        slice = sequence.Slice(sequence.Start, cursor);
                        return true;
                    }

                    seek++;
                }
            }

            slice = default;
            cursor = default;
            return false;
        }

        internal enum WriterState : byte
        {
            NeedBiggerBuffer = 1,
            Finished = 2
        }
    }
}
