using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.oop
{
    internal class hasta
    {
        public int HastaId { get; set; }
        public string Isim { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public List<randevu> Randevular { get; set; } = new List<randevu>();
        public List<recete> Receteler { get; set; } = new List<recete>();




    }
}
