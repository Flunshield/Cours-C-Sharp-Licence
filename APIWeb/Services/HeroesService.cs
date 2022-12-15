﻿using APIWeb.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace APIWeb.Services
{
    public class HeroesService
    {
        public HeroesService() { }
        public HeroesService(string namePlayerGenerate, long forcePlayer, long sagessePlayer, long vitalityPlayer, string classePlayerGenerate, string armsPlayerGenerate)
        {
            this.namePlayerGenerate = namePlayerGenerate;
            this.forcePlayer = forcePlayer;
            this.sagessePlayer = sagessePlayer;
            this.vitalityPlayer = vitalityPlayer;
            this.classePlayerGenerate = classePlayerGenerate;
            this.armsPlayerGenerate = armsPlayerGenerate;
        }
        public string namePlayerGenerate { get; set; } = string.Empty;
        public long forcePlayer { get; set; }
        public long sagessePlayer { get; set; }
        public long vitalityPlayer { get; set; }
        public string classePlayerGenerate { get; set; } = string.Empty;
        public string armsPlayerGenerate { get; set; } = string.Empty;

        internal HeroesService AddHeroes()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var nameSize = new char[random.Next(3,9)];
            string[] classePlayer = { "Warrior", "Mage", "Thief" };
            string[] armsPlayer = { "Sword", "Scèptre", "Dagger" };
            int classePlayerGenerateNumber = random.Next(classePlayer.Length);
            string armsPlayerGenerate = "";

            for (int i = 0; i < nameSize.Length; i++)
            {
                nameSize[i] = characters[random.Next(characters.Length)];
            }

            string namePlayerGenerate = new string(nameSize);
            long forcePlayer = random.Next(1, 101);
            long sagessePlayer = random.Next(101);
            long vitalityPlayer = random.Next(101);
            string classePlayerGenerate = classePlayer[classePlayerGenerateNumber];
            if (classePlayerGenerate == classePlayer[0])
            {
                armsPlayerGenerate = armsPlayer[0];
            }
            if (classePlayerGenerate == classePlayer[1])
            {
                armsPlayerGenerate = armsPlayer[1];
            }
            if (classePlayerGenerate == classePlayer[2])
            {
                armsPlayerGenerate = armsPlayer[2];
            }


            HeroesService heroes = new HeroesService(namePlayerGenerate, forcePlayer, sagessePlayer, vitalityPlayer, classePlayerGenerate, armsPlayerGenerate);
            return heroes;
        }
    }
}