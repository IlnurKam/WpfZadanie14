using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfZadanie14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Поршни",
                ProdPrice = 3900,
                ProdImage="Data/Поршни.jpg",
                ProductCategory = ProductCategorys.Motor
            });
            products.Add(new Product()
            {
                ProdName = "Клапана",
                ProdPrice = 3500,
                ProdImage = "Data/Клапана.jpg",
                ProductCategory = ProductCategorys.Motor
            });
            products.Add(new Product()
            {
                ProdName = "Свечи",
                ProdPrice = 1900,
                ProdImage = "Data/Свечи.jpg",
                ProductCategory = ProductCategorys.Motor
            });
            products.Add(new Product()
            {
                ProdName = "Бампер",
                ProdPrice = 3500,
                ProdImage = "Data/Бампер.jpg",
                ProductCategory = ProductCategorys.Body
            });
            products.Add(new Product()
            {
                ProdName = "Фары",
                ProdPrice = 2500,
                ProdImage = "Data/Фары.jpg",
                ProductCategory = ProductCategorys.Body
            });
            listBox.ItemsSource = products;
        }
    }
}
