using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCourseCSharp
{
    internal class Program
    {
        string[] tabJoueurs;
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
                Console.WriteLine("*              Choix 3 : Boxe                                  *");
                Console.WriteLine("*              Choix 4 : Tableaux des scores                   *");
                Console.WriteLine("*              Choix 5 : Quitter l'application                 *");
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
                            Boxe();
                            break;

                        case 4:
                            TableauScrore();
                            break;

                        default:
                            terminado = 1;
                        Console.WriteLine("Merci d'avoir jouer et à bientot !");
                        Console.ReadLine();
                            break;
                }
            }
        }

        private static void TableauScrore()
        {
            Console.WriteLine("pauvre");
        }

        private static void Boxe()
        {
            Console.WriteLine("riche");
        }

        private static void PierreFeuilleCiseau()
        {
            Console.WriteLine("test");
        }

        private static void justePrix()
        {
        }
    }
}
