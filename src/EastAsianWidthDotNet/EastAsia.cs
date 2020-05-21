 
 
using System.Collections.Generic;
using System.Globalization;

namespace EastAsianWidthDotNet
{
    /// <summary>
    /// East Asia in EastAsianWidth.
    /// </summary>
    public static partial class EastAsia
    {
        /// <summary>
        /// East Asia CultureInfo.
        /// </summary>
        private static readonly HashSet<string> EastAsiaNames = 
            new HashSet<string>(
                new []
                {
                    "ja", // Japanese
                    "ja-JP", // Japanese (Japan)
                    "ko", // Korean
                    "ko-KP", // Korean (North Korea)
                    "ko-KR", // Korean (Korea)
                    "vi", // Vietnamese
                    "vi-VN", // Vietnamese (Vietnam)
                    "zh", // Chinese
                    "zh-CHS", // Chinese (Simplified) Legacy
                    "zh-CHT", // Chinese (Traditional) Legacy
                    "zh-CN", // Chinese (Simplified, China)
                    "zh-Hans", // Chinese (Simplified)
                    "zh-Hans-HK", // Chinese (Simplified Han, Hong Kong SAR)
                    "zh-Hans-MO", // Chinese (Simplified Han, Macao SAR)
                    "zh-Hant", // Chinese (Traditional)
                    "zh-HK", // Chinese (Traditional, Hong Kong SAR)
                    "zh-MO", // Chinese (Traditional, Macao SAR)
                    "zh-SG", // Chinese (Simplified, Singapore)
                    "zh-TW", // Chinese (Traditional, Taiwan)
                });
    }
}