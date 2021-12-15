using System;
using System.Collections.Generic;
using System.Text;

namespace Sahlgrenska.app.classes
{
    public class OrderMedicin
    {
        public Medicin Medicin { get; set; }
        public int Amount { get; set; }
        public DateTime AvailableDate { get; set; }
        public Employee Author { get; set; }
    }
}
