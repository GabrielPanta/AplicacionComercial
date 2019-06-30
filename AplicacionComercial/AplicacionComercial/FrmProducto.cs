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
        private bool nuevo;
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



        private void HabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            EditarToolStripButton.Enabled = false;
            NuevoToolStripButton.Enabled = false;
            GuardarToolStripButton.Enabled = true;
            CancelarToolStripButton.Enabled = true;
            EliminarToolStripButton.Enabled = false;
            BuscarToolStripButton.Enabled = false;

            //iDProductoTextBox.ReadOnly = false;
            descripcionTextBox.ReadOnly = false;
            iDDepartamentoComboBox.Enabled = true;
            iDIVAComboBox.Enabled = true;
            precioTextBox.ReadOnly = false;
            imagenTextBox.ReadOnly = false;
            iDMedidaComboBox.Enabled = true;
            medidaTextBox.ReadOnly = false;
            notasTextBox.ReadOnly = false;

            AgregarBarraButton.Enabled = true;
            CancelarButton.Enabled = true;
            AgregarBodegaButton.Enabled = true;
            BuscarImagenButton.Enabled = true;

            descripcionTextBox.Focus();
        }


        private void DeshabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            EditarToolStripButton.Enabled = true;
            NuevoToolStripButton.Enabled = true;
            GuardarToolStripButton.Enabled = false;
            CancelarToolStripButton.Enabled = false;
            EliminarToolStripButton.Enabled = true;
            BuscarToolStripButton.Enabled = true;

           // iDProductoTextBox.ReadOnly = true;
            descripcionTextBox.ReadOnly = true;
            iDDepartamentoComboBox.Enabled = false;
            iDIVAComboBox.Enabled = false;
            precioTextBox.ReadOnly = true;
            imagenTextBox.ReadOnly = true;
            iDMedidaComboBox.Enabled = false;
            medidaTextBox.ReadOnly = true;
            notasTextBox.ReadOnly = true;

            AgregarBarraButton.Enabled = false;
            CancelarButton.Enabled = false;
            AgregarBodegaButton.Enabled = false;
            BuscarImagenButton.Enabled = false;
        }



        private void BindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            nuevo = false;
        }

        private void CancelarToolStripButton_Click_1(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            productoBindingSource.CancelEdit();
            LlenarGrillas();
            errorProvider1.Clear();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            productoBindingSource.AddNew();
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            LlenarGrillas();
            //BodegasDataGridView.DataSource = null;
            //BarraDataGridView.DataSource = null;
        }

        private void EliminarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult rspta = MessageBox.Show("¿Estas Seguro de Eliminar el Registro Actual", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rspta == DialogResult.No) return;
            productoBindingSource.RemoveAt(productoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
            DeshabilitarCampos();
        }

        private bool ValidarCampos()
        {
            if (nuevo == true)
            {
                if (descripcionTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(descripcionTextBox, "Debe Ingresar Una Descripcion");
                    return false;
                }
                errorProvider1.Clear();

                if (iDDepartamentoComboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(iDDepartamentoComboBox, "Debe Seleccionar un Departamento");
                    return false;
                }
                errorProvider1.Clear();

            }
            return true;
        }
    }

}
