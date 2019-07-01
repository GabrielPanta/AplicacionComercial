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
        private long barra=0;
        public FrmBarra()
        {
            InitializeComponent();
        }

        public long Barra { get => barra; set => barra = value; }

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


            if (!long.TryParse(BarraTextBox.Text, out barra))
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
            this.Close();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
           Barra=0;
            this.Close();
        }
    }
}
