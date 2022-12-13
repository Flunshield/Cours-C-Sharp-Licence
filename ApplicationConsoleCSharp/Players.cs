using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
                StreamWriter addPlayerToTxt = new StreamWriter(CurrentDirectory + name); //Adds a .txt file with the name of the player +his game and his score.
                addPlayerToTxt.WriteLine(player.playerName);
                addPlayerToTxt.WriteLine(player.playerGame);
                addPlayerToTxt.WriteLine(player.playerScore);
                addPlayerToTxt.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void ReadPlayer()
        {
            foreach (var player in players)
            {
                Console.WriteLine("Hello " + player.playerName + " your game is : " + player.playerGame + " and your scrore is : " + player.playerScore);

            }
        }
    }
}
