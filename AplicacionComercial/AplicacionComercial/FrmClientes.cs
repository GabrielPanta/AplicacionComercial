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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void ClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dSAplicacionComercial.Cliente);


        }

        private void BuscarToolStripButton_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente miForm =new  FrmBuscarCliente();
            miForm.ShowDialog();
            if (miForm.IdCliente == 0) return;
            clienteBindingSource.Position = clienteBindingSource.Find("IDCliente", miForm.IdCliente);
        }
    }
}
