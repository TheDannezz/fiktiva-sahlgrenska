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
    /// Interaction logic for BookingTableWindow.xaml
    /// </summary>
    public partial class BookingTableWindow : Window
    {
        public BookingTableWindow(Hospital hospital)
        {
            InitializeComponent();
            BookingTable.ItemsSource = hospital.Bookings;
        }
    }
}
