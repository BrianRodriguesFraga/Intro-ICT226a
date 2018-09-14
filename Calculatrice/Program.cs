using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        #region variables
        private static char ope;
        private static double op1;
        private static double op2;
        private static double resultat;
        #endregion variables

        static void Main(string[] args)
        {
            #region nombre1
            Console.Write("Entrée le premier nombre : ");
            bool reussi1 = double.TryParse(Console.ReadLine(), out op1);
            if (!reussi1)
            {
                do
                {
                    Console.Write("Le nombre entré est incorrect, réessayer : ");
                    reussi1 = double.TryParse(Console.ReadLine(), out op1);
                } while (!reussi1);
            }
            #endregion nombre1

            Console.Write("\nEntrée l'opérateur : ");
            ope = (char)Console.ReadKey().KeyChar;
            Console.ReadLine();

            #region nombre2
            Console.Write("\nEntrée le deuxième nombre : ");
            bool reussi2 = double.TryParse(Console.ReadLine(), out op2);
            if (!reussi2)
            {
                do
                {
                    Console.Write("Le nombre entré est incorrect, réessayer : ");
                    reussi2 = double.TryParse(Console.ReadLine(), out op2);
                } while (!reussi2);
            }
            #endregion nombre2

            #region operateur
            if (ope == '+')
            {
                resultat = addi(op1, op2);
            }
            else if (ope == '-')
            {
                resultat = sous(op1, op2);
            }
            else if (ope == '*')
            {
                resultat = mult(op1, op2);
            }
            else if (ope == '/')
            {
                resultat = divi(op1, op2);
            }
            else
            {
                Console.Write("\n\n  L'opérateur entrée est incorrect ! -> " + ope + "\n");
                resultat = 0;
                Console.ReadLine();
                return;
            }
            #endregion operateur

            Console.Write("\n\nLe résultat est : " + resultat);
            Console.ReadLine();
        }
        #region calcul
        private static double addi(double re1, double re2)
        {
            return re1 + re2;
        }

        private static double sous(double re1, double re2)
        {
            return re1 - re2;
        }

        private static double mult(double re1, double re2)
        {
            return re1 * re2;
        }

        private static double divi(double re1, double re2)
        {
            return re1 / re2;
        }
        #endregion calcul
    }
}

