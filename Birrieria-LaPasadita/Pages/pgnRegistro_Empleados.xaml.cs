using Birrieria_LaPasadita.Clases;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
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
            LlenarComboBoxCargos();
        }
        private void btnRegEmpleados_Click(object sender, RoutedEventArgs e)
        {
            if (cbxCargo.SelectedItem is clsCargo cargoSeleccionado)
            {
                int cargoId = cargoSeleccionado.car_id; // Obtén el ID del cargo seleccionado.
                Guardar(cargoId); // Llama al método Guardar con el ID del cargo.
            }
            else
            {
                MessageBox.Show("Selecciona un cargo válido", "Registrar", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void Guardar(int cargoId)
        {
            if (txtNombre.Text == "" || txtApellidoPat.Text == "" || txtApellidoMat.Text == "" || txtTelefono.Text == "" || txtSueldo.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Para poder registrar este empleado debes ingresar todos los datos", "Registrar", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(clsconexion.Conectar());
                SqlCommand cmd = new SqlCommand("", con);

                con.Open();
                cmd.CommandText = "INSERT INTO EMPLEADO(emp_nombre, emp_apellidop, emp_apellidom, emp_telefono, emp_direccion, emp_cargo) " + "VALUES('" + txtNombre.Text + "','" + txtApellidoPat.Text + "','" + txtApellidoMat.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "','" + cargoId + "')";
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

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grid2.Visibility = Visibility.Collapsed;
            Maint.Content = new pgnEmpleados();
        }

<<<<<<< HEAD
        private void Maint_Navigated(object sender, NavigationEventArgs e)
        {

=======
        private List<clsCargo> ObtenerCargosDesdeBaseDeDatos()
        {
            List<clsCargo> cargos = new List<clsCargo>();

            using (SqlConnection con = new SqlConnection(clsconexion.Conectar()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT car_id, car_nombre FROM CARGO", con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        cargos.Add(new clsCargo { car_id = id, car_nombre = nombre });
                    }
                }
            }

            return cargos;
        }
        private void LlenarComboBoxCargos()
        {
            List<clsCargo> cargos = ObtenerCargosDesdeBaseDeDatos();
            cbxCargo.ItemsSource = cargos;
            cbxCargo.DisplayMemberPath = "car_nombre";
>>>>>>> 286e0a2e97aa8218f21cfb1aa04cb71d2dc9dbb7
        }
    }
}
