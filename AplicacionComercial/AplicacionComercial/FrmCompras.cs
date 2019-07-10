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

        }


    }
}
