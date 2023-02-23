using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int people = 0;

            int groupMusala = 0;
            int groupMountBlanc = 0;
            int groupKilmanjaro = 0;
            int groupK2 = 0;
            int groupEverest = 0;



            for (int i = 0; i < groups; i++)
            {

                people = int.Parse(Console.ReadLine());
                if (people < 6)
                {
                    groupMusala += people;
                }
                else if (people < 13)
                {
                    groupMountBlanc += people;
                }
                else if (people < 26)
                {
                    groupKilmanjaro += people;
                }
                else if (people < 41)
                {
                    groupK2 += people;
                }
                else if (people > 40)
                {
                    groupEverest += people;
                }
            }
            double totalPeople = groupMusala + groupMountBlanc + groupKilmanjaro + groupK2 + groupEverest;

            Console.WriteLine($"{groupMusala / totalPeople * 100:F2}%");
            Console.WriteLine($"{groupMountBlanc / totalPeople * 100:F2}%");
            Console.WriteLine($"{groupKilmanjaro / totalPeople * 100:F2}%");
            Console.WriteLine($"{groupK2 / totalPeople * 100:F2}%");
            Console.WriteLine($"{groupEverest / totalPeople * 100:F2}%");
        }

    }
}
