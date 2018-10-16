using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer=Console.ReadLine();

            if (answer=="Yes")
            {
                //Console.WriteLine("Play music!");
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\W3\PU_IntroCSharp_InClass_1801681025\
                W3InClass\MusicFactory\Music\277751539693463.wav"))
                {
                    player.PlaySync();
                }
            }
            else if(answer=="No")
            {
                Console.WriteLine("Goodbye!");
            }
            else if (answer == "Fuck")
            {
                Console.WriteLine("Yes, fuck you too!!!");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
            Console.WriteLine($"My answer is: {answer}");
            
        }
    }
}
