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
    /// Lógica de interacción para Cuentas.xaml
    /// </summary>
    public partial class Cuentas : Page
    {
        public Cuentas()
        {
            InitializeComponent();
            Refrescar();
            SeteoDelInicio();
        }
        BL_Cuenta bl = new BL_Cuenta();
        void Refrescar()
        {
            dtg_Datos.ItemsSource = null;
            dtg_Datos.ItemsSource = bl.Leer().Tables[0].DefaultView;
        }
        void SeteoDelInicio()
        {
            lbxClientes.ItemsSource = (new BL_Cliente()).Leer().Tables[0].DefaultView;
            lbxBancos.ItemsSource = (new BL_Banco()).Leer().Tables[0].DefaultView;
        }
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Cuenta c = new Cuenta();
            c.numeroDeCuenta = txtNumeroDeCuenta.Text;
            c.banco = (int)(lbxBancos.SelectedItem as DataRowView).Row[0];
            c.cliente = (int)(lbxClientes.SelectedItem as DataRowView).Row[0];
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
            Cuenta c = new Cuenta();
            c.id = (int)(dtg_Datos.SelectedItem as DataRowView).Row[0];
            c.numeroDeCuenta = txtNumeroDeCuenta.Text;
            c.banco = (int)(lbxBancos.SelectedItem as DataRowView).Row[0];
            c.cliente = (int)(lbxClientes.SelectedItem as DataRowView).Row[0];
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
            //Cuenta c = new Cuenta();
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
