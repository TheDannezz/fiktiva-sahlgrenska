using System;
using System.Collections.Generic;
using System.Text;

namespace Sahlgrenska.app.classes
{
    public class OrderEquipment
    {
        public Equipment Equipment { get; set; }
        public Room Room { get; set; }
        public int Amount { get; set; }
        public DateTime AvailableDate { get; set; }
        public Employee Author { get; set; }

    }
}
