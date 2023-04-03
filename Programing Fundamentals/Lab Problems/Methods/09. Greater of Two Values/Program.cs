using System;

namespace GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            if (type == "int")
            {
                var a = int.Parse(input1);
                var b = int.Parse(input2);
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "char")
            {
                var a = char.Parse(input1);
                var b = char.Parse(input2);
                Console.WriteLine(GetMax(a, b));
            }
            else
            {
                Console.WriteLine(GetMax(input1, input2));
            }

        }

        public static string GetMax(int a, int b)
        {
            if (a > b)
            {
                return a.ToString();
            }
            return b.ToString();
        }

        public static string GetMax(char a, char b)
        {
            if (a > b)
            {
                return a.ToString();
            }
            return b.ToString();
        }

        public static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) == 1)
            {
                return a;
            }
            return b;
        }
    }
}
