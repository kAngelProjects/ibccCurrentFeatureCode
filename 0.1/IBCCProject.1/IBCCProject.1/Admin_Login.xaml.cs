using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for Admin_Login.xaml
    /// </summary>
    public partial class Admin_Login : Window
    {
        private TextBox _currentTextbox;

        public Admin_Login()
        {
            InitializeComponent();
            _currentTextbox = passwordBox as TextBox;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            //get password value
            string passwordValue = passwordBox.Text;

            if (passwordValue == "l@ncasterBomber280217")
            {
                //password is correct, navigate to selection screen
                Admin_Menu adminMenuWindow = new Admin_Menu();
                adminMenuWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password. Access denied.");
                passwordBox.Text = ""; //reset password to blank
            }
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu newMenu = new Menu();
            newMenu.Show();
            this.Close();
        }

    }
}
