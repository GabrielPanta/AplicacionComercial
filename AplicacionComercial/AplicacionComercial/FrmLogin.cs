
namespace AplicacionComercial
{
    using System.Windows.Forms;
    using System;
    using CADAplicacionComercial;

    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Debe Ingresar un Usuario");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtContraseña.Text == string.Empty)
            {
                errorProvider1.SetError(txtContraseña, "Debe Ingresar una Contraseña");
                txtContraseña.Focus();
                return;
            }
            errorProvider1.Clear();
            if (!CADUsuario.ValidaUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("El usuario o la Contraseña no coinciden");
            }
            else
            {
                FrmPrincipal miform = new FrmPrincipal();
                miform.UsuarioLogueado = CADUsuario.GetUsuario(txtUsuario.Text);
                miform.Show();
                this.Hide();
            }   
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
