using System;
using System.Collections.Generic;
using System.Text;

namespace Sahlgrenska.app.classes
{
    public class Hospital
    {
        public List<Room> Rooms = new List<Room>() { new Room("101"), new Room("102"), new Room("103"), new Room("104"), new Room("105") };
        public List<Patient> Patients = new List<Patient>() { new Patient("Bob Marley"), new Patient("Ella Fidjerald"), new Patient("Joe Cocke"), new Patient("Lui Amstrong"), new Patient("Jenis Joplin") };
        public List<Equipment> Equipments = new List<Equipment> { new Equipment("MRI"), new Equipment("Ultrljud"), new Equipment("Röntgen") };
        public List<Medicin> Medicins = new List<Medicin> { new Medicin("Alvedon1"), new Medicin("Alvedon2"), new Medicin("Alvedon3"), new Medicin("Morfin1"), new Medicin("Morfin2") };
        public List<Booking> Bookings = new List<Booking>() { };


        public Booking BookRoom(int room, string patient, string equipment, string medicine, DateTime date)
        {
            var booking = new Booking(111);


            Bookings.Add(booking);
            return booking;

        }



    }
}
