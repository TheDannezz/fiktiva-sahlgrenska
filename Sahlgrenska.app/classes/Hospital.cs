using System;
using System.Collections.Generic;
using System.Text;

namespace Sahlgrenska.app.classes
{
    class Hospital
    {
        public List<Room> Rooms = new List<Room>();
        public List<Patient> Patients = new List<Patient>();
        public List<Booking> Bookings = new List<Booking>();

        public Booking BookRoom(int room, string patient, string equipment, string medicine, DateTime date)
        {
            return null;

        }



    }
}
