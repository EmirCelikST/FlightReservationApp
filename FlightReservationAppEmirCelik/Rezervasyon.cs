using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationAppEmirCelik
{
    public class Rezervasyon
    {
        private static int sonId = 0;

        public int id { get; set; }
        public Ucus Ucus { get; set; }
        public string musteriAdiSoyadi { get; set; }
        public int biletAdeti { get; set; }
        public string koltukNo { get; set; }
        public double musteriCepTelefonu { get; set; }
        public int yas { get; set; }

        public Rezervasyon()
        {
            // Her bir örnek oluşturulduğunda yeni bir ID atanır
            id = ++sonId;
        }

    }
}
