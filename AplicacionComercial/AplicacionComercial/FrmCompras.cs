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
        List<DetalleCompra> misDetalles = new List<DetalleCompra>();
        CADProducto ultimoProducto = null;
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
            ProveedorComboBox.SelectedValue = -1;
            BodegaComboBox.SelectedValue = -1;
            DetalleDataGridView.DataSource = misDetalles;

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
                ultimoProducto = miProducto;
                if (!File.Exists(miProducto.Imagen))
                {
                    ProductoPictureBox.Image = null;
                }
                else
                {
                    ProductoPictureBox.Load(miProducto.Imagen);
                }
            }
        }

        private void AñadirButton_Click(object sender, EventArgs e)
        {
            if (ultimoProducto == null)
            {
                errorProvider1.SetError(ProductoTextBox, "Debe ingresar un Producto");
                ProductoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (CantidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CantidadTextBox, "Debe Ingresar una Cantidad");
                return;
            }
            errorProvider1.Clear();

            float cantidad;
            if (!float.TryParse(CantidadTextBox.Text, out cantidad))
            {
                errorProvider1.SetError(CantidadTextBox, "Debe ingresar un valor Numérico");
                return;
            }
            errorProvider1.Clear();

            if (cantidad <= 0)
            {
                errorProvider1.SetError(CantidadTextBox, "Debe ingresar un valor Numérico mayor a 0");
                return;
            }
            errorProvider1.Clear();

            if (CostoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CostoTextBox, "Debe Ingresar un Costo");
                return;
            }
            errorProvider1.Clear();

            decimal costo;
            if (!decimal.TryParse(CostoTextBox.Text, out costo))
            {
                errorProvider1.SetError(CostoTextBox, "Debe ingresar un valor Numérico");
                return;
            }
            errorProvider1.Clear();

            if (costo <= 0)
            {
                errorProvider1.SetError(CostoTextBox, "Debe ingresar un valor Numérico mayor a 0");
                return;
            }
            errorProvider1.Clear();

            float descuento = 0;
            if (DescuentoTextBox.Text != "")
            {
                 
                if (!float.TryParse(DescuentoTextBox.Text, out descuento))
                {
                    errorProvider1.SetError(DescuentoTextBox, "Debe ingresar un valor Numérico");
                    return;
                }
                errorProvider1.Clear();

                if (descuento < 0)
                {
                    errorProvider1.SetError(DescuentoTextBox, "Debe ingresar un valor Numérico mayor a 0");
                    return;
                }
                errorProvider1.Clear();
            }
           


            DetalleCompra miDetalle = new DetalleCompra();
            miDetalle.Cantidad = cantidad;
            miDetalle.Costo = costo;
            miDetalle.PorcentajeDescuento = descuento;
            miDetalle.Descripcion = ultimoProducto.Descripcion;
            miDetalle.IDProducto = ultimoProducto.IDProducto;
            miDetalle.PorcentajeIVA = 0;

            misDetalles.Add(miDetalle);
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = misDetalles;

        }

        private void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto miBusquedaProducto = new FrmBuscarProducto();
            miBusquedaProducto.ShowDialog();
            if (miBusquedaProducto.IdProducto == 0) return;
            ProductoTextBox.Text = Convert.ToString(miBusquedaProducto.IdProducto);
            ProductoTextBox_Validating(sender, new CancelEventArgs());
        }
    }
}
