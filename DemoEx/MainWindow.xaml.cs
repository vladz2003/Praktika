using System;
using System.Collections.Generic;
using System.Data;
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

namespace DemoEx
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // функция входа 
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Trade123Entities db = new Trade123Entities();

            foreach(User user1 in db.User)
            {
                if(user1.UserPassword==TextBox_Password.Text && user1.UserLogin == TextBox_Login.Text)
                {
                    MessageBox.Show("Авторизация прошла успешно!");
                    MainWindow1 wind = new MainWindow1(user1);
                    wind.Show();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Вы ввели неверный логин или пароль");
        }

        private void TextBox_TextChanged_1(object sender, object e)
        {

        }

        private void Button_Click(object sender, object e)
        {
           
        }

        private void Button_Guest_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.UserName = "Гость";
            MainWindow1 wind = new MainWindow1(user);
            wind.Show();
            this.Close();   
        }
    }
}
