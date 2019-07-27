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
    public partial class FrmPrincipal : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario miform =new FrmUsuario();
            miform.Show();
            miform.MdiParent = this;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            UsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombres + "" + usuarioLogueado.Apellidos;
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor miform = new FrmProveedor();
            miform.Show();
            miform.MdiParent = this;
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto miform = new FrmProducto();
            miform.Show();
            miform.MdiParent = this;
           
        }

        private void ProductosToolStripButton_Click(object sender, EventArgs e)
        {
            ProductosToolStripMenuItem_Click( sender,  e);
        }

        private void ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras miform = new FrmCompras();
            miform.Show();
            miform.MdiParent = this;
        }

        private void CambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarClave miForm = new FrmCambiarClave();
            miForm.UsuarioLogueado = this.usuarioLogueado;
            miForm.ShowDialog();
        }
    }
}
