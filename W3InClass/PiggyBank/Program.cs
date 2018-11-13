using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 30;
            int saving = 2;
            int throwAwayForFalseVodka = 5;
            int monthsInYear = 12;
            double result = 0;
            try
            {
                int tankPrice = int.Parse(Console.ReadLine());
                int partyDays = int.Parse(Console.ReadLine());
                
                int daysWithoutVodka = days - partyDays;
                int totalMonthSaaving = daysWithoutVodka * saving;
                int netSaving = totalMonthSaaving - (throwAwayForFalseVodka * partyDays);
                double monthForSaving4Tank = tankPrice / netSaving;
                result = monthForSaving4Tank / monthsInYear;
            }
           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please try again later!");
                
            }
            if (result < 0) Console.WriteLine("Never!");
            else
            {
                result = Math.Round(result, 1, MidpointRounding.AwayFromZero);
                //Console.WriteLine($"{result} years");
                string months = result.ToString().Split(',')[1];
                Console.WriteLine($"{(int)result} years {months}months!");
            }
        }
    }
}