using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Formats.Tar;

namespace ApplicationConsoleCSharp
{
    public class Players
    {
        List<Players> players = new List<Players> { };
        public Players() { }
        public Players(string name, string game, int score)
        {
            playerName = name;
            playerGame = game;
            playerScore = score;
        }
        public string playerName { get; set; }
        public string playerGame { get; set; }
        public int playerScore { get; set; }
        public void AddPlayer(Players player)
        {
            try
            {
                players.Add(player);
                string name = player.playerName;
                string game = player.playerGame;
                var CurrentDirectory = Directory.GetCurrentDirectory();
                if (player.playerGame == "*** Stone/Sheet/Scissors ***")
                {
                    StreamWriter addPlayerToTxt = new StreamWriter(CurrentDirectory + "Stone_Sheet_Scissors" + ".txt", true);
                    addPlayerToTxt.WriteLine(player.playerName + " " + player.playerGame + " " + player.playerScore);
                    addPlayerToTxt.Close();
                }
                if (player.playerGame == "*** The right price ***")
                {
                    StreamWriter addPlayerToTxt = new StreamWriter(CurrentDirectory + "right_price" + ".txt", true);
                    addPlayerToTxt.WriteLine(player.playerName + " " + player.playerGame + " " + player.playerScore);
                    addPlayerToTxt.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void ReadPlayer()
        {
            String highScore;
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*                              HIGH SCORE                                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*                          Name *** Game *** Score                           *");
            Console.WriteLine("******************************************************************************");
            var CurrentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("*****                   Score for Stone/leaf/Scissors                    *****");
            if (File.Exists(CurrentDirectory + "Stone_Sheet_Scissors" + ".txt"))
            {
                StreamReader readerStoneSheetScissors = new StreamReader(CurrentDirectory + "Stone_Sheet_Scissors" + ".txt");
                highScore = readerStoneSheetScissors.ReadLine();
                    while (highScore != null)
                    {
                        Console.WriteLine("*                       " + highScore);
                        highScore = readerStoneSheetScissors.ReadLine();
                    }
                    readerStoneSheetScissors.Close();
            }
            else
            {
                Console.WriteLine("*                                                                            *");
                Console.WriteLine("*                     Aucun score n'est encore réalisé                       *");
            }

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*****                   Score for The right price                        *****");
            if (File.Exists(CurrentDirectory + "right_price" + ".txt"))
            {
                StreamReader readerRightPrice = new StreamReader(CurrentDirectory + "right_price" + ".txt");
                highScore = readerRightPrice.ReadLine();
                while (highScore != null)
                {
                    Console.WriteLine("*                       " + highScore);
                    highScore = readerRightPrice.ReadLine();
                }
                readerRightPrice.Close();
            }
            else
            {
                Console.WriteLine("*                                                                            *");
                Console.WriteLine("*                     Aucun score n'est encore réalisé                       *");
            }
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Press enter to exit");
        }
    }
}
