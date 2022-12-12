using ApplicationConsoleCSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ApplicationConsoleCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int terminado = 0;
            while (terminado == 0)
            {
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                        DASHBOARD                             *");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                          MENU                                *");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*              Choix 1 : Le juste prix                         *");
                Console.WriteLine("*              Choix 2 : Pierre/Feuille/Ciseau                 *");
                Console.WriteLine("*              Choix 3 : Mémoire                               *");
                Console.WriteLine("*              Choix 4 : Quitter l'application                 *");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("Quel est votre choix ?");
                int choix = (int.Parse(Console.ReadLine()));
                switch (choix)
                {
                    case 1:
                        justePrix();
                        break;

                    case 2:
                        PierreFeuilleCiseau();
                        break;

                    case 3:
                        Memoire();
                        break;

                    case 4:
                        terminado = 1;
                        Console.WriteLine("Merci d'avoir jouer et à bientot !");
                        Console.ReadLine();
                        break;

                    default:
                        terminado = 1;
                        Console.WriteLine("Merci d'avoir jouer et à bientot !");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void Memoire()
        {
            Console.WriteLine("Quel est le nom du joueur ?");
            string name = Console.ReadLine();
            var rand = new Random();

            int numberAleatoire = rand.Next(3);
            ArrayList tab1 = new ArrayList();
            Console.WriteLine("Bienvenue " + name + " ! ");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("*                       Mémoire                                                             *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("*                      Les règles                                                           *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("*Règle numéro 1 : Tu devras retenir la suite de nombre et la reproduire numbre après nombre *");
            Console.WriteLine("*Règle numéro 2 : Pas le droit à l'erreur                                                   *");
            Console.WriteLine("*                                                                                           *");
            Console.WriteLine("*Règle numéro 4 : Bon courage !                                                             *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("                                                                                             ");
            Console.WriteLine("                                                                                             ");


            Console.WriteLine("Vous avez 5 secondes pour mémoriser la suite : ");
        }

        private static void PierreFeuilleCiseau()
        {
            Console.WriteLine("Quel est le nom du joueur ?");
            string name = Console.ReadLine();
            var rand = new Random();
            int party = 0;
            int nbGameWin = 0;
            
            Console.WriteLine("Bienvenue " + name + " ! ");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*                 Pierre/Feuille/Ciseaux                                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*                      Les règles                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*Règle numéro 1 : Tu devras choisir entre la pierre, la feuille et le ciseau *");
            Console.WriteLine("*Règle numéro 2 : Il y aura 3 manches !                                      *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*Règle numéro 4 : Bon courage !                                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            while (party < 3)
            {
                int numberAleatoire = rand.Next(3);
                Console.WriteLine("Que choisis-tu ? ");
                Console.WriteLine(" 0 : Pierre ? ");
                Console.WriteLine(" 1 : Feuille ? ");
                Console.WriteLine(" 2 : Ciseau ? ");
                int choixNumber = (int.Parse(Console.ReadLine()));
                if (choixNumber == numberAleatoire)
                {
                    Console.WriteLine(" Egalité ! ");
                }
                if (choixNumber == 0 && numberAleatoire == 1)
                {
                    Console.WriteLine(" Perdu ! L'ordinateur a fait Feuille !");
                }
                if (choixNumber == 0 && numberAleatoire == 2)
                {
                    Console.WriteLine(" Gagné ! ");
                    nbGameWin++;
                }
                if (choixNumber == 1 && numberAleatoire == 0)
                {
                    Console.WriteLine(" Gagné ! ");
                    nbGameWin++;
                }
                if (choixNumber == 1 && numberAleatoire == 2)
                {
                    Console.WriteLine(" Perdu ! L'ordinateur a fait Ciseau !");
                }
                if (choixNumber == 2 && numberAleatoire == 1)
                {
                    Console.WriteLine(" Gagné ! ");
                    nbGameWin++;
                }
                if (choixNumber == 2 && numberAleatoire == 0)
                {
                    Console.WriteLine(" Perdu ! L'ordinateur a fait Pierre !");
                }
                party++;
            }
            Player player = new Player(name, nbGameWin, "PierreFeuilleCiseau");
        }

        private static void justePrix()
        {
            Console.WriteLine("Quel est le nom du joueur ?");
            string name = Console.ReadLine();
            var rand = new Random();
            int numberAleatoire = rand.Next(101);
            int terminado = 0;
            int tenta = 0;
            Console.WriteLine("Bienvenue " + name + " ! ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*                     Le juste prix                            *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*                      Les règles                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*Règle numéro 1 : Trouver le prix tu devras.                   *");
            Console.WriteLine("*Règle numéro 2 : Tu n'aura droit qu'à 10 essaies maximums.    *");
            Console.WriteLine("*Règle numéro 3 : Ton temps sera compté                        *");
            Console.WriteLine("*Règle numéro 4 : Bon courage !                                *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("                                                                ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("Le prix est compris entre 0€ et 100€, quel est son prix ? ");
            while (tenta < 11 && terminado == 0)
            {
                int choixNumber = (int.Parse(Console.ReadLine()));
                if (choixNumber == numberAleatoire)
                {
                    Console.WriteLine("Féléicitation, vous avez trouvé le prix en " + tenta + " tentatives !");
                    terminado = 1;
                    Console.ReadLine();
                }
                if (choixNumber < numberAleatoire)
                {
                    Console.WriteLine("C'est plus chère !");
                }
                if (choixNumber > numberAleatoire)
                {
                    Console.WriteLine("C'est moins chère !");
                }
                tenta++;
                Console.WriteLine(tenta);
            }
            if (tenta == 11)
            {
                Console.WriteLine("Perdu !");
                Console.ReadLine();
            }
            Player player = new Player(name, tenta, "JustePrix");

        }
    }
}
