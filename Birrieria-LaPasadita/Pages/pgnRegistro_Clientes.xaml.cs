using Birrieria_LaPasadita.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Birrieria_LaPasadita.Pages
{
    /// <summary>
    /// Lógica de interacción para pgnRegistro_Clientes.xaml
    /// </summary>
    public partial class pgnRegistro_Clientes : Page
    {
        public pgnRegistro_Clientes()
        {
            InitializeComponent();
        }

        private void btnRegClientes_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (txtNombre.Text == "" || txtApellidoPat.Text == "" || txtApellidoMat.Text == ""  || txtTelefono.Text == ""  || txtDireccion.Text == "")
            {
                MessageBox.Show("Para poder registrar este cliente debes ingresar todos los datos", "Registrar", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(clsconexion.Conectar());
                SqlCommand cmd = new SqlCommand("", con);

                con.Open();
                cmd.CommandText = "INSERT INTO CLIENTE(cli_nombre,cli_apellidop,cli_apellidom,cli_telefono,cli_domicilio)VALUES('" + txtNombre.Text + "','" + txtApellidoPat.Text + "','" + txtApellidoMat.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "')";
                cmd.ExecuteNonQuery();

                con.Close();
                txtNombre.Clear();
                txtApellidoPat.Clear();
                txtApellidoMat.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                MessageBox.Show("Cliente registrado");
            }
        }
    }
}
