using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFiveLab
{
    public abstract class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Game g1 =
            //   new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));
            //the object is initialised and these variables are passed to the constructor at the same time

            /*Game g2 =
                new Game() { Price = 10.99m, ReleaseDate = new DateTime(2000, 6, 15) };
            the object is initialized and the variables are passed afterwards.Since name is a read - only
            it cannot be set here */
            ComputerGame cg1 = new ComputerGame ("Sonic", 29.99m, new DateTime (1990,3,15), "U");
            ComputerGame cg2 = new ComputerGame ("Mario", 24.99m, new DateTime (1995,11,17), "7");


            Console.WriteLine("{0,-15}{1,-15}{2,-30}{3,-15}", "NAME", "PRICE", "RELEASE DATE", "PEGI");
            // DisplayGame(g1);
            // DisplayGame(g2);
            DisplayGame(cg1);
            Console.WriteLine(cg2.GetDiscountPrice()); //displays discounted price
            DisplayGame(cg2);

            Console.WriteLine();

            int result = 23.By2Less1();
            string text = "this is a test sentence";
            string text2 = "this is a test sentence hdcyvbcqwv";
            Console.WriteLine("The number of words in \"{0}\" is {1}", text, text.WordCount());

            Console.WriteLine(result);

        }
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
        public static int WordCount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }

        public static int By2Less1(this int num)
        {
            return num * 2 - 1;
        }
    }
}
