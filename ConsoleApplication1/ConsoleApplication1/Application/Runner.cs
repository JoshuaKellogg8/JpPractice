using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JpPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Kanji cn = new Kanji();
            List<char> vowels = new List<char> { 'A','E','I','O','U' };
            Random rand = new Random();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
            player.Play();

            for (;;)
            {
                var key = Console.ReadKey(true);

                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    Console.WriteLine(vowels.ElementAt<char>(rand.Next(0,vowels.Count)));
                }
                if (key.Key.Equals(ConsoleKey.Escape))
                {
                    break;
                }
            }

        }

    }
}
