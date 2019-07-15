using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionComercial
{
    public partial class FrmBuscarProducto : Form
    {
        private int idProducto;

        public int IdProducto { get => idProducto; }

        public FrmBuscarProducto()
        {
            InitializeComponent();
        }

        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSAplicacionComercial.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dSAplicacionComercial.Producto);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            string idProducto;
            string descripcion;
            if (rbtContenga.Checked == true)
            {
                idProducto = "%" + (iDProductoToolStripTextBox.Text) + "%";
                descripcion = "%" + descripcionToolStripTextBox.Text + "%";
            }
            else if (rbtEmpiece.Checked == true)
            {

                idProducto = iDProductoToolStripTextBox.Text + "%";
                descripcion = descripcionToolStripTextBox.Text + "%";
            }
            else if (rbtTermine.Checked == true)
            {
                idProducto = "%" + iDProductoToolStripTextBox.Text;
                descripcion = "%" + descripcionToolStripTextBox.Text;

            }
            else if (rbtIgual.Checked == true)
            {
                idProducto = "%" + iDProductoToolStripTextBox.Text + "%";
                descripcion = "%" + descripcionToolStripTextBox.Text + "%";
            }
            else
            {
                idProducto = iDProductoToolStripTextBox.Text;
                descripcion = descripcionToolStripTextBox.Text;
            }
            try
            {
                this.productoTableAdapter.FillBy(this.dSAplicacionComercial.Producto, Convert.ToInt32(idProducto), descripcion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show("error");
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ProductoDataGridView.Rows.Count == 0)
            {
                idProducto = 0;
            } else if (ProductoDataGridView.SelectedRows.Count != 0)
            {
                idProducto = (int)ProductoDataGridView.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                idProducto = (int)ProductoDataGridView.Rows[0].Cells[0].Value;
            }
            
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            idProducto = 0;
            this.Close();
        }
    }
}
