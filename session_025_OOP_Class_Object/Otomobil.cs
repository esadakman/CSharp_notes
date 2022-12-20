using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Object
{
    internal class Otomobil
    {
        public string renk;
        public string cant;
        private string model = "Audi";
        private int genislik = 2;
        private int uzunluk = 4;


        public string getModel () { 
            return model; 
        }

        public int getGenislik()
        {
            return genislik;
        }

    }
}
