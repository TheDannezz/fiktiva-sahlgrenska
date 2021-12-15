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
    /// Interaction logic for OrderMwedicinWindow.xaml
    /// </summary>
    public partial class OrderMedicinWindow : Window
    {
        private Hospital hospital;
        public OrderMedicinWindow(Hospital hospitalS)
        {
            InitializeComponent();
            MedicinComboBox.ItemsSource = hospitalS.Medicins;
            hospital = hospitalS;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Medicin selectedMedicin = (Medicin)MedicinComboBox.SelectedItem;
            int selectedAmount = int.Parse(Amount.Text);
            var selectedDate = Date.SelectedDate;

            if (selectedDate == null) return;
            hospital.CreateOrderM(selectedMedicin, selectedAmount, (DateTime)selectedDate);

            Close();
        }
    }
}
