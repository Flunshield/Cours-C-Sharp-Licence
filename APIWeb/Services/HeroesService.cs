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
            var nameSize = new char[random.Next(3,9)];
            string[] classePlayer = { "Warrior", "Mage", "Thief" };
            int classePlayerGenerateNumber = random.Next(classePlayer.Length);

            for (int i = 0; i < nameSize.Length; i++)
            {
                nameSize[i] = characters[random.Next(characters.Length)];
            }

            string namePlayerGenerate = new string (nameSize);
            
            int forcePlayer = random.Next(1,101);
            int sagessePlayer = random.Next(101);
            int vitalityPlayer = random.Next(101);
            string classePlayerGenerate = classePlayer[classePlayerGenerateNumber];


        }
    }
}