using System;
using System.Collections.Generic;
using System.Text;

namespace Sahlgrenska.app.classes
{
    public class Hospital
    {
        public List<Room> Rooms = new List<Room>() { new Room("101"), new Room("102"), new Room("103"), new Room("104"), new Room("105") };
        public List<Patient> Patients = new List<Patient>()
        {
            new Patient(1, 123, "Bob",  "Marley"),
            new Patient(2, 124, "Ella",  "Fidjerald"),
            new Patient(3, 125, "Joe",  "Cocke"),
            new Patient(4, 126, "Lui",  "Amstrong"),
            new Patient(5, 127, "Jenis",  "Joplin")
        };
        public List<Equipment> Equipments = new List<Equipment> { new Equipment("MRI"), new Equipment("Ultrljud"), new Equipment("Röntgen") };
        public List<Medicin> Medicins = new List<Medicin> { new Medicin("Alvedon1"), new Medicin("Alvedon2"), new Medicin("Alvedon3"), new Medicin("Morfin1"), new Medicin("Morfin2") };
        public List<Booking> Bookings = new List<Booking>() { };
        public List<OrderEquipment> EquipmentOrders = new List<OrderEquipment>() {};
        public List<OrderMedicin> MedicinOrders = new List<OrderMedicin>() { };



        public Booking BookRoom(DateTime dateStart, Room room, string purpose, Patient patient, Equipment equipment, Medicin medicin)
        {
            var booking = new Booking();
            booking.DateStart = dateStart;
            booking.Room = room;
            booking.Purpose = purpose;
            booking.Author = null;
            booking.Patient = patient;
            booking.Equipment = equipment;
            booking.Medicin = medicin;

            Bookings.Add(booking);
            return booking;
        }

        public OrderEquipment CreateOrderE(Equipment equipment, Room room, int amount, DateTime availableDate)
        {
            var order = new OrderEquipment();
            order.Equipment = equipment;
            order.Room = room;
            order.Amount = amount;
            order.Author = null;
            order.AvailableDate = availableDate;

            EquipmentOrders.Add(order);
            return order;

        }

        public OrderMedicin CreateOrderM(Medicin medicin, int amountM, DateTime availableDateM)
        {
            var orderM = new OrderMedicin();
            orderM.Medicin = medicin;
            orderM.Amount = amountM;
            orderM.Author = null;
            orderM.AvailableDate = availableDateM;

            MedicinOrders.Add(orderM);
            return orderM;

        }

        //En dictionary för sjukdom och conditions. {Symptom, sjukdom} skriver på engelska för enkelhetens skull.
        public Dictionary<string, string> conditions = new Dictionary<string, string>()
        { 
        {"Wheezing","Asthma "},{"Fever","Influenza"},{"Memory loss","Alzheimers"},
        {"Arrhythmia","Heart attack"},{"Rash","Chicken Pox"},{"Coughing","Common Cold"},{"Lethargy","Viral Meningitis"}
           /* public string Diagnostic()
            {
                string search = Console.ReadLine();
                string keyreturn ="default";
                bool hasValue = conditions.TryGetValue(search, out keyreturn);
            
            }*/
        };

    }
}
