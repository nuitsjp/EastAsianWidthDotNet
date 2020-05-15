using System.Collections.Generic;
using System.Linq;
using EastAsianWidthDotNet;

namespace UnicodeDictionaryDotNet
{
    internal static class EastAsianWidthNormalizer
    {
        internal static IEnumerable<EastAsianWidthRange> Normalize(this IList<EastAsianWidthRange> ranges)
        {
            var previous = ranges.First();
            foreach (var current in ranges.Skip(1))
            {
                if (1 < current.Start - previous.End)
                {
                    // If there is a gap between previous and current, fill the gap with Neutral.
                    if (previous.Kind == EastAsianWidthKind.Neutral)
                    {
                        previous = 
                            Marge(
                                previous, 
                                new EastAsianWidthRange(
                                    previous.End + 1,
                                    current.Start - 1,
                                    EastAsianWidthKind.Neutral));
                    }
                    else
                    {
                        yield return previous;
                        previous =
                            new EastAsianWidthRange(
                                previous.End + 1,
                                current.Start - 1,
                                EastAsianWidthKind.Neutral);
                    }
                }

                if (previous.Kind == current.Kind)
                {
                    previous = Marge(previous, current);
                }
                else
                {
                    yield return previous;
                    previous = current;
                }
            }

            if (previous.Kind == EastAsianWidthKind.Neutral)
            {
                yield return new EastAsianWidthRange(previous.Start, int.MaxValue, previous.Kind);
            }
            else
            {
                yield return previous;
                yield return new EastAsianWidthRange(previous.End + 1, int.MaxValue, EastAsianWidthKind.Neutral);
            }
        }

        private static EastAsianWidthRange Marge(EastAsianWidthRange first, EastAsianWidthRange second)
        {
            return
                new EastAsianWidthRange(
                    first.Start,
                    second.End,
                    second.Kind);
        }
    }
}