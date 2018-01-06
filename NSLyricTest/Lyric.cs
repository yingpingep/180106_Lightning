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
<<<<<<< HEAD

            string s = await hc.GetStringAsync(endpoint + index);
            return s.Replace("\\n", "\n");
=======
            string res = await hc.GetStringAsync(endpoint + number);
            res = res.Replace("\\n", "\n");
            res = res.Substring(1, res.Length - 2);
            return res;
>>>>>>> development
        }
    }
}
