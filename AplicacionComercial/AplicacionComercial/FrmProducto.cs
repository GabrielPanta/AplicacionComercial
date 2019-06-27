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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void ProductoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSAplicacionComercial.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial1.Medida' Puede moverla o quitarla según sea necesario.
            this.medidaTableAdapter.Fill(this.dSAplicacionComercial1.Medida);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.IVA' Puede moverla o quitarla según sea necesario.
            this.iVATableAdapter.Fill(this.dSAplicacionComercial.IVA);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSAplicacionComercial.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dSAplicacionComercial.Producto);
            
            LlenarGrillas();
        }

        private void LlenarGrillas()
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Barra' Puede moverla o quitarla según sea necesario.
            this.barraTableAdapter.FillBy(this.dSAplicacionComercial.Barra, Convert.ToInt32(iDProductoTextBox.Text));
            this.bodegaProductoTableAdapter.FillBy(this.dSAplicacionComercial.BodegaProducto, Convert.ToInt32(iDProductoTextBox.Text));
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void BindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

    }

}
