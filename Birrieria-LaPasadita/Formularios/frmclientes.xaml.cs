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

namespace Birrieria_LaPasadita.Formularios
{
    /// <summary>
    /// Lógica de interacción para frmclientes.xaml
    /// </summary>
    public partial class frmclientes : Window
    {
        public frmclientes()
        {
            InitializeComponent();
        }
        private void btnordenes_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmordenes x = new Formularios.frmordenes();
            x.Show();
            this.Close();
        }

        private void btnempleados_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmempleados x = new Formularios.frmempleados();
            x.Show();
            this.Close();
        }
        private void btnventas_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmventas x = new Formularios.frmventas();
            x.Show();
            this.Close();
        }

        private void btnRegistroCliente_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmregistro_clientes x = new Formularios.frmregistro_clientes();
            x.Show();
            this.Close();
        }

        private void btnEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Esta seguro que desea eliminar este empleado", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Empleado eliminado", "Elimnar", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
        }

        private void btnModificarCliente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnventas_Click_1(object sender, RoutedEventArgs e)
        {
            Formularios.frmventas x = new Formularios.frmventas();
            x.Show();
            this.Close();
        }
    }
}
