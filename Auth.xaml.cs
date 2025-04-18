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
using System.Windows.Shapes;

namespace Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        pharmacyEntities db = new pharmacyEntities();
        public static Users CurrentUser { get; set; }
        public Auth()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Проверяем, что поля логина и пароля не пустые
                if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text))
                {
                    MessageBox.Show("Поля Логин и Пароль обязательны для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Поиск пользователя по логину
                var user = db.Users.FirstOrDefault(x => x.login == TextBox1.Text);

                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Проверка на правильность пароля
                if (TextBox2.Text != user.password)
                {
                    MessageBox.Show("Неверный логин или пароль. Попробуйте снова.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

               
                MessageBox.Show($"Добро пожаловать, {user.firstName} {user.patronymic}. Вы успешно авторизовались.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                
                order orderWindow = new order();
                orderWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
