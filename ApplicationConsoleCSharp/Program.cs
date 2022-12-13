using ApplicationConsoleCSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ApplicationConsoleCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int finishProgram = 0;
            Players newPlayer = new Players();

            while (finishProgram == 0)
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                        DASHBOARD                             *");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                          MENU                                *");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*              Choice 1: The right price                       *");
                Console.WriteLine("*              Choice 2: Stone/leaf/Scissors                   *");
                Console.WriteLine("*              Choice 3 : High Score                           *");
                Console.WriteLine("*              Choice 4 : Quit the application                 *");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("                                                                ");
                Console.WriteLine("What is your choice?");
                int choice = (int.Parse(Console.ReadLine()));
                Game newGame = new Game();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        newGame.RightPrice();
                        break;

                    case 2:
                        Console.Clear();
                        newGame.StoneLeafScissors();
                        break;

                    case 3:
                        Console.Clear();
                        newPlayer.ReadPlayer();
                        Console.ReadLine();
                        break;

                    case 4:
                        finishProgram = 1;
                        Console.WriteLine("Thanks for playing and see you soon !");
                        
                        break;

                    default:
                        break;
                }
            }
        }       
    }
}
