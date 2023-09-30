using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Lógica de interacción para frmmenu.xaml
    /// </summary>
    public partial class frmmenu : Window
    {
        public frmmenu()
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

        private void btnclientes_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmclientes x = new Formularios.frmclientes();
            x.Show();
            this.Close();
        }
    }
}
