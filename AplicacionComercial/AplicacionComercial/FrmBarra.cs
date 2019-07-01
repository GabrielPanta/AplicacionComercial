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
    public partial class FrmBarra : Form
    {
        public long Barra;
        public FrmBarra()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (BarraTextBox.Text == String.Empty)
            {
                //MessageBox.Show("Debe Ingresar Una barra");
                errorProvider1.SetError(BarraTextBox, "Debe ingresar una Barra");
                BarraTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            
            if(!long.TryParse(BarraTextBox.Text,out Barra))
            {
               // MessageBox.Show("Debe Ingresar un Numero de Barra");
                errorProvider1.SetError(BarraTextBox, "Debe Ingresar un Numero de Barra");
                BarraTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (CADBarra.ExisteBarra(Barra))
            {
               // MessageBox.Show("Ya existe esa BARRA");
                errorProvider1.SetError(BarraTextBox, "Ya existe esa BARRA");
                BarraTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (Barra < 1000000)
            {
                errorProvider1.SetError(BarraTextBox, "El Numero no corresponde a un numero de barra");
                BarraTextBox.Focus();
                return;
            }
        }
    }
}
