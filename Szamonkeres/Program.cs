using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Szamonkeres
{
    class Program
    {
        //3as 5os feladat nem kell
        static void Main(string[] args)
        {
            string[] szoveg = File.ReadAllLines("C:\\Users\\tanulo\\Downloads\\nobel.csv");
            List<Nobel> lista = new List<Nobel>();

            foreach (var elem in szoveg.Skip(1))
            {
                string[] adatok = elem.Split(';'); 
                Nobel uj = new Nobel(Convert.ToInt32(adatok[0]), adatok[1], adatok[2], adatok[3]);
                lista.Add(uj);
            }

            Console.WriteLine($"4. feladat: {lista.First(x => x.Evszam == 2017 && x.Típus == "irodalmi")}");
            Console.WriteLine("6. feladat:");
            Console.WriteLine($"{lista.Where(x => x.Vezetéknév == "Curie"? Console.Write(x.Vezetéknév + x.Keresztnév))}");
            
            
            
            Console.WriteLine("7. feladat: ");
            Console.WriteLine($"{lista.GroupBy(x => x.Típus)}{lista.Count(x => x.Típus == "fizikai")}{lista.Count(x => x.Típus == "kémiai"}{lista.Count(x => x.Típus == "orvosi"});

            


        }
    }
}
