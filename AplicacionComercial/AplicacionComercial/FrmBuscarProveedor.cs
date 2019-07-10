using System;
using System.Windows.Forms;

namespace AplicacionComercial
{
    public partial class FrmBuscarProveedor : Form
    {
        private int idProveedor;

        public int IdProveedor { get => idProveedor;}

        public FrmBuscarProveedor()
        {
            InitializeComponent();
        }

        private void ProveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);

        }

        private void FrmBuscarProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            string documento,nombre,nombrescontacto, apellidoscontacto;
            if (rbtContenga.Checked == true)
            {
                documento = "%" + documentoToolStripTextBox.Text + "%";
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                nombrescontacto = "%" + nombresContactoToolStripTextBox.Text + "%";
                apellidoscontacto = "%" + apellidosContactoToolStripTextBox.Text + "%";
            }
            else if (rbtEmpiece.Checked == true)
            {

                documento = documentoToolStripTextBox.Text + "%";
                nombre = nombreToolStripTextBox.Text + "%";
                nombrescontacto = nombresContactoToolStripTextBox.Text + "%";
                apellidoscontacto = apellidosContactoToolStripTextBox.Text + "%";
            }
            else if (rbtTermine.Checked == true)
            {
                documento = "%" + documentoToolStripTextBox.Text;
                nombre = "%" + nombreToolStripTextBox.Text;
                nombrescontacto = "%" + nombresContactoToolStripTextBox.Text;
                apellidoscontacto = "%" + apellidosContactoToolStripTextBox.Text;

            }
            else if (rbtIgual.Checked == true)
            {
                documento = "%" + documentoToolStripTextBox.Text + "%";
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                nombrescontacto = "%" + nombresContactoToolStripTextBox.Text + "%";
                apellidoscontacto = "%" + apellidosContactoToolStripTextBox.Text + "%";
            }
            else
            {
                documento =  documentoToolStripTextBox.Text ;
                nombre =  nombreToolStripTextBox.Text;
                nombrescontacto = nombresContactoToolStripTextBox.Text;
                apellidoscontacto = apellidosContactoToolStripTextBox.Text;
            }
            try
            {
                this.proveedorTableAdapter.FillBy1(this.dSAplicacionComercial.Proveedor,documento,nombre,nombrescontacto,apellidoscontacto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnQuitarfiltros_Click(object sender, EventArgs e)
        {
            documentoToolStripTextBox.Text = "";
            nombreToolStripTextBox.Text = "";
            nombresContactoToolStripTextBox.Text = "";
            apellidosContactoToolStripTextBox.Text = "";
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (proveedorDataGridView.Rows.Count == 0)
            {
                idProveedor = 0;

            }else if(proveedorDataGridView.SelectedRows.Count!=0){

                idProveedor =(int) proveedorDataGridView.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                idProveedor = (int)proveedorDataGridView.Rows[0].Cells[0].Value;
            }

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            idProveedor = 0;
            this.Close();
        }
    }
}
