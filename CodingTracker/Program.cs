using System;
namespace Chicken
{
    class NollowaChicken
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Input the number you like");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the width");
            int totalColumn = Convert.ToInt32(Console.ReadLine());

            int totalRow = totalColumn;
            for (int row = 0; row < totalRow; row++)
            {
                for (int col = 0; col < totalColumn; col++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                totalColumn--;


            }

            Console.ReadKey();

        }
    }
}

