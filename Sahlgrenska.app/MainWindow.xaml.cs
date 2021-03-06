using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sahlgrenska.app.classes;



namespace Sahlgrenska.app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Hospital HospitalS;

        private void LoginButton()
        {

        }
        public MainWindow()
        {
            HospitalS = new Hospital();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var bookRoomWindow = new BookRoomWindow(HospitalS);
            bookRoomWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new BookingTableWindow(HospitalS).ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var orderEquipmentWindow = new OrderEquipmentWindow(HospitalS);
            orderEquipmentWindow.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new OETableWindow(HospitalS).ShowDialog();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var orderMedicinWindow = new OrderMedicinWindow(HospitalS);
            orderMedicinWindow.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            new OMTableWindow(HospitalS).ShowDialog();
        }
    }
}
