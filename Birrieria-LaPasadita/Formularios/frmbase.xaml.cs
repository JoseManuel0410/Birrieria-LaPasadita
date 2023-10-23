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
            Main.Content = new pgnOrdenes();
            btnordenes.IsEnabled = false;
        }

        private void btnempleados_Click(object sender, RoutedEventArgs e)
        {
            btnordenes.IsEnabled = true;
            Main.Content = new pgnEmpleados();
            btnempleados.IsEnabled = false;
        }

        private void btnventas_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmventas x = new Formularios.frmventas();
            x.Show();
            this.Close();
        }

        private void btnclientes_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmclientes x = new Formularios.frmclientes();
            x.Show();
            this.Close();
        }
    }
}
