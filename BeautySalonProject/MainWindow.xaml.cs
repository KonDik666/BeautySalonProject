using BeautySalonProject.Models;
using BeautySalonProject.Views.Pages;
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

namespace BeautySalonProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new StartPage());
            if (MainFrame.CanGoBack)
            {
                ErrorTextBlock.Text = "Статус: авторизован";
            }

        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StartPage());
            ErrorTextBlock.Text = "Статус: не авторизован";
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
                
            }
        }
        
    }
}
