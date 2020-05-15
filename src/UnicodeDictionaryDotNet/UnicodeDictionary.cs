using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EastAsianWidthDotNet;

namespace UnicodeDictionaryDotNet
{
    public class UnicodeDictionary
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<IEnumerable<EastAsianWidthRange>> GetEastAsianWidthRangesAsync()
        {
            var dictionary = await _httpClient.GetStringAsync("https://www.unicode.org/Public/UCD/latest/ucd/EastAsianWidth.txt");

            return EastAsianWidthParser.Parse(dictionary).Normalize();
        }
    }
}