using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
    class ClassTaxi
    {
        public string DriveName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        // method
        public void TaxiInfo()
        {
            Console.WriteLine("TaxiInfo: {0}", DriveName);
            Console.WriteLine("PickUpPassenger: {0}", OnDuty);
            Console.WriteLine("DropOffPassenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} Sedang menjemput penumpang", DriveName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriveName);
        }
    }
}
