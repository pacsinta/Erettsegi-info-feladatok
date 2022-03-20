using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ne foglalkozz ezzel

            Random random = new Random();

            int[] tomb = new int[10];
            for(int i = 0; i < tomb.Length; i=i+2)
            {
                tomb[i] = random.Next(-20, 41);
                tomb[i + 1] = tomb[i];
            }

            tomb = tomb.OrderBy(x => random.Next()).ToArray();

            Seged seged = new Seged();

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine();
            Console.WriteLine();


            //  1. feladat
            //  Válaszd ki a minimumot a tomb értékei közül





            //Ellenőrzés
            Console.WriteLine(tomb.Min());


            //  2. feladat
            //  Válaszd ki a maximumot





            //Ellenőrzés
            Console.WriteLine(tomb.Max());



            //  3. feladat
            //  Add meg a minimumot és annak az első előfordulásának az indexét





            //Ellenőrzés
            Console.WriteLine(tomb.Min());
            Console.WriteLine(seged.getFirstIndex(tomb));


            //  4. feladat
            //  Add meg a maximumot és annak az utolsó előfordulásának az indexét




            //Ellenőrzés
            Console.WriteLine(tomb.Max());
            Console.WriteLine(seged.getLastIndex(tomb));





            //Fontos! a végére kell egy ilyen
            Console.ReadKey();

        }
    }
}
