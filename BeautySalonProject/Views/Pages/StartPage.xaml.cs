using BeautySalonProject.Controllers;
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
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void SignInbutton_Click(object sender, RoutedEventArgs e)
        {
            UsersController.GetUser(LoginTextBox.Text, PasswordPasswordBox.Password);
            if (LoginTextBox.Text == "" || PasswordPasswordBox.Password=="")
            {
                MessageBox.Show("Поле логина или пароля пусто");
            }
            UsersController obj = new UsersController();
            bool v = obj.Auth(LoginTextBox.Text, PasswordPasswordBox.Password);
            if (v == true)
            {
                this.NavigationService.Navigate(new RegistrationPage());
            }
            
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage());
        }
    }
}
