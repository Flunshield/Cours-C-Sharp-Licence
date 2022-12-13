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
                StreamWriter addPlayerToTxt = new StreamWriter(CurrentDirectory + ".txt", true); //Adds a .txt file with the name of the player +his game and his score.
                addPlayerToTxt.WriteLine(player.playerName + " " + player.playerGame + " " + player.playerScore);
                addPlayerToTxt.Close();
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
                StreamReader reader = new StreamReader(CurrentDirectory + ".txt");
                highScore = reader.ReadLine();
                while (highScore != null)
                {
                    Console.WriteLine("*                       " + highScore);
                    highScore = reader.ReadLine();
                }

                Console.WriteLine("******************************************************************************");
                reader.Close();
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
