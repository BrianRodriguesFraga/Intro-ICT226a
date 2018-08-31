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

            Console.Write("Entrée le premier nombre : \n");
            op1 = int.Parse(Console.ReadLine());

            Console.Write("\n\nEntrée l'opérateur : \n");
            ope = (char)Console.Read();

            Console.Write("\n\nEntrée le second nombre : \n");
            op2 = int.Parse(Console.ReadLine());

            resultat = op1 + ope + op2;

            Console.Write("\n\nLe résultat est : " + resultat);

            Console.ReadLine();
        }

        private static int addi(int re1, int re2)
        {
            return re1 + re2;
        }

        private static int sous(int re1, int re2)
        {
            return re1 - re2;
        }

        private static int mult(int re1, int re2)
        {
            return re1 * re2;
        }

        private static double divi(int re1, int re2)
        {
            
            return re1 / re2;
        }

    }
}

