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
    public partial class FrmUsuario : Form
    {
        private bool nuevo;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void UsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(!ValidarDatos())return;
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
            DeshabilitarCampos();
        }

        private bool ValidarDatos()
        {
            if (nuevo)
            {
                if (iDUsuarioTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "Debe ingresar un Uusario");
                    iDUsuarioTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();

                if (CADUsuario.ExisteUsuarios(iDUsuarioTextBox.Text))
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "El IDUsuario ya Existe");
                    iDUsuarioTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();

                if (nombresTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(nombresTextBox, "Debe ingresar un Nombre");
                    nombresTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();

                if (apellidosTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(apellidosTextBox, "Debe ingresar un apellido");
                    apellidosTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();

                if (claveTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(claveTextBox, "Debe ingresar una Clave");
                    claveTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
                if (claveTextBox.Text != ConfirmacionTextBox.Text)
                {
                    errorProvider1.SetError(claveTextBox, "Clave y Confirmación no coinciden");
                    errorProvider1.SetError(ConfirmacionTextBox, "Clave y Confirmación no coinciden");
                    claveTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
            }
            return true;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial1.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dSAplicacionComercial1.Rol);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dSAplicacionComercial.Rol);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dSAplicacionComercial.Usuario);
            ConfirmacionTextBox.Text = claveTextBox.Text;

        }

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            nuevo = false;
        }

        private void HabilitarCampos()
        {
            EditartoolStripButton.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            CancelartoolStripButton.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            usuarioBindingNavigatorSaveItem.Enabled = true;
            BuscartoolStripButton.Enabled = false;

            iDUsuarioTextBox.ReadOnly = false;
            nombresTextBox.ReadOnly = false;
            apellidosTextBox.ReadOnly = false;
            claveTextBox.ReadOnly = false;
            correoTextBox.ReadOnly = false;
            iDRolComboBox.Enabled = true;
            ConfirmacionTextBox.ReadOnly = false;
            
        }

        private void CancelartoolStripButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            usuarioBindingSource.CancelEdit();
            ConfirmacionTextBox.Text = claveTextBox.Text;
            errorProvider1.Clear();
        }

        private void DeshabilitarCampos()
        {
            EditartoolStripButton.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            CancelartoolStripButton.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = true;
            usuarioBindingNavigatorSaveItem.Enabled =false;
            BuscartoolStripButton.Enabled = true;

            iDUsuarioTextBox.ReadOnly = true;
            nombresTextBox.ReadOnly = true;
            apellidosTextBox.ReadOnly = true;
            claveTextBox.ReadOnly = true;
            correoTextBox.ReadOnly = true;
            iDRolComboBox.Enabled =false;
            ConfirmacionTextBox.ReadOnly =true;
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            ConfirmacionTextBox.Text = claveTextBox.Text;
        }

        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            ConfirmacionTextBox.Text = claveTextBox.Text;
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            ConfirmacionTextBox.Text = claveTextBox.Text;
        }

        private void BindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            ConfirmacionTextBox.Text = claveTextBox.Text;
        }

        private void BindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            ConfirmacionTextBox.Text = claveTextBox.Text;
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();
            HabilitarCampos();
            fechaModificacionClaveDateTimePicker.Value = DateTime.Now;
            nuevo = true;            
        }

 
    }
}
