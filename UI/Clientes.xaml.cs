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
using BE;
using BL;
using System.Data;


namespace UI
{
    /// <summary>
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : Page
    {
        BL_Cliente bl = new BL_Cliente();

        public Clientes()
        {
            InitializeComponent();
            Refrescar();
        }
        void Refrescar()
        {
            dtg_Datos.ItemsSource = null;
            dtg_Datos.ItemsSource = bl.Leer().Tables[0].DefaultView;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.nombre = txtNombre.Text;
            c.apellido = txtApellido.Text;
            c.fechaNac = dtpFecha.SelectedDate.Value;
            c.edad = DateTime.Now.Year-c.fechaNac.Year;
            if(bl.Agregar(c))
            {
                MessageBox.Show("Éxito");
                Refrescar();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.id = (int)(dtg_Datos.SelectedItem as DataRowView).Row[0];
            c.nombre = txtNombre.Text;
            c.apellido = txtApellido.Text;
            c.fechaNac = dtpFecha.SelectedDate.Value;
            c.edad = DateTime.Now.Year - c.fechaNac.Year;
            if (bl.Modificar(c))
            {
                MessageBox.Show("Éxito");
                Refrescar();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            int id;
            //Cliente c = new Cliente();
            //c.id = (int)(dtg_Datos.SelectedItem as DataRowView).Row[0];
            id = (int)(dtg_Datos.SelectedItem as DataRowView).Row[0];
            if (bl.Eliminar(id))
            {
                MessageBox.Show("Éxito");
                Refrescar();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
