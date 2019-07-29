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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void ProveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial1.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial1.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);

        }

        private void BuscarToolStripButton_Click(object sender, EventArgs e)
        {
            FrmBuscarProveedor miProveedor = new FrmBuscarProveedor();
            miProveedor.ShowDialog();
            if (miProveedor.IdProveedor == 0) return;
            //int position = proveedorBindingSource.Find("IdProveedor", miProveedor.IdProveedor);
            //proveedorBindingSource.Position = position;
            proveedorBindingSource.Position = proveedorBindingSource.Find("IdProveedor", miProveedor.IdProveedor);

        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
