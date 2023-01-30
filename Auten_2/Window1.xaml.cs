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
using System.Windows.Threading;

namespace Auten_2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DispatcherTimer disTimer = new DispatcherTimer();
        public Window1()
        {
            InitializeComponent();
            disTimer.Interval = new TimeSpan(0, 0, 5);
            disTimer.Tick += new EventHandler(DisTimer_Tick);
            disTimer.Start();
            Time_Kode.Text = disTimer.ToString();
        }

        private void bb_Click(object sender, RoutedEventArgs e)
        {
            
            if(Kod.Text==MainWindow.kod) // Значение переменной kod из окна MainWindow
            {
                MessageBox.Show("Авторизация прошла \nуспешно");
            }
            else
            {
                MessageBox.Show("ОШИБКА!!!");
            }
        }

        private void DisTimer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Время вышло!");
            //MainWindow mainwindow = new MainWindow();
            //mainwindow.Show();

            //MessageBox.Show("ВРЕМЯ ВЫШЛО!");
            this.Close();
            
        }
    }
}
