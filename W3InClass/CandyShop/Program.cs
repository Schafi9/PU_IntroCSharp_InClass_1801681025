using System;
using System.IO;
using System.Text;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int smiley = 9786;
            Console.WriteLine((char)smiley);
            //Console.InputEncoding = Encoding.UTF8;
            //char d = 'd';
            //Console.WriteLine((int)d);
            //string firstName = Console.ReadLine();
            //string lastName = "Бончо";
            //string fullName = $"{firstName} {lastName}";
            //Console.WriteLine($"Candy for {fullName}!");
            string[] lines =File.ReadAllLines(@"C:\Users\fmi\Desktop\class\PU_IntroCSharp_InClass_1801681025\W3InClass\CandyShop\files\students1.txt");

            // Display the file contents by using a foreach loop.
            Console.WriteLine("Contents of students1.txt = ");
            foreach (string line in lines)
            {
                string[] currentElements = line.Split(' ');
                string firstName = currentElements[1];
                string lastName = currentElements[3];
                string fullName = $"{firstName} {lastName}";

                int sum = 0;
                for (int i = 0; i < firstName.Length; i++)
                {
                    sum += (int)firstName[i];
                }
                // Use a tab to indent each line of the file.
                //Console.WriteLine("\t" + line);
                Console.WriteLine($"Candy for {fullName} => {sum}");
            }

        }
    }
}
