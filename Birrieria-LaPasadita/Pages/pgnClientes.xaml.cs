using Birrieria_LaPasadita.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        }

        private void btnRegEmpleados_Click(object sender, RoutedEventArgs e)
        {
            grid_1.Visibility = Visibility.Collapsed;
            Main.Content = new pgnRegistro_Clientes();
        }

        private void btnEliminarEmpleado_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
