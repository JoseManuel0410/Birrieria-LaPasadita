using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Birrieria_LaPasadita.Pages;

namespace Birrieria_LaPasadita.Formularios
{
    /// <summary>
    /// Lógica de interacción para frmbase.xaml
    /// </summary>
    public partial class frmbase : Window
    {
        public frmbase()
        {
            InitializeComponent();
        }

        private void btnordenes_Click(object sender, RoutedEventArgs e)
        {
            btnempleados.IsEnabled = true;
            btnventas.IsEnabled = true;
            btnclientes.IsEnabled = true;
            Main.Content = new pgnOrdenes();
            btnordenes.IsEnabled = false;
        }

        private void btnempleados_Click(object sender, RoutedEventArgs e)
        {
            btnordenes.IsEnabled = true;
            btnventas.IsEnabled = true;
            btnclientes.IsEnabled = true;
            Main.Content = new pgnEmpleados();
            btnempleados.IsEnabled = false;
        }

        private void btnventas_Click(object sender, RoutedEventArgs e)
        {
            btnordenes.IsEnabled = true;
            btnempleados.IsEnabled = true;
            btnclientes.IsEnabled = true;
            Main.Content = new pgnVentas();
            btnventas.IsEnabled = false;
        }

        private void btnclientes_Click(object sender, RoutedEventArgs e)
        {
            btnordenes.IsEnabled = true;
            btnempleados.IsEnabled = true;
            btnventas.IsEnabled = true;
            Main.Content = new pgnClientes();
            btnclientes.IsEnabled = false;
        }
    }
}
