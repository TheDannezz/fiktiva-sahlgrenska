using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Sahlgrenska.app.classes;

namespace Sahlgrenska.app
{
    /// <summary>
    /// Interaction logic for OrderEquipmentWindow.xaml
    /// </summary>
    public partial class OrderEquipmentWindow : Window
    {
        private Hospital hospital;
        public OrderEquipmentWindow(Hospital hospitalS)
        {
            InitializeComponent();
            EquipmentComboBox.ItemsSource = hospitalS.Equipments;
            RoomComboBox.ItemsSource = hospitalS.Rooms;
            hospital = hospitalS;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Equipment selectedEquipment = (Equipment)EquipmentComboBox.SelectedItem;
            Room selectedRoom = (Room)RoomComboBox.SelectedItem;
            int selectedAmount = int.Parse(Amount.Text);
            var selectedDate = Date.SelectedDate;

            if (selectedDate == null) return;
            hospital.CreateOrderE(selectedEquipment, selectedRoom, selectedAmount, (DateTime)selectedDate );

            Close();

        }

    }
}
