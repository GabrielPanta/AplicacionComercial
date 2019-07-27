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
    public partial class FrmCambiarClave : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }
        public FrmCambiarClave()
        {
            InitializeComponent();
        }


        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ContraseñaTextBox, "Debe Ingresar una Contraseña!");
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();


            if (ContraseñaTextBox.Text != usuarioLogueado.Clave)
            {
                errorProvider1.SetError(ContraseñaTextBox, "Contraseña Incorrecta!");
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();


            if (NuevaContraseñaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NuevaContraseñaTextBox, "Debe Ingresar una Nueva Contraseña!");
                NuevaContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (ConfirmacionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ConfirmacionTextBox, "Debe Ingresar una Contraseña!");
                ConfirmacionTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (NuevaContraseñaTextBox.Text != ConfirmacionTextBox.Text)
            {
                errorProvider1.SetError(NuevaContraseñaTextBox, "Contraseña no Coinciden!");
                errorProvider1.SetError(ConfirmacionTextBox, "Contraseña no Coinciden!");
                ConfirmacionTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            CADUsuario.CambioClave(NuevaContraseñaTextBox.Text, usuarioLogueado.IDUsuario);
            //MessageBox.Show("Se cambió la Contraseña", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();

        }


    }
}
