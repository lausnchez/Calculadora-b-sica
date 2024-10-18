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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int num1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            // Numero 0
            if (sender.Equals(btn_0))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 0;
                    txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 1
            if (sender.Equals(btn_1))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 1;
                    txt_Pantalla.Text = num1.ToString();
                }       
            }
            // Numero 2
            if (sender.Equals(btn_2))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 2;
                    txt_Pantalla.Text = num1.ToString();
                }          
            }
            // Numero 3
            if (sender.Equals(btn_3))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 3;
                    txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 4
            if (sender.Equals(btn_4))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 4;
                    txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 5
            if (sender.Equals(btn_5))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 5;
                    txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 6
            if (sender.Equals(btn_6))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 6;
                    txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 7
            if (sender.Equals(btn_7))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 7;
                    txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 8
            if (sender.Equals(btn_8))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 8;
                    txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 8
            if (sender.Equals(btn_9))
            {
                if (num1.ToString().Length < 9)
                {
                    num1 = (num1 * 10) + 9;
                    txt_Pantalla.Text = num1.ToString();
                }
            }
        }
    }
}