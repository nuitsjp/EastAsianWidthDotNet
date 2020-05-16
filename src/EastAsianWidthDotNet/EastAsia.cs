 
 
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
        /// Not in East Asia CultureInfo.
        /// </summary>
        private static readonly HashSet<string> NotEastAsiaNames = 
            new HashSet<string>(
                new []
                {
                    "ru", // Russian
                    "ru-BY", // Russian (Belarus)
                    "ru-KG", // Russian (Kyrgyzstan)
                    "ru-KZ", // Russian (Kazakhstan)
                    "ru-MD", // Russian (Moldova)
                    "ru-RU", // Russian (Russia)
                    "ru-UA", // Russian (Ukraine)
                    "uk", // Ukrainian
                    "uk-UA", // Ukrainian (Ukraine)
                    "be", // Belarusian
                    "be-BY", // Belarusian (Belarus)
                    "bg", // Bulgarian
                    "bg-BG", // Bulgarian (Bulgaria)
                    "mk", // Macedonian
                    "mk-MK", // Macedonian (North Macedonia)
                    "az-Cyrl", // Azerbaijani (Cyrillic)
                    "az-Cyrl-AZ", // Azerbaijani (Cyrillic, Azerbaijan)
                    "bs-Cyrl", // Bosnian (Cyrillic)
                    "bs-Cyrl-BA", // Bosnian (Cyrillic, Bosnia and Herzegovina)
                    "mn-Cyrl", // Mongolian
                    "sr-Cyrl", // Serbian (Cyrillic)
                    "sr-Cyrl-BA", // Serbian (Cyrillic, Bosnia and Herzegovina)
                    "sr-Cyrl-ME", // Serbian (Cyrillic, Montenegro)
                    "sr-Cyrl-RS", // Serbian (Cyrillic, Serbia)
                    "sr-Cyrl-XK", // Serbian (Cyrillic, Kosovo)
                    "tg-Cyrl", // Tajik (Cyrillic)
                    "tg-Cyrl-TJ", // Tajik (Cyrillic, Tajikistan)
                    "uz-Cyrl", // Uzbek (Cyrillic)
                    "uz-Cyrl-UZ", // Uzbek (Cyrillic, Uzbekistan)
                    "os", // Ossetic
                    "os-GE", // Ossetic (Georgia)
                    "os-RU", // Ossetic (Russia)
                    "el", // Greek
                    "el-CY", // Greek (Cyprus)
                    "el-GR", // Greek (Greece)
                });
    }
}