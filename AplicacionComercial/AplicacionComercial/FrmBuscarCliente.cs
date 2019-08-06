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
    public partial class FrmBuscarCliente : Form
    {
        private int idCliente;

        public int IdCliente { set => idCliente = value; get => idCliente; }

        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dSAplicacionComercial.Cliente);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            string documento, nombrecomercial, nombresContacto, apellidosContacto;

            if (rbtContenga.Checked == true)
            {
                documento = "%" + documentoToolStripTextBox.Text + "%";
                nombrecomercial = "%" + nombreComercialToolStripTextBox.Text+ "%";
                nombresContacto = "%" + nombresContactoToolStripTextBox.Text+ "%";
                apellidosContacto = "%" + apellidosContactoToolStripTextBox.Text + "%";
            }else if (rbtEmpiece.Checked == true)
            {
                documento = "%" + documentoToolStripTextBox.Text ;
                nombrecomercial = "%" + nombreComercialToolStripTextBox.Text ;
                nombresContacto = "%" + nombresContactoToolStripTextBox .Text;
                apellidosContacto = "%" + apellidosContactoToolStripTextBox .Text;
            }else if (rbtTermine.Checked == true)
            {
                documento =  documentoToolStripTextBox.Text + "%";
                nombrecomercial = nombreComercialToolStripTextBox.Text + "%";
                nombresContacto = nombresContactoToolStripTextBox .Text+ "%";
                apellidosContacto =  apellidosContactoToolStripTextBox.Text + "%";
            }else if (rbtIgual.Checked == true)
            {
                documento = documentoToolStripTextBox.Text ;
                nombrecomercial = nombreComercialToolStripTextBox.Text ;
                nombresContacto = nombresContactoToolStripTextBox.Text;
                apellidosContacto = apellidosContactoToolStripTextBox.Text ;
            }
            else
            {
                documento = documentoToolStripTextBox.Text;
                nombrecomercial = nombreComercialToolStripTextBox.Text;
                nombresContacto = nombresContactoToolStripTextBox.Text;
                apellidosContacto = apellidosContactoToolStripTextBox.Text;
            }

            try
            {
                this.clienteTableAdapter.FillBy(this.dSAplicacionComercial.Cliente,documento,nombrecomercial,nombresContacto,apellidosContacto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnQuitarfiltros_Click(object sender, EventArgs e)
        {
            documentoToolStripTextBox.Text = "";
            nombreComercialToolStripTextBox.Text = "";
            nombresContactoToolStripTextBox.Text = "";
            apellidosContactoToolStripTextBox.Text = "";
            this.clienteTableAdapter.Fill(this.dSAplicacionComercial.Cliente);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ClienteDataGridView.Rows.Count == 0)
            {
                idCliente = 0;

            }else if (ClienteDataGridView.SelectedRows.Count != 0)
            {
                idCliente = (int)ClienteDataGridView.SelectedRows[0].Cells[0].Value;
            }else
            {
                idCliente = (int)ClienteDataGridView.Rows[0].Cells[0].Value;
            }

            this.Close();

        }
    }
}
