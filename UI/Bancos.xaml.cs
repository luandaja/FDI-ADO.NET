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
using BL;
using BE;
using System.Data;


namespace UI
{
    /// <summary>
    /// Lógica de interacción para Bancos.xaml
    /// </summary>
    public partial class Bancos : Page
    {
        public Bancos()
        {
            InitializeComponent();
            Refrescar();
        }
        BL_Banco bl = new BL_Banco();
        void Refrescar()
        {
            dtg_Datos.ItemsSource = null;
            dtg_Datos.ItemsSource = bl.Leer().Tables[0].DefaultView;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Banco c = new Banco();
            c.nombre = txtNombre.Text;
            c.swift = txtSwift.Text;
            if (bl.Agregar(c))
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
            Banco c = new Banco();
            c.id = (int)(dtg_Datos.SelectedItem as DataRowView).Row[0];
            c.nombre = txtNombre.Text;
            c.swift = txtSwift.Text;
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
            //Banco c = new Banco();
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
