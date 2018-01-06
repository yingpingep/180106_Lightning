using System;
using System.IO;
using System.Threading.Tasks;

namespace NCLyric20App
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Give me a number: ");
            string index = Console.ReadLine();
            Task.Run(async () =>
            {
                Console.WriteLine(await NSLyricTest.Lyric.GetLyricAsync(index));
            });
            
            Console.ReadLine();
        }
    }
}
