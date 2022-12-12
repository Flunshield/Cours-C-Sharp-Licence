using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationConsoleCSharp
{
    internal class Player
    {
        public string Name;
        public int tenta;
        public string game;
        public Player(string personName, int personTenta, string personGame)
        {
            this.Name = personName;
            this.tenta = personTenta;
            this.game = personGame;
        }

        public string GetName()
        {
            return this.Name;
        }
        public int GetTenta()
        {
            return this.tenta;
        }
        public int GetGame()
        {
            return this.tenta;
        }
    }
}
