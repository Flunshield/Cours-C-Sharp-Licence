using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

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
            players.Add (player);
            ReadPlayer();
        }
        public void ReadPlayer()
        {
            foreach (var test in players)
            {
                Console.WriteLine("Hello " + test.playerName + " ton jeu est : " + test.playerGame + " et ton score est de : " + test.playerScore);
            }
        }
    }
}
