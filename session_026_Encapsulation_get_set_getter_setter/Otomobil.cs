using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Object
{
    internal class Otomobil
    {
        private string renk = "beyaz";
        private string cant = "Celik";
        private string model = "Audi";
        private int genislik = 2;
        private int uzunluk = 4;

        public string Renk { get => renk; set => renk = value; }
        public string Cant { get => cant; set => cant = value; }

        public string getModel () { 
            return model; 
        }

        public int getGenislik()
        {
            return genislik;
        }

        public int getUzunluk()
        {
            return this.uzunluk;
        }

    }
}
