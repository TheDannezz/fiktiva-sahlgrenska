using System;

namespace Sahlgrenska.app.classes
{
    public class Booking
    {
        public DateTime DateStart { get; set; }
        public Room Room { get; set; }
        public string Purpose { get; set; }
        public Employee Author { get; set; }
        public Patient Patient { get; set; }
        public Equipment Equipment { get; set; }
        public Medicin Medicin { get; set; }
        

    }
}