using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace NSLyricTest
{
    public class Lyric
    {
        private static string endpoint = "https://oplbackend.azurewebsites.net/api/lyric/";
        public async static Task<string> GetLyricAsync(string number)
        {
            HttpClient hc = new HttpClient();
            return await hc.GetStringAsync(endpoint + number);
        }
    }
}
