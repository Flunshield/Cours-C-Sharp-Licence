using APIWeb.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace APIWeb.Services
{
    public class Heroes
    {
        List<Heroes> heroes = new List<Heroes> { };
        public Heroes() { }
        public Heroes(string namePlayerGenerate, long forcePlayer, long sagessePlayer, long vitalityPlayer, string classePlayerGenerate)
        {
            int Id;
            this.namePlayerGenerate = namePlayerGenerate;
            this.forcePlayer = forcePlayer;
            this.sagessePlayer = sagessePlayer;
            this.vitalityPlayer = vitalityPlayer;
            this.classePlayerGenerate = classePlayerGenerate;
        }
        public string namePlayerGenerate { get; set; }
        public long forcePlayer { get; set; }
        public long sagessePlayer { get; set; }
        public long vitalityPlayer { get; set; }
        public string classePlayerGenerate { get; set; }

        internal Heroes AddHeroes()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var nameSize = new char[random.Next(3,9)];
            string[] classePlayer = { "Warrior", "Mage", "Thief" };
            int classePlayerGenerateNumber = random.Next(classePlayer.Length);

            for (int i = 0; i < nameSize.Length; i++)
            {
                nameSize[i] = characters[random.Next(characters.Length)];
            }

            string namePlayerGenerate = new string(nameSize);
            long forcePlayer = random.Next(1, 101);
            long sagessePlayer = random.Next(101);
            long vitalityPlayer = random.Next(101);
            string classePlayerGenerate = classePlayer[classePlayerGenerateNumber];


            Heroes heroes = new Heroes(namePlayerGenerate, forcePlayer, sagessePlayer, vitalityPlayer, classePlayerGenerate);
            return heroes;
        }
    }
}