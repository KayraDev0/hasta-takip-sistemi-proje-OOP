using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.oop
{
    internal class recete
    {
        public int ReceteId { get; set; }
        public hasta Hasta { get; set; }
        public doktor Doktor { get; set; }
        public List<string> IlacListesi { get; set; } = new List<string>();
        public DateTime Tarih { get; set; } 


    }
}
