using System;
using System.Collections.Generic;
using System.IO;
using EastAsianWidthDotNet;

namespace UnicodeDictionaryDotNet
{
    internal class EastAsianWidthParser
    {
        internal static IList<EastAsianWidthRange> Parse(string dictionary)
        {
            var ranges = new List<EastAsianWidthRange>();

            var lines = dictionary.Split('\n');

            foreach (var line in lines)
            {
                // コメント行
                if (line.StartsWith("#")) continue;
                // 空行
                if (line.Trim().Length == 0) continue;

                ranges.Add(ParseRange(line));
            }

            return ranges;
        }

        private static EastAsianWidthRange ParseRange(string line)
        {
            var values = line.Substring(0, line.IndexOf('#')).Trim().Split(";".ToCharArray());
            var rangeSegments = values[0].Trim();
            var kindSegment = values[1].Trim();

            EastAsianWidthKind kind = kindSegment switch
            {
                "A" => EastAsianWidthKind.Ambiguous,
                "F" => EastAsianWidthKind.FullWidth,
                "H" => EastAsianWidthKind.HalfWidth,
                "Na" => EastAsianWidthKind.Narrow,
                "W" => EastAsianWidthKind.Wide,
                "N" => EastAsianWidthKind.Neutral,
                _ => throw new NotSupportedException($"Not supported kind:{kindSegment}")
            };

            var index = rangeSegments.IndexOf("..", StringComparison.Ordinal);

            int start;
            int end;
            if (index < 0)
            {
                start = Convert.ToInt32(rangeSegments, 16);
                end = start;
            }
            else
            {
                start = Convert.ToInt32(rangeSegments.Substring(0, index), 16);
                end = Convert.ToInt32(rangeSegments.Substring(index + 2, rangeSegments.Length - index - 2), 16);
            }

            return new EastAsianWidthRange(start, end, kind);
        }
    }
}