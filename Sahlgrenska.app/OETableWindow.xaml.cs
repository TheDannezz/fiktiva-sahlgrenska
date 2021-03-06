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
    /// Interaction logic for OETableWindow.xaml
    /// </summary>
    public partial class OETableWindow : Window
    {
        public OETableWindow(Hospital hospital)
        {
            InitializeComponent();
            OETable.ItemsSource = hospital.EquipmentOrders;
        }
    }
}
