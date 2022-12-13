using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationConsoleCSharp
{
    public class Game
    {
        Players newPlayer = new Players();
        public Players StoneLeafScissors()
        {
            var rand = new Random();
            int party = 0;
            int nbGameWin = 0;
            string game = "Stone/Sheet/Scissors";

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
                    Console.WriteLine(" Equality ! ");
                    Console.WriteLine("");
                }
                if (choiceNumber == 0 && randomNumber == 1)
                {
                    Console.WriteLine(" You lost ! The computer did Scissors !");
                    Console.WriteLine("");
                }
                if (choiceNumber == 0 && randomNumber == 2)
                {
                    Console.WriteLine(" You Win ! ");
                    Console.WriteLine("");
                    nbGameWin++;
                }
                if (choiceNumber == 1 && randomNumber == 0)
                {
                    Console.WriteLine(" You Win ! ");
                    Console.WriteLine("");
                    nbGameWin++;
                }
                if (choiceNumber == 1 && randomNumber == 2)
                {
                    Console.WriteLine(" You lost  The computer did Scissors !");
                    Console.WriteLine("");
                }
                if (choiceNumber == 2 && randomNumber == 1)
                {
                    Console.WriteLine(" You Win ! ");
                    Console.WriteLine("");
                    nbGameWin++;
                }
                if (choiceNumber == 2 && randomNumber == 0)
                {
                    Console.WriteLine(" You lost  The computer did Stone !");
                    Console.WriteLine("");
                }
                party++;
            }

            var player = new Players(name, game, nbGameWin);
            newPlayer.AddPlayer(player);
            Console.WriteLine("");
            return player;
        }

        public Players RightPrice()
        {
            var rand = new Random();
            int randomNumber = rand.Next(101);
            int finishProgram = 0;
            int tentative = 0;
            string game = "The right price";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*                     The right price                                 *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*                      The rules                                      *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Rule number 1: Find the price thou shalt.                           *");
            Console.WriteLine("* Rule number 2: You will only be allowed a maximum of 10 attempts.   *");
            Console.WriteLine("* Rule number 3: Your time will be counted                            *");
            Console.WriteLine("* Rule number 4: Be brave!                                            *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("                                                                       ");
            Console.WriteLine("                                                                       ");
            Console.WriteLine("What is the name of the player ?");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The price is between 0€ and 100€, what is its price ? ");
            while (tentative < 11 && finishProgram == 0)
            {
                int choixNumber = (int.Parse(Console.ReadLine()));
                if (choixNumber == randomNumber)
                {
                    Console.WriteLine("Congratulations, you have found the price in " + tentative + " attempts !");
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
                tentative++;
            }
            if (tentative == 11)
            {
                Console.WriteLine("You lost !");
                Console.WriteLine("");
            }
            var player = new Players(name, game, tentative);
            newPlayer.AddPlayer(player);
            Console.WriteLine("");
            return player;
        }
    }
}
