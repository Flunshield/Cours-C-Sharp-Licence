using APIWeb.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace APIWeb.Services
{
    public class EnemyService
    {
        public EnemyService() { }
        public EnemyService(string namePlayerGenerate, long forcePlayer, long sagessePlayer, long vitalityPlayer, string classePlayerGenerate, long armsPlayerGenerate)
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
        public long armsPlayerGenerate { get; set; }
        internal EnemyService AddEnemys()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var nameSize = new char[random.Next(3,9)];
            string[] classePlayer = { "Beserker", "Wizard", "Assassin" };
            int classePlayerGenerateNumber = random.Next(classePlayer.Length);
            long armsPlayerGenerate = 999;
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
                armsPlayerGenerate = 1;
            }
            if (classePlayerGenerate == classePlayer[1])
            {
                armsPlayerGenerate = 2;
            }
            if (classePlayerGenerate == classePlayer[2])
            {
                armsPlayerGenerate = 3;
            }
            EnemyService enemys = new EnemyService(namePlayerGenerate, forcePlayer, sagessePlayer, vitalityPlayer, classePlayerGenerate, armsPlayerGenerate);
            return enemys;
        }
    }
}