namespace EastAsianWidthDotNet
{
    /// <summary>
    /// Provide EastAsianWidthRange.
    /// </summary>
    public interface IEastAsianWidthRangesProvider
    {
        /// <summary>
        /// Resolve the EastAsianWidthRange.
        /// </summary>
        /// <returns></returns>
        EastAsianWidthRange[] Resolve();
    }
}