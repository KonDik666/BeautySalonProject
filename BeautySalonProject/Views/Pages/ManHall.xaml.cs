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
    /// Логика взаимодействия для ManHall.xaml
    /// </summary>
    public partial class ManHall : Page
    {
        public ManHall(ServiceCategoryes activeCategory)
        {
            InitializeComponent();
            ServicesListView.ItemsSource = ServiceController.GetServicesCategories(activeCategory.CategoryId);
            TitleTextBlock.Text = activeCategory.CategoryTitle;
           
        }
    }
}
