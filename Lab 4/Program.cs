using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Learn your squares and cubes!\n");
                Console.Write("Enter an interger: ");
                //int userInput = int.Parse(Console.ReadLine());
                int userInput;
                bool valid = false;
                valid = int.TryParse(Console.ReadLine(), out userInput);
                int z = Square(userInput);
                int o = Cube(userInput);

                Console.WriteLine("Number\t\tSquare\t\tCube");
                Console.WriteLine("======\t\t=======\t\t======");

                for (int x = 1; x <= userInput; x++)
                {
                    z = Square(x);
                    o = Cube(x);

                    Console.WriteLine(x + "\t\t" + z + "\t\t" + o);
                }
                    Console.Write("Thanks for Squaring and Cubing with us today!\nWould you like to enter a new value? (y/n) ");

                string go = Console.ReadLine().ToLower();
                if (go == "y")
                {
                    Console.Clear();
                    repeat = true;
                }
                else if (go == "n")
                {
                    Console.WriteLine("Goodbye");
                    repeat = false;
                }
                else
                {
                    repeat = false;
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static int Square(int x)
        {
            int squared =  x * x;
            return squared;
        }
        public static int Cube(int x)
        {
            int cubed = x * x * x;
            return cubed;
        }
    }
}
