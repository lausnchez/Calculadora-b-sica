using System.Configuration;
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
        static float resultado;
        static string operacion;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            // NÚMEROS --------------------------------------------------
            if (txt_Pantalla.Text.Length < 10)
            {
                // Numero 0 -------------
                if (sender.Equals(btn_0))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 0);
                }
                // Numero 1 -------------
                if (sender.Equals(btn_1))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 1);
                }
                // Numero 2 -------------
                if (sender.Equals(btn_2))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 2);
                }
                // Numero 3 -------------
                if (sender.Equals(btn_3))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 3);
                }
                // Numero 4 -------------
                if (sender.Equals(btn_4))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 4);
                }
                // Numero 5 -------------
                if (sender.Equals(btn_5))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 5);
                }
                // Numero 6 -------------
                if (sender.Equals(btn_6))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 6);
                }
                // Numero 7 -------------
                if (sender.Equals(btn_7))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 7);
                }
                // Numero 8 -------------
                if (sender.Equals(btn_8))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 8);
                }
                // Numero 9 -------------
                if (sender.Equals(btn_9))
                {
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, 9);
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
                if (!txt_Pantalla.Text.Contains(",")){
                    txt_Pantalla.Text = String.Concat(txt_Pantalla.Text, ",");
                }
            }
            // Borrar todo
            if (sender.Equals(btn_C))
            {
                num1 = 0;
                resultado = 0;
                operacion = "";
                txt_Pantalla.Text = "";
            }
            if (sender.Equals(btn_x))   // Elevar a 4
            {
                float temporal = float.Parse(txt_Pantalla.Text);
                temporal = (float)Math.Pow(temporal, 4);
                txt_Pantalla.Text = temporal.ToString();
            }
            // OPERACIONES --------------------------------------------------
            if (sender.Equals(btn_sumar))   // SUMAR
            {
                operacion = "sumar";
                num1 = float.Parse(txt_Pantalla.Text);
                txt_Pantalla.Text = "";
            }
            if (sender.Equals(btn_restar))  // RESTAR
            {
                operacion = "restar";
                num1 = float.Parse(txt_Pantalla.Text);
                txt_Pantalla.Text = "";
            }
            if (sender.Equals(btn_multiplicar)) // MULTIPLICAR
            {
                operacion = "multiplicar";
                num1 = float.Parse(txt_Pantalla.Text);
                txt_Pantalla.Text = "";
            }
            if (sender.Equals(btn_dividir)) // DIVIDIR
            {
                operacion = "dividir";
                num1 = float.Parse(txt_Pantalla.Text);
                txt_Pantalla.Text = "";
            }
            if (sender.Equals(btn_porcentaje))
            {
                operacion = "resto";
                num1 = float.Parse (txt_Pantalla.Text);
                txt_Pantalla.Text = "";
            }
            if (sender.Equals(btn_resultado))
            {
                if (operacion.Equals("sumar"))
                {
                    resultado = num1 + float.Parse(txt_Pantalla.Text);
                    txt_Pantalla.Text = resultado.ToString();
                    num1 = 0;
                }
                if (operacion.Equals("restar"))
                {
                    resultado = num1 - float.Parse(txt_Pantalla.Text);
                    txt_Pantalla.Text = resultado.ToString();
                    num1 = 0;
                }
                if (operacion.Equals("multiplicar"))
                {
                    resultado = num1 * float.Parse(txt_Pantalla.Text);
                    txt_Pantalla.Text = resultado.ToString();
                    num1 = 0;
                }
                if (operacion.Equals("dividir"))
                {
                    resultado = num1 / float.Parse(txt_Pantalla.Text);
                    txt_Pantalla.Text = resultado.ToString();
                    num1 = 0;
                }
                if (operacion.Equals("resto"))
                {
                    resultado = num1 % float.Parse(txt_Pantalla.Text);
                    txt_Pantalla.Text = resultado.ToString();
                    num1 = 0;
                }
            }
        }
    }
}