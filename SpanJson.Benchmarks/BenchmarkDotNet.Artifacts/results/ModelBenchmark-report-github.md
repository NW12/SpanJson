``` ini

BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.309)
Intel Core i7-4790K CPU 4.00GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3906246 Hz, Resolution=256.0003 ns, Timer=TSC
.NET Core SDK=2.1.300-preview1-008174
  [Host]     : .NET Core 2.1.0-preview3-26329-05 (CoreCLR 4.6.26329.01, CoreFX 4.6.26329.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0-preview3-26329-05 (CoreCLR 4.6.26329.01, CoreFX 4.6.26329.01), 64bit RyuJIT


```
|                                                 Method |        Mean |       Error |      StdDev |      Median |  Gen 0 | Allocated |
|------------------------------------------------------- |------------:|------------:|------------:|------------:|-------:|----------:|
|       SerializeReputationHistoryWithUtf8JsonSerializer |    736.5 ns |   1.5380 ns |   1.2843 ns |    736.7 ns | 0.0448 |     192 B |
|                SerializeRevisionWithUtf8JsonSerializer |  1,885.6 ns |  17.0158 ns |  15.0841 ns |  1,883.8 ns | 0.1526 |     648 B |
|           SerializeSearchExcerptWithUtf8JsonSerializer |  4,046.9 ns |   7.1850 ns |   6.3693 ns |  4,046.0 ns | 0.2441 |    1040 B |
|             SerializeShallowUserWithUtf8JsonSerializer |    608.5 ns |   0.3129 ns |   0.2927 ns |    608.4 ns | 0.0620 |     264 B |
|           SerializeSuggestedEditWithUtf8JsonSerializer |  2,357.9 ns |   7.8356 ns |   7.3294 ns |  2,361.0 ns | 0.1373 |     592 B |
|                     SerializeTagWithUtf8JsonSerializer |    812.1 ns |   0.2418 ns |   0.2143 ns |    812.0 ns | 0.0544 |     232 B |
|                SerializeTagScoreWithUtf8JsonSerializer |    760.7 ns |   0.3658 ns |   0.3243 ns |    760.6 ns | 0.0734 |     312 B |
|              SerializeTagSynonymWithUtf8JsonSerializer |  1,069.1 ns |   2.1328 ns |   1.7809 ns |  1,068.2 ns | 0.0477 |     208 B |
|                 SerializeTagWikiWithUtf8JsonSerializer |  2,250.1 ns |  12.8771 ns |  12.0452 ns |  2,252.6 ns | 0.1717 |     736 B |
|                  SerializeTopTagWithUtf8JsonSerializer |    369.0 ns |   0.0929 ns |   0.0824 ns |    369.0 ns | 0.0415 |     176 B |
|                    SerializeUserWithUtf8JsonSerializer |  3,249.2 ns |  34.0822 ns |  30.2130 ns |  3,231.8 ns | 0.2174 |     928 B |
|            SerializeUserTimelineWithUtf8JsonSerializer |  1,025.0 ns |   3.6522 ns |   3.0497 ns |  1,025.2 ns | 0.0706 |     304 B |
|         SerializeWritePermissionWithUtf8JsonSerializer |    353.2 ns |   0.0362 ns |   0.0339 ns |    353.2 ns | 0.0472 |     200 B |
|     SerializeMobileBannerAdImageWithUtf8JsonSerializer |    207.8 ns |   2.9172 ns |   2.4360 ns |    206.7 ns | 0.0207 |      88 B |
|                    SerializeSiteWithUtf8JsonSerializer |  2,394.0 ns |   5.7255 ns |   5.3556 ns |  2,394.7 ns | 0.1717 |     736 B |
|             SerializeRelatedSiteWithUtf8JsonSerializer |    217.0 ns |   0.4943 ns |   0.4382 ns |    216.8 ns | 0.0284 |     120 B |
|           SerializeClosedDetailsWithUtf8JsonSerializer |  1,030.8 ns |   1.3706 ns |   1.0701 ns |  1,030.6 ns | 0.1106 |     472 B |
|                  SerializeNoticeWithUtf8JsonSerializer |    587.9 ns |   0.0978 ns |   0.0764 ns |    587.9 ns | 0.0296 |     128 B |
|           SerializeMigrationInfoWithUtf8JsonSerializer |  2,986.5 ns |   6.8262 ns |   6.0512 ns |  2,987.3 ns | 0.1945 |     824 B |
|              SerializeBadgeCountWithUtf8JsonSerializer |    224.3 ns |   2.0338 ns |   1.8029 ns |    223.6 ns | 0.0207 |      88 B |
|                 SerializeStylingWithUtf8JsonSerializer |    165.9 ns |   0.0552 ns |   0.0517 ns |    165.9 ns | 0.0284 |     120 B |
|        SerializeOriginalQuestionWithUtf8JsonSerializer |    273.3 ns |   0.5700 ns |   0.4760 ns |    273.2 ns | 0.0300 |     128 B |
|  SerializeMobileAssociationBonusWithSpanJsonSerializer |    420.5 ns |   0.2954 ns |   0.2619 ns |    420.5 ns | 0.0491 |     208 B |
|      SerializeMobileCareersJobAdWithSpanJsonSerializer |    578.6 ns |   0.1537 ns |   0.1283 ns |    578.6 ns | 0.0830 |     352 B |
|          SerializeMobileBannerAdWithSpanJsonSerializer |    681.8 ns |   0.2731 ns |   0.2555 ns |    681.8 ns | 0.0772 |     328 B |
|      SerializeMobileUpdateNoticeWithSpanJsonSerializer |    272.6 ns |   2.1742 ns |   1.9274 ns |    273.5 ns | 0.0453 |     192 B |
|              SerializeFlagOptionWithSpanJsonSerializer |    990.9 ns |  11.1046 ns |  10.3873 ns |    984.9 ns | 0.1945 |     824 B |
|               SerializeInboxItemWithSpanJsonSerializer |  2,880.8 ns |   1.0307 ns |   0.9641 ns |  2,880.5 ns | 0.4539 |    1920 B |
|                    SerializeInfoWithSpanJsonSerializer |  3,285.3 ns |   3.7538 ns |   3.3276 ns |  3,285.3 ns | 0.5226 |    2208 B |
|             SerializeNetworkUserWithSpanJsonSerializer |  1,551.4 ns |  17.7405 ns |  16.5945 ns |  1,539.1 ns | 0.1831 |     776 B |
|            SerializeNotificationWithSpanJsonSerializer |  2,677.3 ns |   1.0106 ns |   0.8959 ns |  2,677.4 ns | 0.4196 |    1768 B |
|                    SerializePostWithSpanJsonSerializer |  5,120.7 ns |   3.5156 ns |   3.2885 ns |  5,121.4 ns | 0.8011 |    3392 B |
|               SerializePrivilegeWithSpanJsonSerializer |    315.0 ns |   0.4809 ns |   0.4499 ns |    314.6 ns | 0.0453 |     192 B |
|                SerializeQuestionWithSpanJsonSerializer | 19,169.9 ns |  11.7432 ns |  10.4100 ns | 19,169.3 ns | 2.9907 |   12664 B |
|        SerializeQuestionTimelineWithSpanJsonSerializer |  2,294.7 ns |   1.2934 ns |   1.2099 ns |  2,294.1 ns | 0.3510 |    1488 B |
|              SerializeReputationWithSpanJsonSerializer |    871.8 ns |   0.1676 ns |   0.1400 ns |    871.7 ns | 0.1040 |     440 B |
|       SerializeReputationHistoryWithSpanJsonSerializer |    736.8 ns |   6.5094 ns |   6.0889 ns |    731.9 ns | 0.0906 |     384 B |
|                SerializeRevisionWithSpanJsonSerializer |  1,794.2 ns |   0.2967 ns |   0.2478 ns |  1,794.2 ns | 0.3014 |    1272 B |
|           SerializeSearchExcerptWithSpanJsonSerializer |  3,510.9 ns |   7.2968 ns |   6.4684 ns |  3,509.4 ns | 0.4845 |    2048 B |
|             SerializeShallowUserWithSpanJsonSerializer |    802.6 ns |   1.3470 ns |   1.1248 ns |    802.5 ns | 0.1192 |     504 B |
|           SerializeSuggestedEditWithSpanJsonSerializer |  2,173.5 ns |   4.8785 ns |   4.5633 ns |  2,173.2 ns | 0.2747 |    1168 B |
|                     SerializeTagWithSpanJsonSerializer |    860.2 ns |  12.4382 ns |  11.6347 ns |    855.6 ns | 0.1040 |     440 B |
|                SerializeTagScoreWithSpanJsonSerializer |  1,054.9 ns |   3.0027 ns |   2.8087 ns |  1,054.2 ns | 0.1431 |     608 B |
|              SerializeTagSynonymWithSpanJsonSerializer |    971.7 ns |   0.3252 ns |   0.2883 ns |    971.8 ns | 0.0896 |     384 B |
|                 SerializeTagWikiWithSpanJsonSerializer |  2,257.2 ns |   0.8121 ns |   0.7596 ns |  2,257.2 ns | 0.3395 |    1432 B |
|                  SerializeTopTagWithSpanJsonSerializer |    526.4 ns |   0.1914 ns |   0.1494 ns |    526.4 ns | 0.0772 |     328 B |
|                    SerializeUserWithSpanJsonSerializer |  2,958.2 ns |   5.4776 ns |   5.1238 ns |  2,959.6 ns | 0.4387 |    1848 B |
|            SerializeUserTimelineWithSpanJsonSerializer |  1,059.1 ns |   7.9767 ns |   7.4614 ns |  1,057.6 ns | 0.1354 |     576 B |
|         SerializeWritePermissionWithSpanJsonSerializer |    508.7 ns |   0.0545 ns |   0.0483 ns |    508.7 ns | 0.0868 |     368 B |
|     SerializeMobileBannerAdImageWithSpanJsonSerializer |    337.5 ns |   2.5801 ns |   2.4134 ns |    335.8 ns | 0.0358 |     152 B |
|                    SerializeSiteWithSpanJsonSerializer |  1,963.3 ns |   1.3864 ns |   1.2290 ns |  1,962.8 ns | 0.3395 |    1440 B |
|             SerializeRelatedSiteWithSpanJsonSerializer |    317.5 ns |   0.0247 ns |   0.0206 ns |    317.5 ns | 0.0491 |     208 B |
|           SerializeClosedDetailsWithSpanJsonSerializer |  1,259.4 ns |   0.7565 ns |   0.7076 ns |  1,259.4 ns | 0.2174 |     920 B |
|                  SerializeNoticeWithSpanJsonSerializer |    570.7 ns |   0.0890 ns |   0.0743 ns |    570.7 ns | 0.0525 |     224 B |
|           SerializeMigrationInfoWithSpanJsonSerializer |  2,542.5 ns |   1.3288 ns |   1.2429 ns |  2,542.2 ns | 0.3815 |    1616 B |
|              SerializeBadgeCountWithSpanJsonSerializer |    362.6 ns |   0.1073 ns |   0.0951 ns |    362.5 ns | 0.0319 |     136 B |
|                 SerializeStylingWithSpanJsonSerializer |    284.5 ns |   3.8877 ns |   3.4464 ns |    282.6 ns | 0.0510 |     216 B |
|        SerializeOriginalQuestionWithSpanJsonSerializer |    397.2 ns |   0.2805 ns |   0.2624 ns |    397.0 ns | 0.0548 |     232 B |
|             SerializeAccessTokenWithUtf8JsonSerializer |    680.9 ns |   0.2925 ns |   0.2736 ns |    681.0 ns | 0.0353 |     152 B |
|            SerializeAccountMergeWithUtf8JsonSerializer |    603.9 ns |   5.0526 ns |   4.4790 ns |    600.9 ns | 0.0296 |     128 B |
|                  SerializeAnswerWithUtf8JsonSerializer |  6,336.0 ns |   7.0440 ns |   6.5890 ns |  6,335.8 ns | 0.4501 |    1904 B |
|                   SerializeBadgeWithUtf8JsonSerializer |  1,008.5 ns |   1.5005 ns |   1.2530 ns |  1,008.3 ns | 0.0973 |     416 B |
|                 SerializeCommentWithUtf8JsonSerializer |  2,107.0 ns |   3.0033 ns |   2.5079 ns |  2,106.7 ns | 0.1793 |     760 B |
|                   SerializeErrorWithUtf8JsonSerializer |    189.3 ns |   0.0535 ns |   0.0500 ns |    189.3 ns | 0.0226 |      96 B |
|                   SerializeEventWithUtf8JsonSerializer |    708.8 ns |   0.3536 ns |   0.3134 ns |    708.7 ns | 0.0391 |     168 B |
|              SerializeMobileFeedWithUtf8JsonSerializer |  7,249.5 ns |  10.7359 ns |  10.0424 ns |  7,248.8 ns | 0.7553 |    3184 B |
|          SerializeMobileQuestionWithUtf8JsonSerializer |    665.8 ns |   0.1790 ns |   0.1587 ns |    665.7 ns | 0.0753 |     320 B |
|         SerializeMobileRepChangeWithUtf8JsonSerializer |    351.0 ns |   0.0692 ns |   0.0578 ns |    351.0 ns | 0.0377 |     160 B |
|         SerializeMobileInboxItemWithUtf8JsonSerializer |    621.5 ns |   0.1895 ns |   0.1773 ns |    621.5 ns | 0.0677 |     288 B |
|        SerializeMobileBadgeAwardWithUtf8JsonSerializer |    587.6 ns |   0.1730 ns |   0.1351 ns |    587.6 ns | 0.0601 |     256 B |
|         SerializeMobilePrivilegeWithUtf8JsonSerializer |    452.2 ns |   0.2173 ns |   0.2033 ns |    452.1 ns | 0.0606 |     256 B |
| SerializeMobileCommunityBulletinWithUtf8JsonSerializer |    805.8 ns |   0.4417 ns |   0.3689 ns |    805.7 ns | 0.0887 |     376 B |
|  SerializeMobileAssociationBonusWithUtf8JsonSerializer |    296.2 ns |   5.9825 ns |   9.9954 ns |    292.4 ns | 0.0281 |     120 B |
|      SerializeMobileCareersJobAdWithUtf8JsonSerializer |    391.8 ns |   0.1664 ns |   0.1475 ns |    391.7 ns | 0.0453 |     192 B |
|          SerializeMobileBannerAdWithUtf8JsonSerializer |    421.8 ns |   3.4494 ns |   3.0578 ns |    420.0 ns | 0.0415 |     176 B |
|      SerializeMobileUpdateNoticeWithUtf8JsonSerializer |    158.5 ns |   0.0423 ns |   0.0396 ns |    158.5 ns | 0.0265 |     112 B |
|              SerializeFlagOptionWithUtf8JsonSerializer |    772.6 ns |   0.1341 ns |   0.1254 ns |    772.6 ns | 0.1001 |     424 B |
|               SerializeInboxItemWithUtf8JsonSerializer |  3,313.5 ns |  28.3293 ns |  26.4992 ns |  3,297.4 ns | 0.2289 |     976 B |
|                    SerializeInfoWithUtf8JsonSerializer |  3,703.2 ns |   6.7002 ns |   6.2673 ns |  3,700.6 ns | 0.3319 |    1408 B |
|             SerializeNetworkUserWithUtf8JsonSerializer |  1,542.9 ns |   1.5641 ns |   1.3061 ns |  1,542.8 ns | 0.0935 |     400 B |
|            SerializeNotificationWithUtf8JsonSerializer |  3,108.8 ns |  16.0994 ns |  15.0594 ns |  3,115.0 ns | 0.2098 |     888 B |
|                    SerializePostWithUtf8JsonSerializer |  5,289.2 ns |   4.7300 ns |   4.1931 ns |  5,290.1 ns | 0.4044 |    1712 B |
|               SerializePrivilegeWithUtf8JsonSerializer |    184.9 ns |   0.1454 ns |   0.1360 ns |    184.9 ns | 0.0246 |     104 B |
|                SerializeQuestionWithUtf8JsonSerializer | 22,770.5 ns | 113.2629 ns | 100.4046 ns | 22,741.6 ns | 1.4954 |    6360 B |
|        SerializeQuestionTimelineWithUtf8JsonSerializer |  2,125.3 ns |  13.0552 ns |  12.2119 ns |  2,129.2 ns | 0.1793 |     768 B |
|              SerializeReputationWithUtf8JsonSerializer |    899.0 ns |   5.7277 ns |   5.3577 ns |    896.6 ns | 0.0525 |     224 B |
|                  SerializeAccessTokenWithJilSerializer |    700.5 ns |   4.9950 ns |   4.6724 ns |    697.8 ns | 0.2146 |     904 B |
|                 SerializeAccountMergeWithJilSerializer |    578.8 ns |   0.1229 ns |   0.1149 ns |    578.8 ns | 0.2050 |     864 B |
|                       SerializeAnswerWithJilSerializer |  5,546.2 ns |  12.4867 ns |  11.6801 ns |  5,548.6 ns | 2.1057 |    8856 B |
|                        SerializeBadgeWithJilSerializer |    960.6 ns |   0.4400 ns |   0.3435 ns |    960.5 ns | 0.5627 |    2368 B |
|                      SerializeCommentWithJilSerializer |  1,889.1 ns |   2.0659 ns |   1.8313 ns |  1,888.2 ns | 1.0281 |    4320 B |
|                        SerializeErrorWithJilSerializer |    326.4 ns |   0.0767 ns |   0.0718 ns |    326.4 ns | 0.1922 |     808 B |
|                        SerializeEventWithJilSerializer |    725.7 ns |   7.5360 ns |   7.0492 ns |    720.3 ns | 0.2985 |    1256 B |
|                   SerializeMobileFeedWithJilSerializer |  7,478.0 ns |  13.0595 ns |  12.2159 ns |  7,474.8 ns | 3.7537 |   15792 B |
|               SerializeMobileQuestionWithJilSerializer |    756.1 ns |   0.0933 ns |   0.0873 ns |    756.1 ns | 0.5159 |    2168 B |
|              SerializeMobileRepChangeWithJilSerializer |    504.0 ns |   2.8997 ns |   2.4214 ns |    503.1 ns | 0.3004 |    1264 B |
|              SerializeMobileInboxItemWithJilSerializer |    783.7 ns |   0.1875 ns |   0.1663 ns |    783.7 ns | 0.4988 |    2096 B |
|             SerializeMobileBadgeAwardWithJilSerializer |    613.6 ns |   0.0745 ns |   0.0660 ns |    613.6 ns | 0.3443 |    1448 B |
|              SerializeMobilePrivilegeWithJilSerializer |    612.4 ns |   0.1045 ns |   0.0927 ns |    612.4 ns | 0.3481 |    1464 B |
|      SerializeMobileCommunityBulletinWithJilSerializer |    890.9 ns |   0.1535 ns |   0.1361 ns |    890.9 ns | 0.5407 |    2272 B |
|       SerializeMobileAssociationBonusWithJilSerializer |    352.7 ns |   0.0501 ns |   0.0418 ns |    352.7 ns | 0.2036 |     856 B |
|           SerializeMobileCareersJobAdWithJilSerializer |    571.7 ns |   0.1098 ns |   0.0973 ns |    571.7 ns | 0.3138 |    1320 B |
|               SerializeMobileBannerAdWithJilSerializer |    534.8 ns |   0.1481 ns |   0.1313 ns |    534.8 ns | 0.3080 |    1296 B |
|           SerializeMobileUpdateNoticeWithJilSerializer |    310.2 ns |   0.0528 ns |   0.0468 ns |    310.2 ns | 0.1750 |     736 B |
|                   SerializeFlagOptionWithJilSerializer |    855.0 ns |   1.7105 ns |   1.4283 ns |    854.8 ns | 0.5884 |    2472 B |
|                    SerializeInboxItemWithJilSerializer |  3,409.4 ns |   3.6717 ns |   2.8667 ns |  3,410.7 ns | 1.0681 |    4496 B |
|                         SerializeInfoWithJilSerializer |  3,545.3 ns |   5.2815 ns |   4.9403 ns |  3,546.5 ns | 1.6937 |    7112 B |
|                  SerializeNetworkUserWithJilSerializer |  1,324.2 ns |   0.2097 ns |   0.1962 ns |  1,324.1 ns | 0.5474 |    2304 B |
|                 SerializeNotificationWithJilSerializer |  3,154.9 ns |   6.7556 ns |   5.9887 ns |  3,156.2 ns | 1.0338 |    4344 B |
|                         SerializePostWithJilSerializer |  4,606.1 ns |   3.6798 ns |   3.4421 ns |  4,605.7 ns | 2.0218 |    8488 B |
|                    SerializePrivilegeWithJilSerializer |    353.2 ns |   0.0719 ns |   0.0600 ns |    353.2 ns | 0.1979 |     832 B |
|                     SerializeQuestionWithJilSerializer | 19,472.2 ns | 228.9582 ns | 214.1676 ns | 19,502.7 ns | 7.3242 |   30800 B |
|             SerializeQuestionTimelineWithJilSerializer |  1,776.1 ns |   0.6730 ns |   0.5966 ns |  1,776.1 ns | 1.0319 |    4336 B |
|                   SerializeReputationWithJilSerializer |    799.6 ns |   0.3372 ns |   0.2816 ns |    799.5 ns | 0.3309 |    1392 B |
|            SerializeReputationHistoryWithJilSerializer |    652.4 ns |   7.7573 ns |   7.2562 ns |    648.3 ns | 0.3157 |    1328 B |
|                     SerializeRevisionWithJilSerializer |  1,784.2 ns |   1.7075 ns |   1.5972 ns |  1,784.3 ns | 0.9308 |    3912 B |
|                SerializeSearchExcerptWithJilSerializer |  3,382.6 ns |   7.7164 ns |   7.2180 ns |  3,379.8 ns | 1.1444 |    4808 B |
|                  SerializeShallowUserWithJilSerializer |    668.2 ns |   0.1525 ns |   0.1191 ns |    668.2 ns | 0.3519 |    1480 B |
|                SerializeSuggestedEditWithJilSerializer |  2,123.1 ns |   2.9082 ns |   2.7203 ns |  2,121.8 ns | 0.8965 |    3776 B |
|                          SerializeTagWithJilSerializer |    816.3 ns |   0.0761 ns |   0.0711 ns |    816.3 ns | 0.3309 |    1392 B |
|                     SerializeTagScoreWithJilSerializer |    747.9 ns |  12.9007 ns |  12.0673 ns |    738.0 ns | 0.5159 |    2168 B |
|                   SerializeTagSynonymWithJilSerializer |  1,031.3 ns |   0.1031 ns |   0.0914 ns |  1,031.3 ns | 0.3147 |    1328 B |
|                      SerializeTagWikiWithJilSerializer |  2,100.6 ns |   1.3151 ns |   1.2302 ns |  2,100.5 ns | 1.0147 |    4264 B |
|                       SerializeTopTagWithJilSerializer |    417.7 ns |   0.1242 ns |   0.1101 ns |    417.7 ns | 0.3085 |    1296 B |
|                         SerializeUserWithJilSerializer |  2,718.8 ns |   6.3289 ns |   5.9201 ns |  2,716.4 ns | 1.0490 |    4416 B |
|                 SerializeUserTimelineWithJilSerializer |    964.8 ns |   1.3640 ns |   1.2759 ns |    964.6 ns | 0.5016 |    2112 B |
|              SerializeWritePermissionWithJilSerializer |    419.4 ns |   0.0986 ns |   0.0874 ns |    419.4 ns | 0.3181 |    1336 B |
|          SerializeMobileBannerAdImageWithJilSerializer |    269.3 ns |   5.1461 ns |   4.8137 ns |    266.1 ns | 0.1407 |     592 B |
|                         SerializeSiteWithJilSerializer |  2,629.0 ns |   1.1745 ns |   1.0412 ns |  2,629.0 ns | 0.9651 |    4056 B |
|                  SerializeRelatedSiteWithJilSerializer |    384.1 ns |   0.0921 ns |   0.0816 ns |    384.1 ns | 0.2017 |     848 B |
|                SerializeClosedDetailsWithJilSerializer |  1,095.5 ns |  13.6835 ns |  12.7995 ns |  1,086.0 ns | 0.5856 |    2464 B |
|                       SerializeNoticeWithJilSerializer |    608.5 ns |   0.0912 ns |   0.0853 ns |    608.5 ns | 0.2012 |     848 B |
|                SerializeMigrationInfoWithJilSerializer |  3,027.5 ns |   4.7252 ns |   4.4200 ns |  3,029.3 ns | 0.9995 |    4208 B |
|                   SerializeBadgeCountWithJilSerializer |    221.1 ns |   2.3319 ns |   2.1812 ns |    219.9 ns | 0.1392 |     584 B |
|                      SerializeStylingWithJilSerializer |    359.1 ns |   0.0407 ns |   0.0339 ns |    359.1 ns | 0.1807 |     760 B |
|             SerializeOriginalQuestionWithJilSerializer |    327.1 ns |   0.0575 ns |   0.0509 ns |    327.1 ns | 0.2074 |     872 B |
|             SerializeAccessTokenWithSpanJsonSerializer |    607.0 ns |   0.0399 ns |   0.0333 ns |    606.9 ns | 0.0658 |     280 B |
|            SerializeAccountMergeWithSpanJsonSerializer |    606.4 ns |   4.2510 ns |   3.9764 ns |    606.3 ns | 0.0563 |     240 B |
|                  SerializeAnswerWithSpanJsonSerializer |  5,879.9 ns |   3.1584 ns |   2.6374 ns |  5,880.5 ns | 0.8926 |    3768 B |
|                   SerializeBadgeWithSpanJsonSerializer |  1,199.6 ns |   0.7159 ns |   0.6697 ns |  1,199.4 ns | 0.1926 |     816 B |
|                 SerializeCommentWithSpanJsonSerializer |  2,303.9 ns |  28.8096 ns |  26.9485 ns |  2,307.3 ns | 0.3548 |    1496 B |
|                   SerializeErrorWithSpanJsonSerializer |    307.1 ns |   0.1833 ns |   0.1715 ns |    307.2 ns | 0.0415 |     176 B |
|                   SerializeEventWithSpanJsonSerializer |    645.8 ns |   0.3310 ns |   0.2934 ns |    645.6 ns | 0.0753 |     320 B |
|              SerializeMobileFeedWithSpanJsonSerializer |  7,726.3 ns |   7.8319 ns |   6.5400 ns |  7,727.7 ns | 1.5106 |    6352 B |
|          SerializeMobileQuestionWithSpanJsonSerializer |    926.1 ns |   0.1966 ns |   0.1642 ns |    926.1 ns | 0.1478 |     624 B |
|         SerializeMobileRepChangeWithSpanJsonSerializer |    492.5 ns |   3.7048 ns |   3.0936 ns |    491.5 ns | 0.0696 |     296 B |
|         SerializeMobileInboxItemWithSpanJsonSerializer |    887.0 ns |   0.2776 ns |   0.2597 ns |    887.1 ns | 0.1287 |     544 B |
|        SerializeMobileBadgeAwardWithSpanJsonSerializer |    805.7 ns |   0.3032 ns |   0.2688 ns |    805.8 ns | 0.1135 |     480 B |
|         SerializeMobilePrivilegeWithSpanJsonSerializer |    708.5 ns |   0.1011 ns |   0.0945 ns |    708.5 ns | 0.1154 |     488 B |
| SerializeMobileCommunityBulletinWithSpanJsonSerializer |  1,053.5 ns |   0.8853 ns |   0.7393 ns |  1,053.6 ns | 0.1736 |     736 B |