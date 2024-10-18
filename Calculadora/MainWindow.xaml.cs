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
        
        static float num1;
        static float num2;
        static Boolean dobleNumero = false;
        static float resultado;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            // NÚMEROS --------------------------------------------------
            // Numero 0
            if (sender.Equals(btn_0))
            {
                //if (num1.ToString().Length < 9)
                if (txt_Pantalla.Text.Length < 9)                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 0);
                    //num1 = (num1 * 10) + 0;
                    //txt_Pantalla.Text = num1.ToString();

                }
            }
            // Numero 1
            if (sender.Equals(btn_1))
            {
                //if (num1.ToString().Length < 9)
                if(txt_Pantalla.Text.Length < 9)
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 1);
                    //num1 = (num1 * 10) + 1;
                    //txt_Pantalla.Text = num1.ToString();
                }       
            }
            // Numero 2
            if (sender.Equals(btn_2))
            {
                //if (num1.ToString().Length < 9)
                if (txt_Pantalla.Text.Length < 9)
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 2);
                    //num1 = (num1 * 10) + 2;
                    //txt_Pantalla.Text = num1.ToString();
                }          
            }
            // Numero 3
            if (sender.Equals(btn_3))
            {
                //if (num1.ToString().Length < 9)
                if(txt_Pantalla.Text.Length < 9)
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 3);
                    //num1 = (num1 * 10) + 3;
                    //txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 4
            if (sender.Equals(btn_4))
            {
                //if (num1.ToString().Length < 9)
                if(txt_Pantalla.Text.Length < 9 )
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 4);
                    //num1 = (num1 * 10) + 4;
                    //txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 5
            if (sender.Equals(btn_5))
            {
                //if (num1.ToString().Length < 9)
                if(txt_Pantalla.Text.Length < 9)
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 5);
                    //num1 = (num1 * 10) + 5;
                    //txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 6
            if (sender.Equals(btn_6))
            {
                //if (num1.ToString().Length < 9)
                if(txt_Pantalla.Text.Length < 9)
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 6);
                    //num1 = (num1 * 10) + 6;
                    //txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 7
            if (sender.Equals(btn_7))
            {
                //if (num1.ToString().Length < 9)
                if(txt_Pantalla.Text.Length < 9)
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 7);
                    //num1 = (num1 * 10) + 7;
                    //txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 8
            if (sender.Equals(btn_8))
            {
                //if (num1.ToString().Length < 9)
                if(txt_Pantalla.Text.Length < 9)
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 8);
;                    //num1 = (num1 * 10) + 8;
                    //txt_Pantalla.Text = num1.ToString();
                }
            }
            // Numero 8
            if (sender.Equals(btn_9))
            {
                //if (num1.ToString().Length < 9)
                if(txt_Pantalla.Text.Length < 9)
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 9);
                    //num1 = (num1 * 10) + 9;
                    //txt_Pantalla.Text = num1.ToString();
                }
            }
            // FUNCIONES --------------------------------------------------
            // Cambiar signo
            if (sender.Equals(btn_masMenos))
            {
                float temporal = float.Parse(txt_Pantalla.Text);
                temporal = temporal * -1;
                txt_Pantalla.Text = temporal.ToString();
            }
            // Coma
            if (sender.Equals(btn_coma))
            {
                txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, ",");
            }
            // Borrar todo
            if (sender.Equals(btn_C))
            {
                num1 = 0;
                num2 = 0;
                txt_Pantalla.Text = "";
            }
            if (sender.Equals(btn_x))
            {
                float temporal = float.Parse(txt_Pantalla.Text);
                temporal = (float)Math.Pow(temporal, 4);
                txt_Pantalla.Text = temporal.ToString();
            }
            // OPERACIONES --------------------------------------------------
            if (sender.Equals(btn_sumar))
            {
                
            }
        }
    }
}