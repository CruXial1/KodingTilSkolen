using System;

namespace KodingTilSkolen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Greet the user
            Console.WriteLine("Hello! And welcome to this project\n");
            Console.WriteLine("To proceed please press <ENTER>\n");

            //Check if ENTER was pressed
            if(Console.ReadKey().Key != ConsoleKey.Enter)
            {
                return;
            }
            //If ENTER was pressed, then proceed

            //Change color
            Console.ForegroundColor = ConsoleColor.DarkRed;

            //Tell the user the commands
            Console.WriteLine("Available Commands:\n!rng");

            //Jump a line down
            Console.WriteLine("\n");

            //Start of infinite loop
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                //Tell the user to execute a command
                Console.WriteLine("Please execute a command..\n");

                Console.ForegroundColor = ConsoleColor.Magenta;

                //Check for commands
                switch (Console.ReadLine())
                {
                    //Command "!rng"
                    case "!rng":
                        //Use the "rng()" method created below
                        rng();
                        break;

                    default:
                        Console.WriteLine("Invalid Command.");
                        break;
                }
            }
            //End of infinite loop
        }
        //End of method

        public static void rng()
        {
            //Create the randomizer
            Random rng = new Random();

            //Change font color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //Create the random number generator
            switch(rng.Next(1, 10 + 1))
            {
                case 1:
                    Console.WriteLine("\nThe generator rolled 1");
                    break;

                case 2:
                    Console.WriteLine("\nThe generator rolled 2");
                    break;

                case 3:
                    Console.WriteLine("\nThe generator rolled 3");
                    break;

                case 4:
                    Console.WriteLine("\nThe generator rolled 4");
                    break;

                case 5:
                    Console.WriteLine("\nThe generator rolled 5");
                    break;

                case 6:
                    Console.WriteLine("\nThe generator rolled 6");
                    break;

                case 7:
                    Console.WriteLine("\nThe generator rolled 7");
                    break;

                case 8:
                    Console.WriteLine("\nThe generator rolled 8");
                    break;

                case 9:
                    Console.WriteLine("\nThe generator rolled 9");
                    break;

                default:
                    Console.WriteLine("\nThe generator rolled Default");
                    break;
            }
            //Jump a line down (for cleaner looks)
            Console.WriteLine("\n");
        }
    }
}
