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
using System.Windows.Shapes;

namespace Birrieria_LaPasadita.Formularios
{
    /// <summary>
    /// Lógica de interacción para frmempleados.xaml
    /// </summary>
    /// 
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public decimal Sueldo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
    public partial class frmempleados : Window
    {
        ObservableCollection<Empleado> empleados = new ObservableCollection<Empleado>();
        public frmempleados()
        {
            InitializeComponent();
            // Agrega empleados de ejemplo a la colección
            empleados.Add(new Empleado { ID = 1, Nombre = "Cesar Abel Vege Renteria", Cargo = "Mesero", Sueldo = 1500.67m, Telefono = "123-456-7890", Direccion = "Calle 123" });
            empleados.Add(new Empleado { ID = 2, Nombre = "José Manuel Ornelas Acosta", Cargo = "Jefe", Sueldo = 3800.98m, Telefono = "987-654-3210", Direccion = "Avenida 456" });

            // Establece la colección como origen de datos del DataGrid
            dtgdEmpleados.ItemsSource = empleados;
        }

        private void btnordenes_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmordenes x = new Formularios.frmordenes();
            x.Show();
            this.Close();
        }

        private void btnventas_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmventas x = new Formularios.frmventas();
            x.Show();
            this.Close();
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

        private void btnRegistroEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmregistro_empleados x = new Formularios.frmregistro_empleados();
            x.Show();
            this.Close();
        }

        private void btnmodificar_empleado_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmregistro_empleados x = new Formularios.frmregistro_empleados();
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
