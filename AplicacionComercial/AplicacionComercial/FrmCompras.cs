using CADAplicacionComercial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionComercial
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.FillBy(this.dSAplicacionComercial.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter.Fill(this.dSAplicacionComercial.Compra);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.FillBy(this.dSAplicacionComercial.Proveedor);
            ComprasDateTimePicker.Value = DateTime.Now;
            ProveedorComboBox.SelectedValue= -1;
            BodegaComboBox.SelectedValue = -1;

        }

        private void BuscarProveedorButton_Click(object sender, EventArgs e)
        {
            FrmBuscarProveedor miBusquedaProveedor = new FrmBuscarProveedor();
            miBusquedaProveedor.ShowDialog();
            if (miBusquedaProveedor.IdProveedor == 0) return;
            ProveedorComboBox.SelectedValue = miBusquedaProveedor.IdProveedor;
        }

        private void ProductoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (ProductoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ProductoTextBox, "Debe Ingresar un ID de Producto");
                return;
            }
            errorProvider1.Clear();

            long Producto;
            if (!long.TryParse(ProductoTextBox.Text, out Producto))
            {
                errorProvider1.SetError(ProductoTextBox, "Debe ingresar un valor Numérico");
                return;
            }
            errorProvider1.Clear();

            if (Producto <= 0)
            {
                errorProvider1.SetError(ProductoTextBox, "Debe ingresar un valor Numérico mayor a 0");
                return;
            }
            errorProvider1.Clear();

            CADProducto miProducto = CADProducto.GetProductoByIDProducto((int)Producto);


            if (miProducto == null)
            {
                miProducto = CADProducto.GetProductoByBarra((int)Producto);
            }

            if (miProducto == null)
            {
                errorProvider1.SetError(ProductoTextBox, "Producto No existe");
                ProductoLabel.Text = String.Empty;
                ProductoPictureBox.Image = null;
            }
            else
            {
                ProductoLabel.Text = miProducto.Descripcion;
                if (!File.Exists(miProducto.Imagen))
                {
                    ProductoPictureBox.Image = null;
                }
                else
                {
                    ProductoPictureBox.Load (miProducto.Imagen);
                }
            }
        }
    }
}
