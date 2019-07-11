using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kinda doing it the hard way on purpose so I can reference it later if I need to.
            string[] stringArray = new string[10];
            stringArray[0] = "Toad";
            stringArray[1] = "Yoshi";
            stringArray[2] = "Princess Peach";
            stringArray[3] = "Donkey Kong";
            stringArray[4] = "Bowser";
            stringArray[5] = "Mario";
            stringArray[6] = "Wario";
            stringArray[7] = "Luigi";
            stringArray[8] = "Diddy Kong";
            stringArray[9] = "Koopa";

            //Easy array mode
            int[] intArray = new int[] {320, 1, 12777, 49, 60, 25, 4, 10, 45, 22};
      
            //list
            List<string> stringList = new List<string>();
            stringList.Add("Star Cup");
            stringList.Add("Flower Cup");
            stringList.Add("Mushroom Cup");
            stringList.Add("Special Cup");


            Console.WriteLine("Welcome to my shop!");
            Console.WriteLine("I'm a psychic, but only concerning Mario Kart!");

            Console.WriteLine("First thing first, give me a number between 0 and 9: ");
            int firstChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Based on your choice of " +firstChoice+ " my crystal ball is telling me your favorite character in Mario Kart is "+stringArray[firstChoice]);

            Console.WriteLine("Now, give me another number between 0 and 9: ");
            int secondChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Based on your choice of " +secondChoice+ " the spirits are telling me you've played " +intArray[secondChoice]+" games of Mario Kart!");

            Console.WriteLine("A final number between 0 and 3: ");
            int thirdChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Based on your choice of " +thirdChoice+ " the cosmos has rewarded you with the " +stringList[thirdChoice]);

            Console.WriteLine("Ok. Now leave this shop! Go home and play more Mario Kart!!");

            Console.ReadLine();
        }
    }
}
