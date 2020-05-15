﻿using System.Globalization;

namespace EastAsianWidthDotNet
{
    public static partial class EastAsia
    {
        /// <summary>
        /// Indicates whether CultureInfo.CurrentUICulture is East Asia.
        /// </summary>
        /// <returns></returns>
        public static bool IsEastAsia()
        {
            return !NotEastAsiaNames.Contains(CultureInfo.CurrentUICulture.Name);
        }

        /// <summary>
        /// Indicates whether CultureInfo is East Asia.
        /// </summary>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public static bool IsEastAsia(CultureInfo cultureInfo)
        {
            return !NotEastAsiaNames.Contains(cultureInfo.Name);
        }

    }
}