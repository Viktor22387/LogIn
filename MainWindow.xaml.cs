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

namespace LogIn
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать не менее 6 символов.");
                return;
            }

            if (!ContainsLetters(password))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну букву.");
                return;
            }

            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Аутентификация успешна!");
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль!");
            }
        }

        private bool ContainsLetters(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
