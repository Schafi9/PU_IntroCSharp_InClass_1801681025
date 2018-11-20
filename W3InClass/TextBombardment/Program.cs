using System;

namespace TextBombardment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence you wish to bombatd: ");
            string sentence = Console.ReadLine();
            try
            {
                int lineWidth = int.Parse(Console.ReadLine());
                string bombIndex = Console.ReadLine();
                //Console.WriteLine(sentence);
                //Console.WriteLine(lineWidth);
                //Console.WriteLine(bombIndex);

                double rows = sentence.Length / lineWidth;
                //if (rows%2==0)
                //{
                    for (int i = 0; i < sentence.Length; i++)
                    {
                        Console.Write(sentence[i]);
                        if (i==lineWidth)
                        {
                            Console.Write("\n");
                        }
                    }
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
