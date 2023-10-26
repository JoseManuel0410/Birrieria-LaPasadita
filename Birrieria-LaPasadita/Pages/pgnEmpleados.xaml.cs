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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Birrieria_LaPasadita.Formularios;
using Birrieria_LaPasadita.Pages;

namespace Birrieria_LaPasadita.Pages
{
    /// <summary>
    /// Lógica de interacción para pgnEmpleados.xaml
    /// </summary>
    public partial class pgnEmpleados : Page
    {
        public pgnEmpleados()
        {
            InitializeComponent();
        }

        private void btnEliminarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Esta seguro que desea eliminar este empleado", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Empleado eliminado", "Elimnar", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
        }

        private void btnRegEmpleados_Click(object sender, RoutedEventArgs e)
        {
            grid_1.Visibility = Visibility.Collapsed;
            Main.Content = new pgnRegistro_Empleados();
        }
    }
}
