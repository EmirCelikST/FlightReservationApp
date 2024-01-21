using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationAppEmirCelik
{
    public class Lokasyon
    {


        public int id { get; set; }
        public string sehir { get; set; }
        public string ulke { get; set; }
        public string havaalani { get; set; }
        public bool aktifPasif { get; set; }
        public int seyehatSuresi { get; set; }


    }
}
