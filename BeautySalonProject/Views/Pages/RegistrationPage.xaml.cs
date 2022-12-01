using BeautySalonProject.Controllers;
using BeautySalonProject.Models;
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

namespace BeautySalonProject.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Users newUser = new Users
            {
                idRole = 2,
                userName = NameTextBox.Text,
                userLastName = LastNameTextBox.Text,
                userOtherName = LastNameTextBox.Text,
                userLogin = LoginTextBox.Text,
                userPassword = PasswordPasswordBox.Password
            };
            if(NameTextBox.Text=="" || LastNameTextBox.Text=="" || LastNameTextBox.Text=="" || LoginTextBox.Text=="" || PasswordPasswordBox.Password == "")
            {
                MessageBox.Show("заполните все поля");
            }
            else
            {
                if (UsersController.AddUser(newUser))
                {
                    MessageBox.Show("запись добавлена");
                }
            }
           
        }
    }
}
