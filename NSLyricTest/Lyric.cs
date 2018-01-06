using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace NSLyricTest
{
    public class Lyric
    {
        private static string endpoint = "https://oplbackend.azurewebsites.net/api/lyric/";
        public async static Task<string> GetLyricAsync(string index)
        {
            HttpClient hc = new HttpClient();

            string s = await hc.GetStringAsync(endpoint + index);
            return s.Replace("\\n", "\n");
        }
    }
}
