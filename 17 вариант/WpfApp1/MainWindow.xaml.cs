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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            Player1.Name = null;
            Player1.Paper = false;
            Player1.Scissors = false;
            Player1.Stone = false;
            Player1.xod = false;

            Player2.Name = null;
            Player2.Paper = false;
            Player2.Scissors = false;
            Player2.Stone = false;
            Player2.xod = false;
            this.Visibility = Visibility.Collapsed;
            Window1 Win1 = new Window1();
            Win1.ShowDialog();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void winnertext(object sender, EventArgs e)
        {
            if (Player1.Paper)
            {
                if (Player2.Paper)
                {
                    LabelWinner.Content = "ничья между" + " " + $"{Player1.Name}" + " " + "и" + " " + $"{Player2.Name}";
                }

                if (Player2.Scissors)
                {
                    LabelWinner.Content = $"{Player2.Name} Выйграл";
                }

                if (Player2.Stone)
                {
                    LabelWinner.Content = $"{Player1.Name} Выйграл";
                }
            }

            if (Player1.Scissors)
            {
                if (Player2.Paper)
                {
                    LabelWinner.Content = $"{Player1.Name} Выйграл";
                }

                if (Player2.Scissors)
                {
                    LabelWinner.Content = "ничья между" + " " + $"{Player1.Name}" + " " + "и" + " " + $"{Player2.Name}";
                }

                if (Player2.Stone)
                {
                    LabelWinner.Content = $"{Player2.Name} Выйграл";
                }
            }

            if (Player1.Stone)
            {
                if (Player2.Paper)
                {
                    LabelWinner.Content = $"{Player2.Name} Выйграл";
                }

                if (Player2.Scissors)
                {
                    LabelWinner.Content = $"{Player1.Name} Выйграл";
                }

                if (Player2.Stone)
                {
                    LabelWinner.Content = "ничья между" + " " + $"{Player1.Name}" + " " + "и" + " " + $"{Player2.Name}";
                }
            }
        }
    }
}
