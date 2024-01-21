using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationAppEmirCelik
{
    public class Ucus
    {


        public int id { get; set; }
        public Lokasyon Lokasyon { get; set; }
        public Ucak Ucak { get; set; }
        public string saat { get; set; }
        public DateTime tarih { get; set; }




    }
}
