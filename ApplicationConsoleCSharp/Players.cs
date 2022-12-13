using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

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
        public void AddPlayer (Players player)
        {
            try
            {
                players.Add(player);
                string name = player.playerName;
                string game = player.playerGame; 
                var CurrentDirectory = Directory.GetCurrentDirectory();
                if(player.playerGame == "*** Stone/Sheet/Scissors ***")
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
            try
            {
                var CurrentDirectory = Directory.GetCurrentDirectory();
                StreamReader readerStoneSheetScissors = new StreamReader(CurrentDirectory + "Stone_Sheet_Scissors" + ".txt");
                highScore = readerStoneSheetScissors.ReadLine();
                Console.WriteLine("*****                   Score for Stone/leaf/Scissors                    *****");
                Console.WriteLine("");
                while (highScore != null)
                {
                    Console.WriteLine("*                       " + highScore);
                    highScore = readerStoneSheetScissors.ReadLine();
                }
                readerStoneSheetScissors.Close();
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("*****                   Score for The right price                        *****");
                StreamReader readerRightPrice = new StreamReader(CurrentDirectory + "Stone_Sheet_Scissors" + ".txt");
                highScore = readerRightPrice.ReadLine();
                while (highScore != null)
                {
                    Console.WriteLine("*                       " + highScore);
                    highScore = readerRightPrice.ReadLine();
                }
                readerStoneSheetScissors.Close();
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("");
                Console.WriteLine("Press enter to exit");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
