using APIWeb.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace APIWeb.Services
{
    public class HeroesService
    {

        public HeroesService() { }

        internal void AddHeroes()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var nameSize = new char[random.Next(8)];
            var classePlayerSize = new int[random.Next(3)];

            string[] classePlayer =
            {
                "Warrior", "Mage", "Thief"
            };

            for (int i = 0; i < nameSize.Length; i++)
            {
                nameSize[i] = characters[random.Next(characters.Length)];
            }

            for (int i = 0; i < classePlayerSize.Length; i++)
            {
                classePlayerSize[i] = characters[random.Next(3)];
            }

            string namePlayerGenerate = new string (nameSize);
            string classePlayerGenerate = classePlayer[classePlayerSize];
            var forcePlayer = new int[random.Next(101)];
            var sagessePlayer = new int[random.Next(101)];
            var vitalityPlayer = new int[random.Next(101)];

            Console.WriteLine(namePlayerGenerate + " " + classePlayerGenerate + " " + forcePlayer + " " + sagessePlayer + " " + vitalityPlayer);

        }
    }
}

    /**
     *     public string name { get; set; } = string.Empty;

    public long force { get; set; }

    public long sagesse { get; set; }

    public long vitality { get; set; }*/