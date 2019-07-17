using CADAplicacionComercial;
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
    public partial class FrmParametrosBodega : Form
    {
        private int idProducto;

        public int IDProducto { set => idProducto = value; }

        public FrmParametrosBodega()
        {
            InitializeComponent();
        }

        private void FrmParametrosBodega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSAplicacionComercial.Bodega);
            BodegaComboBox.SelectedIndex = -1;
        }

        private void BodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BodegaComboBox.SelectedIndex == -1) return;
            CADBodegaProducto miBodegaProducto = CADBodegaProducto.GetBodegaProductoByIDBodegaAndIDProducto
                ( (int)BodegaComboBox.SelectedValue, idProducto);
            if (miBodegaProducto == null)
            {
                StockTextBox.Text = string.Empty;
                CantidadMinimaNumericUpDown.Value = 1;
                DiasReposicionNumericUpDown.Value = 1;
                CantidadMaximaNumericUpDown.Value = 1;
                CantidadMinimaOrdenarNumericUpDown.Value = 1;
            }
            else
            {
                StockTextBox.Text = miBodegaProducto.Stock.ToString();
                CantidadMinimaNumericUpDown.Value =(decimal) miBodegaProducto.Minimo;
                DiasReposicionNumericUpDown.Value = (decimal)miBodegaProducto.DiasReposicion;
                CantidadMaximaNumericUpDown.Value = (decimal)miBodegaProducto.Maximo;
                CantidadMinimaOrdenarNumericUpDown.Value = (decimal)miBodegaProducto.CantidadMinima;
            }
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (BodegaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(BodegaComboBox, "Debe seleccionar una Bodega");
                BodegaComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            CADBodegaProducto.UpdateBodegaProducto((int)BodegaComboBox.SelectedValue, idProducto, 
                (double)CantidadMinimaNumericUpDown.Value,
                (double)CantidadMaximaNumericUpDown.Value, (int)DiasReposicionNumericUpDown.Value,
                (double)CantidadMinimaOrdenarNumericUpDown.Value);
            this.Close();
        }
    }
}
