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
    public partial class FrmBuscarUsuarios : Form
    {
        private string idUsuario;

        public string IdUsuario { get => idUsuario; }

        public FrmBuscarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmBuscarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dSAplicacionComercial.Rol);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dSAplicacionComercial.Usuario);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            string  nombres,apellidos;
            if (rbtContenga.Checked == true)
            {
                nombres = "%" + nombresToolStripTextBox.Text + "%";
                apellidos = "%" + apellidosToolStripTextBox.Text + "%";
            }
            else if (rbtEmpiece.Checked == true)
            {
                nombres= nombresToolStripTextBox.Text + "%";
                apellidos = apellidosToolStripTextBox.Text + "%";
            }
            else if (rbtTermine.Checked == true)
            {
                nombres= "%" + nombresToolStripTextBox.Text;
                apellidos = "%" + apellidosToolStripTextBox.Text;

            }
            else if (rbtIgual.Checked == true)
            {
                nombres = "%" + nombresToolStripTextBox.Text + "%";
                apellidos = "%" + apellidosToolStripTextBox.Text + "%";
            }
            else
            {
                nombres = nombresToolStripTextBox.Text;
                apellidos = apellidosToolStripTextBox.Text;
            }

            try
            {
                this.usuarioTableAdapter.FillBy(this.dSAplicacionComercial.Usuario, nombres,apellidos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.Rows.Count == 0)
            {
                idUsuario = (string)UsuariosDataGridView.Rows[0].Cells[0].Value;
            }
            else if (UsuariosDataGridView.SelectedRows.Count != 0)
            {
                idUsuario = (string)UsuariosDataGridView.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                idUsuario = (string)UsuariosDataGridView.Rows[0].Cells[0].Value;
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void BtnQuitarfiltros_Click(object sender, EventArgs e)
        {
            nombresToolStripTextBox.Text = string.Empty;
            apellidosToolStripTextBox.Text = string.Empty;
        }
    }
}
