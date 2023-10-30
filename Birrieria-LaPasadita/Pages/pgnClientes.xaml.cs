using Birrieria_LaPasadita.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para pgnClientes.xaml
    /// </summary>
    public partial class pgnClientes : Page
    {
        public pgnClientes()
        {
            InitializeComponent();
            ObservableCollection<clsCliente> lista = new ObservableCollection<clsCliente>(GetDataBase.ObtenerCliente(clsconexion.Conectar()));
            dtgValores.ItemsSource = lista;
        }

        private void dtgValores_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headerName = e.PropertyName;
            switch (headerName)
            {
                case "cli_id":
                    e.Column.Header = "Código";
                    break;
                case "cli_nombre":
                    e.Column.Header = "Nombre";
                    break;
                case "cli_apellidop":
                    e.Column.Header = "Apellido Paterno";
                    break;
                case "cli_apellidom":
                    e.Column.Header = "Apellido Materno";
                    break;
                case "cli_telefono":
                    e.Column.Header = "Teléfono";
                    break;
                case "cli_domicilio":
                    e.Column.Header = "Dirección";
                    break;
                default:
                    break;
            }
        }

        private void btnRegCliente_Click(object sender, RoutedEventArgs e)
        {
            grid_1.Visibility = Visibility.Collapsed;
            Main.Content = new pgnRegistro_Clientes();
        }

        private void btnEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCliente.Text))
            {
                MessageBox.Show("Para poder eliminar este empleado debes ingresar el codigo", "Registrar", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Esta seguro que desea eliminar este empleado", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        SqlConnection con = new SqlConnection(clsconexion.Conectar());
                        SqlCommand cmd = new SqlCommand("", con);

                        con.Open();
                        cmd.CommandText = "DELETE FROM CLIENTE WHERE cli_id = '" + txtCodCliente.Text + "'";
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Empleado eliminado", "Eliminar", MessageBoxButton.OK, MessageBoxImage.Information);

                        break;
                }
            }
        }

        private void btnModificarCliente_Click(object sender, RoutedEventArgs e)
        {
            grid_1.Visibility = Visibility.Collapsed;
            Main.Content = new pgnModificar_Clientes();
        }
    }
}
