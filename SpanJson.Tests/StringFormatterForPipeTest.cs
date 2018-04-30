using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Text;
using System.Threading.Tasks;
using SpanJson.Formatters;
using SpanJson.Resolvers;
using Xunit;

namespace SpanJson.Tests
{
    public class StringFormatterForPipeTest
    {
        [Fact]
        public async Task Serialize()
        {
            var pipe = new Pipe();
            var sf = new StringFormatterForPipe<ExcludeNullsOriginalCaseResolver<byte>>();
            var input = "Hello World";
            await sf.SerializeAsync(input, pipe).ConfigureAwait(false);
            var deserialized = await sf.DeserializeAsync(pipe).ConfigureAwait(false);
            Assert.Equal(input, deserialized);
        }
    }
}
