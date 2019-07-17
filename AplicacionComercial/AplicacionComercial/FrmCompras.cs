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
        private CADUsuario usuarioLogueado;
        private decimal totalBruto = 0;
        private decimal totalDescuento = 0;
        private decimal totalIva = 0;
        private decimal totalNeto = 0;

        public CADUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

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

                if (descuento < 0 && descuento <= 100)
                {
                    errorProvider1.SetError(DescuentoTextBox, "Debe ingresar un valor Numérico mayor a 0 y menor e igual a 100");
                    return;
                }

                errorProvider1.Clear();
                descuento /= 100;
            }


            CADIVA miIVA = CADIVA.GetIVA(ultimoProducto.IDIVA);

            DetalleCompra miDetalle = new DetalleCompra();
            miDetalle.IDProducto = ultimoProducto.IDProducto;
            miDetalle.Cantidad = cantidad;
            miDetalle.Costo = costo;
            miDetalle.PorcentajeDescuento = descuento;
            miDetalle.Descripcion = ultimoProducto.Descripcion;
            miDetalle.PorcentajeIVA = miIVA.Tarifa;

            totalBruto += miDetalle.ValorBruto;
            totalDescuento += miDetalle.ValorDescuento;
            totalIva+= miDetalle.ValorIVA;
            totalNeto += miDetalle.ValorNeto;

            misDetalles.Add(miDetalle);
            RefrescarGrid();
            ultimoProducto = null;
            ProductoTextBox.Text = String.Empty;
            CantidadTextBox.Text = String.Empty;
            CostoTextBox.Text = String.Empty;
            DescuentoTextBox.Text = String.Empty;
            ProductoLabel.Text= "Producto...";
        }

        private void RefrescarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = misDetalles;
            PersonalizaGrid();
            totalBrutoTextBox.Text = string.Format("{0:C2}",totalBruto);
            totalIvaTextBox.Text = string.Format("{0:C2}", totalIva);
            totalDescuentoTextBox.Text = string.Format("{0:C2}", totalDescuento);
            totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);

        }

        private void PersonalizaGrid()
        {
            DetalleDataGridView.Columns["IDProducto"].HeaderText = "ID Producto";
            DetalleDataGridView.Columns["IDProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 

            DetalleDataGridView.Columns["Descripcion"].HeaderText = "Descripción";
            DetalleDataGridView.Columns["Descripcion"].Width = 300;

            DetalleDataGridView.Columns["Costo"].HeaderText = "Costo";
            DetalleDataGridView.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DetalleDataGridView.Columns["Costo"].DefaultCellStyle.Format = "C2";
            DetalleDataGridView.Columns["Costo"].Width = 80;

            DetalleDataGridView.Columns["Cantidad"].HeaderText = "Cantidad";
            DetalleDataGridView.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DetalleDataGridView.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            DetalleDataGridView.Columns["Cantidad"].Width = 80;

            DetalleDataGridView.Columns["PorcentajeIVA"].HeaderText = "Porcentaje IVA";
            DetalleDataGridView.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DetalleDataGridView.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";
            DetalleDataGridView.Columns["PorcentajeIVA"].Width = 80;

            DetalleDataGridView.Columns["PorcentajeDescuento"].HeaderText = "Porcentaje Descuento";
            DetalleDataGridView.Columns["PorcentajeDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DetalleDataGridView.Columns["PorcentajeDescuento"].DefaultCellStyle.Format = "P2";
            DetalleDataGridView.Columns["PorcentajeDescuento"].Width = 80;

            DetalleDataGridView.Columns["ValorBruto"].HeaderText = "Valor Bruto";
            DetalleDataGridView.Columns["ValorBruto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DetalleDataGridView.Columns["ValorBruto"].DefaultCellStyle.Format = "C2";
            DetalleDataGridView.Columns["ValorBruto"].Width = 80;

            DetalleDataGridView.Columns["ValorIVA"].HeaderText = "Valor IVA";
            DetalleDataGridView.Columns["ValorIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DetalleDataGridView.Columns["ValorIVA"].DefaultCellStyle.Format = "C2";
            DetalleDataGridView.Columns["ValorIVA"].Width = 80;

            DetalleDataGridView.Columns["ValorDescuento"].HeaderText = "Valor Descuento";
            DetalleDataGridView.Columns["ValorDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DetalleDataGridView.Columns["ValorDescuento"].DefaultCellStyle.Format = "C2";
            DetalleDataGridView.Columns["ValorDescuento"].Width = 80;

            DetalleDataGridView.Columns["ValorNeto"].HeaderText = "Valor Neto";
            DetalleDataGridView.Columns["ValorNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DetalleDataGridView.Columns["ValorNeto"].DefaultCellStyle.Format = "C2";
            DetalleDataGridView.Columns["ValorNeto"].Width = 80;

        }
        private void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto miBusquedaProducto = new FrmBuscarProducto();
            miBusquedaProducto.ShowDialog();
            if (miBusquedaProducto.IdProducto == 0) return;
            ProductoTextBox.Text = Convert.ToString(miBusquedaProducto.IdProducto);
            ProductoTextBox_Validating(sender, new CancelEventArgs());
        }

        private void GrabarButton_Click(object sender, EventArgs e)
        {
            if (ProveedorComboBox.SelectedIndex == -1) {
                errorProvider1.SetError(ProveedorComboBox, "Dbe seleccionar un Proveedor");
                ProveedorComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (BodegaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(BodegaComboBox, "Dbe seleccionar una Bodega");
                BodegaComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (misDetalles.Count == 0)
            {
                errorProvider1.SetError(ProductoTextBox, "Ingresar Productos en la compra");
                ProductoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            DialogResult rta = MessageBox.Show("¿Está seguro de grabar la compra?", "Confirmacion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DialogResult.No == rta) return;

            //Grabamos Encabezado de  la Compra
            int IDCompra = CADCompra.InsertCompra(ComprasDateTimePicker.Value,(int)ProveedorComboBox.SelectedValue,
                (int)BodegaComboBox.SelectedValue);

            //Grabamos detalle de la compra
            foreach (DetalleCompra miDetalle in misDetalles)
            {

            }


        }
    }
}
