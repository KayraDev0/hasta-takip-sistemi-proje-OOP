using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.oop
{
    internal class doktor
    {
        public int DoktorId { get; set; }
        public string Isim { get; set; }
        public string Uzmanlik { get; set; }
        public List<randevu> Randevular { get; set; } = new List<randevu>();
    }
}
