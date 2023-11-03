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
    /// Lógica de interacción para pgnModificar_Empleados.xaml
    /// </summary>
    public partial class pgnModificar_Empleados : Page
    {
        public pgnModificar_Empleados()
        {
            InitializeComponent();
        }

        private void btnModEmpleados_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text == "" || txtNombre.Text == "" || txtApellidoPat.Text == "" || txtApellidoMat.Text == "" || txtApellidoMat.Text == "" || txtTelefono.Text == "" || txtSueldo.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Para poder modificar este empleado debes ingresar todos los datos", "Modificar", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(clsconexion.Conectar());
                SqlCommand cmd = new SqlCommand("", con);

                con.Open();
                cmd.CommandText = "UPDATE EMPLEADO SET emp_nombre = '" + txtNombre.Text + "', emp_apellidop = '" + txtApellidoPat.Text + "', emp_apellidom = '" + txtApellidoMat.Text + "', emp_telefono = '" + txtTelefono.Text + "', emp_direccion = '" + txtDireccion.Text + "' WHERE emp_id = " + txtID.Text + "";
                cmd.ExecuteNonQuery();

                con.Close();
                txtID.Clear();
                txtNombre.Clear();
                txtApellidoPat.Clear();
                txtApellidoMat.Clear();
                txtTelefono.Clear();
                txtSueldo.Clear();
                txtDireccion.Clear();
                MessageBox.Show("Empleado modificado");
            }
        }


        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grid2.Visibility = Visibility.Collapsed;
            Maint.Content = new pgnEmpleados();
        }
    }
}
