using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        pharmacyEntities db = new pharmacyEntities();

        
        public MainWindow()
        {
            InitializeComponent();
            LoadMedicines();

        }

        private void LoadMedicines()
        {
            if (MedicinesGrid.ItemsSource != null)
            {
                return; // Если данные уже загружены, не загружаем их снова
            }

            var medicines = db.Medicines
                .Select(m => new
                {
                    m.name,
                    m.description,
                    m.manufacturer,
                    m.price,
                    m.unitOfMeasure,
                    m.stockQuantity,
                    m.discount
                })
                .ToList();

            MedicinesGrid.ItemsSource = medicines;
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CurrentUser == null)
            {
                MessageBox.Show("Для оформления заказа необходимо авторизоваться.", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            order orderWindow = new order();
            orderWindow.ShowDialog();
        }

        
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth();
            this.Close();
            auth.Show();
        }

    }
}
