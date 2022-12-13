using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ApplicationConsoleCSharp
{
    public class Game
    {
        Players newPlayer = new Players();
        public void StoneLeafScissors()
        {
            var rand = new Random();
            int party = 0;
            int nbGameWin = 0;
            string game = "*** Stone/Sheet/Scissors ***";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*                   Stone/Sheet/Scissors                                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*                        The rules                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Rule number 1: You will have to choose between stone, leaf and chisel      *");
            Console.WriteLine("* Rule number 2: There will be 3 rounds!                                     *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("* Rule number 4: Be brave!                                                   *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("What is the name of the player ?");
            string name = Console.ReadLine();
            Console.WriteLine("");
            while (party < 3)
            {
                int randomNumber = rand.Next(3);
                Console.WriteLine("What is your choice?");
                Console.WriteLine(" 0 : Stone ? ");
                Console.WriteLine(" 1 : Sheet ? ");
                Console.WriteLine(" 2 : Scissors ? ");
                int choiceNumber = (int.Parse(Console.ReadLine()));
                Console.WriteLine("");
                if (choiceNumber == randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(" Equality ! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                if (choiceNumber == 0 && randomNumber == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" You lost ! The computer did Scissors !");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                if (choiceNumber == 0 && randomNumber == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" You Win ! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    nbGameWin++;
                }
                if (choiceNumber == 1 && randomNumber == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" You Win ! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    nbGameWin++;
                }
                if (choiceNumber == 1 && randomNumber == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" You lost  The computer did Scissors !");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                if (choiceNumber == 2 && randomNumber == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" You Win ! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    nbGameWin++;
                }
                if (choiceNumber == 2 && randomNumber == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" You lost  The computer did Stone !");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                party++;
            }
            if (nbGameWin >= 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win this game ! " + nbGameWin + "/3");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lost this game ! " + nbGameWin + "/3");
                Console.ForegroundColor = ConsoleColor.White;
            }
            var player = new Players(name, game, nbGameWin);
            newPlayer.AddPlayer(player);
            Console.WriteLine("");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
        public void RightPrice()
        {
            var rand = new Random();
            int randomNumber = rand.Next(1001);
            int finishProgram = 0;
            int attempt = 1;
            string game = "*** The right price ***";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*                     The right price                                 *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*                      The rules                                      *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Rule number 1: Find the price thou shalt.                           *");
            Console.WriteLine("* Rule number 2: You will only be allowed a maximum of 10 attempts.   *");
            Console.WriteLine("* Rule number 4: Be brave!                                            *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("                                                                       ");
            Console.WriteLine("                                                                       ");
            Console.WriteLine("What is the name of the player ?");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The price is between 0 and 1000, what is its price ? ");
            while (attempt < 11 && finishProgram == 0)
            {
                int choixNumber = (int.Parse(Console.ReadLine()));
                if (choixNumber == randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations, you have found the price in " + attempt + " attempts !");
                    Console.ForegroundColor = ConsoleColor.White;
                    finishProgram = 1;
                }
                if (choixNumber < randomNumber)
                {
                    Console.WriteLine("It's more expensive!");
                    Console.WriteLine("");
                }
                if (choixNumber > randomNumber)
                {
                    Console.WriteLine("It's less expensive !");
                    Console.WriteLine("");
                }
                attempt++;
            }
            if (attempt == 11)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lost !");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }
            attempt = 110 - (attempt * 10);
            var player = new Players(name, game, attempt);
            newPlayer.AddPlayer(player);
            Console.WriteLine("");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
