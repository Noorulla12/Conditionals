using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Monsoon;

            switch (season)
            { 
                case Season.Autumn:
                    Console.WriteLine("It's very beautiful season let's enjoy!!");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's too hot let's have a Badam Drink");
                    break;
                case Season.Winter:
                    Console.WriteLine("This is a very Good oppurtunity for fasting!!");
                    break;
                case Season.Monsoon:
                    Console.WriteLine("It's very Good Season for fasting and Hajj!! alhamdulillaah");
                    break;
                default:
                    Console.WriteLine("oops, I'm not knowing what season it's!!");
                    break;


            }


        }
    }
}