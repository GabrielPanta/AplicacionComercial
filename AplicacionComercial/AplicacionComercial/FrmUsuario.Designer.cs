namespace AplicacionComercial
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDUsuarioLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label fechaModificacionClaveLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label iDRolLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.dSAplicacionComercial = new AplicacionComercial.DSAplicacionComercial();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new AplicacionComercial.DSAplicacionComercialTableAdapters.TableAdapterManager();
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.CancelartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BuscartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.fechaModificacionClaveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.iDRolComboBox = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmacionTextBox = new System.Windows.Forms.TextBox();
            this.rolTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.RolTableAdapter();
            this.dSAplicacionComercial1 = new AplicacionComercial.DSAplicacionComercial();
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            iDUsuarioLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            fechaModificacionClaveLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            iDRolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDUsuarioLabel
            // 
            iDUsuarioLabel.AutoSize = true;
            iDUsuarioLabel.Location = new System.Drawing.Point(12, 47);
            iDUsuarioLabel.Name = "iDUsuarioLabel";
            iDUsuarioLabel.Size = new System.Drawing.Size(57, 13);
            iDUsuarioLabel.TabIndex = 1;
            iDUsuarioLabel.Text = "IDUsuario:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(17, 73);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 3;
            nombresLabel.Text = "Nombres:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(17, 99);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(32, 125);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 7;
            claveLabel.Text = "Clave:";
            // 
            // fechaModificacionClaveLabel
            // 
            fechaModificacionClaveLabel.AutoSize = true;
            fechaModificacionClaveLabel.Location = new System.Drawing.Point(243, 48);
            fechaModificacionClaveLabel.Name = "fechaModificacionClaveLabel";
            fechaModificacionClaveLabel.Size = new System.Drawing.Size(133, 13);
            fechaModificacionClaveLabel.TabIndex = 9;
            fechaModificacionClaveLabel.Text = "Fecha Modificacion Clave:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(335, 99);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 13;
            correoLabel.Text = "Correo:";
            // 
            // iDRolLabel
            // 
            iDRolLabel.AutoSize = true;
            iDRolLabel.Location = new System.Drawing.Point(350, 72);
            iDRolLabel.Name = "iDRolLabel";
            iDRolLabel.Size = new System.Drawing.Size(26, 13);
            iDRolLabel.TabIndex = 11;
            iDRolLabel.Text = "Rol:";
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacionComercial.DSAplicacionComercialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = null;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = null;
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.EditartoolStripButton,
            this.bindingNavigatorAddNewItem,
            this.CancelartoolStripButton,
            this.usuarioBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.BuscartoolStripButton});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(739, 25);
            this.usuarioBindingNavigator.TabIndex = 0;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.BindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.BindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.BindingNavigatorPositionItem_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.BindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.BindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EditartoolStripButton
            // 
            this.EditartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditartoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditartoolStripButton.Image")));
            this.EditartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton.Name = "EditartoolStripButton";
            this.EditartoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EditartoolStripButton.Text = "toolStripButton2";
            this.EditartoolStripButton.ToolTipText = "Editar";
            this.EditartoolStripButton.Click += new System.EventHandler(this.EditartoolStripButton_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // CancelartoolStripButton
            // 
            this.CancelartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelartoolStripButton.Enabled = false;
            this.CancelartoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelartoolStripButton.Image")));
            this.CancelartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelartoolStripButton.Name = "CancelartoolStripButton";
            this.CancelartoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CancelartoolStripButton.Text = "toolStripButton2";
            this.CancelartoolStripButton.Click += new System.EventHandler(this.CancelartoolStripButton_Click);
            // 
            // usuarioBindingNavigatorSaveItem
            // 
            this.usuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuarioBindingNavigatorSaveItem.Enabled = false;
            this.usuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingNavigatorSaveItem.Image")));
            this.usuarioBindingNavigatorSaveItem.Name = "usuarioBindingNavigatorSaveItem";
            this.usuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuarioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.usuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.UsuarioBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // BuscartoolStripButton
            // 
            this.BuscartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscartoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscartoolStripButton.Image")));
            this.BuscartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscartoolStripButton.Name = "BuscartoolStripButton";
            this.BuscartoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BuscartoolStripButton.Text = "toolStripButton1";
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(0, 171);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(740, 262);
            this.usuarioDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn4.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaModificacionClave";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha Modificacion Clave";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IDRol";
            this.dataGridViewTextBoxColumn6.DataSource = this.rolBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "IDRol";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // iDUsuarioTextBox
            // 
            this.iDUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IDUsuario", true));
            this.iDUsuarioTextBox.Location = new System.Drawing.Point(75, 44);
            this.iDUsuarioTextBox.Name = "iDUsuarioTextBox";
            this.iDUsuarioTextBox.ReadOnly = true;
            this.iDUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDUsuarioTextBox.TabIndex = 2;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(75, 70);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.ReadOnly = true;
            this.nombresTextBox.Size = new System.Drawing.Size(244, 20);
            this.nombresTextBox.TabIndex = 4;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(75, 96);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.ReadOnly = true;
            this.apellidosTextBox.Size = new System.Drawing.Size(244, 20);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(75, 122);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.ReadOnly = true;
            this.claveTextBox.Size = new System.Drawing.Size(121, 20);
            this.claveTextBox.TabIndex = 8;
            // 
            // fechaModificacionClaveDateTimePicker
            // 
            this.fechaModificacionClaveDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "FechaModificacionClave", true));
            this.fechaModificacionClaveDateTimePicker.Enabled = false;
            this.fechaModificacionClaveDateTimePicker.Location = new System.Drawing.Point(382, 44);
            this.fechaModificacionClaveDateTimePicker.Name = "fechaModificacionClaveDateTimePicker";
            this.fechaModificacionClaveDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaModificacionClaveDateTimePicker.TabIndex = 10;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(382, 96);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.ReadOnly = true;
            this.correoTextBox.Size = new System.Drawing.Size(306, 20);
            this.correoTextBox.TabIndex = 14;
            // 
            // iDRolComboBox
            // 
            this.iDRolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "IDRol", true));
            this.iDRolComboBox.DataSource = this.rolBindingSource;
            this.iDRolComboBox.DisplayMember = "Descripcion";
            this.iDRolComboBox.Enabled = false;
            this.iDRolComboBox.FormattingEnabled = true;
            this.iDRolComboBox.Location = new System.Drawing.Point(382, 69);
            this.iDRolComboBox.Name = "iDRolComboBox";
            this.iDRolComboBox.Size = new System.Drawing.Size(200, 21);
            this.iDRolComboBox.TabIndex = 12;
            this.iDRolComboBox.ValueMember = "IDRol";
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.dSAplicacionComercial;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirmación";
            // 
            // ConfirmacionTextBox
            // 
            this.ConfirmacionTextBox.Location = new System.Drawing.Point(382, 122);
            this.ConfirmacionTextBox.Name = "ConfirmacionTextBox";
            this.ConfirmacionTextBox.PasswordChar = '*';
            this.ConfirmacionTextBox.ReadOnly = true;
            this.ConfirmacionTextBox.Size = new System.Drawing.Size(121, 20);
            this.ConfirmacionTextBox.TabIndex = 16;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // dSAplicacionComercial1
            // 
            this.dSAplicacionComercial1.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataMember = "Rol";
            this.rolBindingSource1.DataSource = this.dSAplicacionComercial1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 431);
            this.Controls.Add(this.ConfirmacionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(iDRolLabel);
            this.Controls.Add(this.iDRolComboBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(fechaModificacionClaveLabel);
            this.Controls.Add(this.fechaModificacionClaveDateTimePicker);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(iDUsuarioLabel);
            this.Controls.Add(this.iDUsuarioTextBox);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.Name = "FrmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DSAplicacionComercialTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private DSAplicacionComercialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.TextBox iDUsuarioTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.DateTimePicker fechaModificacionClaveDateTimePicker;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.ToolStripButton BuscartoolStripButton;
        private System.Windows.Forms.ToolStripButton CancelartoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ComboBox iDRolComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmacionTextBox;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private DSAplicacionComercialTableAdapters.RolTableAdapter rolTableAdapter;
        private DSAplicacionComercial dSAplicacionComercial1;
        private System.Windows.Forms.BindingSource rolBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}