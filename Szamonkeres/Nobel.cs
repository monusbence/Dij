using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamonkeres
{
    class Nobel
    {
        int evszam;
        string típus, keresztnév, vezetéknév;

        public Nobel(int evszam, string típus, string keresztnév, string vezetéknév)
        {
            this.evszam = evszam;
            this.típus = típus;
            this.keresztnév = keresztnév;
            this.vezetéknév = vezetéknév;
        }

        public int Evszam { get => evszam; }
        public string Típus { get => típus; }
        public string Keresztnév { get => keresztnév; }
        public string Vezetéknév { get => vezetéknév; }
    }
}
