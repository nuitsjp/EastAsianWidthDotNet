namespace EastAsianWidthDotNet
{
    /// <summary>
    /// Kind by Range in the Unicode dictionary.
    /// </summary>
    public readonly struct EastAsianWidthRange
    {
        /// <summary>
        /// Resolve instance.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="kind"></param>
        public EastAsianWidthRange(int start, int end, EastAsianWidthKind kind)
        {
            Start = start;
            End = end;
            Kind = kind;
        }

        /// <summary>
        /// Get the start of the Range.
        /// </summary>
        public int Start { get; }

        /// <summary>
        /// Get the end of the Range.
        /// </summary>
        public int End { get; }

        /// <summary>
        /// Kind by Range. 
        /// </summary>
        public EastAsianWidthKind Kind { get; }
    }
}
