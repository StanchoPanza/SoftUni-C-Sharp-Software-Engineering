using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            if (city == "Sofia")
            {
                if (sales > 10000)
                {
                    commission = 0.12;
                }
                else if (sales <= 10000 && sales > 1000)
                {
                    commission = 0.08;

                }
                else if (sales <= 1000 && sales > 500)
                {
                    commission = 0.07;
                }
                else if (sales <= 500 && sales > 0)
                {
                    commission = 0.05;
                }
                
            }
            if (city == "Varna")
            {
                if (sales > 10000)
                {
                    commission = 0.13;
                }
                else if (sales <= 10000 && sales > 1000)
                {
                    commission = 0.1;

                }
                else if (sales <= 1000 && sales > 500)
                {
                    commission = 0.075;
                }
                else if (sales <= 500 && sales > 0)
                {
                    commission = 0.045;
                }
                
            }
            
            if (city == "Plovdiv")
            {
                if (sales > 10000)
                {
                    commission = 0.145;
                }
                else if(sales <= 10000 && sales > 1000)
                {
                    commission = 0.12;

                }
                else if(sales <= 1000 && sales > 500)
                {
                    commission = 0.08;
                }
                else if(sales <= 500 && sales > 0)
                {
                    commission = 0.055;
                }
            }
            double total = sales * commission;

            if (commission > 0 || city == "Sofia" && city == "Varna" && city == "Plovdiv")
            {
                Console.WriteLine($"{total:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        
    }
}
