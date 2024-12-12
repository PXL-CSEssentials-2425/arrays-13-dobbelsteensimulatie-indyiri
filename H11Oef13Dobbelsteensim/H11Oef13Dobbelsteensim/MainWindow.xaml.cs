using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H11Oef13Dobbelsteensim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int[,] playerThorws = new int[1, 3];

        private void throwButton_Click(object sender, RoutedEventArgs e)
        {
            firstThrowTextBox.Clear();
            secondThrowTextBox.Clear();
            totalThrowTextBox.Clear();

            playerThorws[0, 0] = random.Next(1, 7);
            playerThorws[0, 1] = random.Next(1, 7);

            playerThorws[0, 2] = playerThorws[0, 0] + playerThorws[0, 1];

            firstThrowTextBox.Text = playerThorws[0, 0].ToString();
            secondThrowTextBox.Text = playerThorws[0, 1].ToString();
            totalThrowTextBox.Text = playerThorws[0, 2].ToString();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        int totalOf2 = 0;
        int totalOf3 = 0;
        int totalOf4 = 0;
        int totalOf5 = 0;
        int totalOf6 = 0;
        int totalOf7 = 0;
        int totalOf8 = 0;
        int totalOf9 = 0;
        int totalOf10 = 0;
        int totalOf11 = 0;
        int totalOf12 = 0;
        int totalThrows = 0;

        int[,] computerThrows = new int[1000,3];

        private void computerButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                computerThrows[i, 0] = random.Next(1, 7);
                computerThrows[i, 1] = random.Next(1, 7);
                computerThrows[i, 2] = computerThrows[i, 0] + computerThrows[i, 1];

                switch (computerThrows[i, 2])
                {
                    case 2:
                        totalOf2++;
                        total2TextBox.Text = totalOf2.ToString();
                        break;
                    case 3:
                        totalOf3++;
                        total3TextBox.Text = totalOf3.ToString();
                        break;
                    case 4:
                        totalOf4++;
                        total4TextBox.Text = totalOf4.ToString();
                        break;
                    case 5:
                        totalOf5++;
                        total5TextBox.Text = totalOf5.ToString();
                        break;
                    case 6:
                        totalOf6++;
                        total6TextBox.Text = totalOf6.ToString();
                        break;
                    case 7:
                        totalOf7++;
                        total7TextBox.Text = totalOf7.ToString();
                        break;
                    case 8:
                        totalOf8++;
                        total8TextBox.Text = totalOf8.ToString();
                        break;
                    case 9:
                        totalOf9++;
                        total9TextBox.Text = totalOf9.ToString();
                        break;
                    case 10:
                        totalOf10++;
                        total10TextBox.Text = totalOf10.ToString();
                        break;
                    case 11:
                        totalOf11++;
                        total11TextBox.Text = totalOf11.ToString();
                        break;
                    case 12:
                        totalOf12++;
                        total12TextBox.Text = totalOf12.ToString();
                        break;
                }
            }
            
            totalThrows = totalOf2 + totalOf3 + totalOf4 + totalOf5 + totalOf6 + totalOf7 + totalOf8 + totalOf9 + totalOf10 + totalOf11 + totalOf12;
            totalTextBox.Text = totalThrows.ToString();
        }
    }
}