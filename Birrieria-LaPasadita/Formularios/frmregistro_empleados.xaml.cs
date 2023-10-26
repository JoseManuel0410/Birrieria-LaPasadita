using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para frmregistro_empleados.xaml
    /// </summary>
    public partial class frmregistro_empleados : Window
    {
        public frmregistro_empleados()
        {
            InitializeComponent();
        }
        private void btnordenes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnventas_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmventas x = new Formularios.frmventas();
            x.Show();
            this.Close();
        }

        private void txttelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !OnlyNumberText(e.Text);
        }
        private static readonly Regex _regex = new Regex("[^0-9.-]+");
        private static bool OnlyNumberText(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void btncancelar_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnclientes_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmclientes x = new Formularios.frmclientes();
            x.Show();
            this.Close();
        }
    }
}
