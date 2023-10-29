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
    /// Lógica de interacción para pgnRegistro_Empleados.xaml
    /// </summary>
    public partial class pgnRegistro_Empleados : Page
    {
        public pgnRegistro_Empleados()
        {
            InitializeComponent();
        }
        private void btnRegEmpleados_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            if ( txtNombre.Text == "" || txtApellidoPat.Text == "" || txtApellidoMat.Text == "" || txtApellidoMat.Text == "" || txtTelefono.Text == "" || txtSueldo.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Para poder registrar este empleado debes ingresar todos los datos", "Registrar", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(clsconexion.Conectar());
                SqlCommand cmd = new SqlCommand("", con);

                con.Open();
                cmd.CommandText = "INSERT INTO EMPLEADO(emp_nombre,emp_apellidop,emp_apellidom,emp_telefono,emp_direccion)VALUES('" + txtNombre.Text + "','" + txtApellidoPat.Text + "','" + txtApellidoMat.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "')";
                cmd.ExecuteNonQuery();

                con.Close();
                txtNombre.Clear();
                txtApellidoPat.Clear();
                txtApellidoMat.Clear();
                txtTelefono.Clear();
                txtSueldo.Clear();
                txtDireccion.Clear();
                MessageBox.Show("Empleado registrado");
            }
        }


    }
}
