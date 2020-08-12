using System;

namespace PickyEater08122020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times has it been fried? (#) ");
            int timesFried = Convert.ToInt32(Console.ReadLine());



            Console.Write("Does it have any spinach in it? (y/n) ");
            String hasSpinach = Console.ReadLine();



            Console.Write("Is it covered in cheese? (y/n) ");
            String cheeseCovered = Console.ReadLine();



            Console.Write("How many pats of butter are on the top?");
            int butterPats = Convert.ToInt32(Console.ReadLine());



            Console.Write("Is it covered in chocolate? (y/n) ");
            String chocolateCovered = Console.ReadLine();



            Console.Write("Does it have a funny name? (y/n) ");
            String funnyName = Console.ReadLine();



            Console.Write("Is it broccoli? (y/n) ");
            String isBroccoli = Console.ReadLine();



            // Conditionals should go here! Here's the first one for FREE!

            if (hasSpinach.Equals("y") || funnyName.Equals("y"))
            {


                Console.WriteLine("There is no way that'll geet eaten.");
            }
        }
    }
}