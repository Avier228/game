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

namespace WpfApp1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            if (Player1.xod) LabelSelectItem.Content = "Выбирайте";

            else LabelSelectItem.Content = "Выбирайте";
        }
        private void Window_Closed(object sender, EventArgs e)
        {

            if (!Player2.xod)
            {

                Window1 Win0 = new Window1();
                Win0.ShowDialog();
            }
            else
            {

                MainWindow MainWin2 = new MainWindow();
                MainWin2.Visibility = Visibility.Visible;
            }
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            if (Player1.xod)
            {

                Player2.Stone = true;
                Player2.xod = true;
                Player2.Name = TextBoxNamePlayer.Text;
            }
            else
            {

                Player1.Stone = true;
                Player1.xod = true;
                Player1.Name = TextBoxNamePlayer.Text;
            }
            this.Close();
        }
        private void ButtonB_Click(object sender, RoutedEventArgs e)
        {
            if (Player1.xod)
            {

                Player2.Scissors = true;
                Player2.xod = true;
                Player2.Name = TextBoxNamePlayer.Text;
            }
            else
            {

                Player1.Scissors = true;
                Player1.xod = true;
                Player1.Name = TextBoxNamePlayer.Text;
            }
            this.Close();
        }
        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            if (Player1.xod)
            {

                Player2.Paper = true;
                Player2.xod = true;
                Player2.Name = TextBoxNamePlayer.Text;
            }
            else
            {

                Player1.Paper = true;
                Player1.xod = true;
                Player1.Name = TextBoxNamePlayer.Text;
            }
            this.Close();
        }

    }
}
