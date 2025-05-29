using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.oop
{
    internal class randevu
    {
        public int RandevuId { get; set; }
        public hasta Hasta { get; set; }
        public doktor Doktor { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Durum { get; set; } = "Planlandı";

    }
}
