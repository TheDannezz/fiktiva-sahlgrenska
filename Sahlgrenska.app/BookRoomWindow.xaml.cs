using System;
using System.Windows;
using Sahlgrenska.app.classes;

namespace Sahlgrenska.app
{
    /// <summary>
    /// Interaction logic for BookRoomWindow.xaml
    /// </summary> 
    public partial class BookRoomWindow : Window
    {
        private Hospital hospital;
        public BookRoomWindow(Hospital hospitalS)
        {
            InitializeComponent();
        
            RoomComboBox.ItemsSource = hospitalS.Rooms;
            PatientsComboBox.ItemsSource = hospitalS.Patients;
            EquipmentsComboBox.ItemsSource = hospitalS.Equipments;
            MedicinsComboBox.ItemsSource = hospitalS.Medicins;
            hospital = hospitalS;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Room selectedRoom = (Room)RoomComboBox.SelectedItem;
            Patient selectedPatient = (Patient)PatientsComboBox.SelectedItem;
            Equipment selectedEquipment = (Equipment)EquipmentsComboBox.SelectedItem;
            Medicin selectedMedicin = (Medicin)MedicinsComboBox.SelectedItem;
            var selectedDate = Date.SelectedDate;
            string selectedPurpose = Purpose.Text;

            if (selectedDate == null) return;
            hospital.BookRoom((DateTime)selectedDate, selectedRoom, selectedPurpose, selectedPatient, selectedEquipment, selectedMedicin);

            Close();
        }
    }
}
