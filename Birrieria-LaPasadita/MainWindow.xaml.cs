using Birrieria_LaPasadita.Formularios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Birrieria_LaPasadita
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("DATA SOURCE=COMPUA\\SQLEXPRESS; INITIAL CATALOG=BIRRIERIA; INTEGRATED SECURITY=TRUE");
        private void btninicio_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            string consulta = "select * from USUARIO where usu_contrasena= '" + txtcontraseña.Text + "' and usu_nombre='" + txtusuario.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, con);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                frmbase frmbase = new frmbase();
                frmbase.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
            con.Close();
        }
    }
}
