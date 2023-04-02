namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int temp = 0;

            int sum = 0;

            bool result = false;

            for (int i = 1; i <= input; i++)
            {
                int num = i%10;

                temp = i;

                while (temp != 0)
                {
                    sum += (temp % 10);
                    temp /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                sum = 0;

                Console.WriteLine(i+" -> "+result);
            }
        }
    }
}