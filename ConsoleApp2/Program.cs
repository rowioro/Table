using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int liczba;
            //char znak;
            ////liczba = int.Parse(Console.ReadLine());
            //znak = char.Parse(Console.ReadLine());
            //switch(znak)
            //{
            //    case 'a': Console.WriteLine("A");
            //        break;
            //    case 'b': Console.WriteLine("B");
            //        break;
            //    case 'c': Console.WriteLine("C");
            //        break;
            //    default: Console.WriteLine("Inna wartosc.");
            //        break;
            //}
            int[] tablica = new int[4];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
