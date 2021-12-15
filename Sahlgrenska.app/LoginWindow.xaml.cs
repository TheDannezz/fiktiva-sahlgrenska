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

namespace Sahlgrenska.app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        string username = "oopa21";
        string password = "1234";
        
        public LoginWindow()
        {
            InitializeComponent();
        }
        //Checkbox not implemented yet.
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if ((usernamebox1.Text == username) && (passwordbox1.Text == password))
            {
                errormessage.Text ="Login Success";
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                LoginWindow loginWindow = new LoginWindow();
                this.Close();
            }
            else if (usernamebox1.Text.Length == 0 || passwordbox1.Text.Length == 0)
            {
                errormessage.Text = "Enter valid credentials";
                usernamebox1.Focus();
            }
        }
    }
}
