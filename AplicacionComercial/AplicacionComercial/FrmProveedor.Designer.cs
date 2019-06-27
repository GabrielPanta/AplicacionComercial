namespace AplicacionComercial
{
    partial class FrmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            System.Windows.Forms.Label iDProveedorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label iDTipoDocumentoLabel;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombresContactoLabel;
            System.Windows.Forms.Label apellidosContactoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefono1Label;
            System.Windows.Forms.Label telefono2Label;
            System.Windows.Forms.Label notasLabel;
            this.proveedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.proveedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.proveedorDataGridView = new System.Windows.Forms.DataGridView();
            this.iDProveedorTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.iDTipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.nombresContactoTextBox = new System.Windows.Forms.TextBox();
            this.apellidosContactoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefono1TextBox = new System.Windows.Forms.TextBox();
            this.telefono2TextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new AplicacionComercial.DSAplicacionComercial();
            this.proveedorTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.ProveedorTableAdapter();
            this.tableAdapterManager = new AplicacionComercial.DSAplicacionComercialTableAdapters.TableAdapterManager();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDocumentoTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter();
            this.dSAplicacionComercial1 = new AplicacionComercial.DSAplicacionComercial();
            this.tipoDocumentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDProveedorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            iDTipoDocumentoLabel = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombresContactoLabel = new System.Windows.Forms.Label();
            apellidosContactoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefono1Label = new System.Windows.Forms.Label();
            telefono2Label = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingNavigator)).BeginInit();
            this.proveedorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedorBindingNavigator
            // 
            this.proveedorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proveedorBindingNavigator.BindingSource = this.proveedorBindingSource;
            this.proveedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proveedorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proveedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.proveedorBindingNavigatorSaveItem});
            this.proveedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proveedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proveedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proveedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proveedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proveedorBindingNavigator.Name = "proveedorBindingNavigator";
            this.proveedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proveedorBindingNavigator.Size = new System.Drawing.Size(787, 25);
            this.proveedorBindingNavigator.TabIndex = 0;
            this.proveedorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // proveedorBindingNavigatorSaveItem
            // 
            this.proveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proveedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedorBindingNavigatorSaveItem.Image")));
            this.proveedorBindingNavigatorSaveItem.Name = "proveedorBindingNavigatorSaveItem";
            this.proveedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.proveedorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.proveedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.ProveedorBindingNavigatorSaveItem_Click);
            // 
            // proveedorDataGridView
            // 
            this.proveedorDataGridView.AllowUserToAddRows = false;
            this.proveedorDataGridView.AllowUserToDeleteRows = false;
            this.proveedorDataGridView.AllowUserToOrderColumns = true;
            this.proveedorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedorDataGridView.AutoGenerateColumns = false;
            this.proveedorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.proveedorDataGridView.DataSource = this.proveedorBindingSource;
            this.proveedorDataGridView.Location = new System.Drawing.Point(0, 257);
            this.proveedorDataGridView.Name = "proveedorDataGridView";
            this.proveedorDataGridView.ReadOnly = true;
            this.proveedorDataGridView.Size = new System.Drawing.Size(787, 215);
            this.proveedorDataGridView.TabIndex = 1;
            // 
            // iDProveedorLabel
            // 
            iDProveedorLabel.AutoSize = true;
            iDProveedorLabel.Location = new System.Drawing.Point(40, 43);
            iDProveedorLabel.Name = "iDProveedorLabel";
            iDProveedorLabel.Size = new System.Drawing.Size(70, 13);
            iDProveedorLabel.TabIndex = 2;
            iDProveedorLabel.Text = "IDProveedor:";
            // 
            // iDProveedorTextBox
            // 
            this.iDProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "IDProveedor", true));
            this.iDProveedorTextBox.Location = new System.Drawing.Point(116, 40);
            this.iDProveedorTextBox.Name = "iDProveedorTextBox";
            this.iDProveedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDProveedorTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(63, 67);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(116, 66);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(582, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // iDTipoDocumentoLabel
            // 
            iDTipoDocumentoLabel.AutoSize = true;
            iDTipoDocumentoLabel.Location = new System.Drawing.Point(244, 42);
            iDTipoDocumentoLabel.Name = "iDTipoDocumentoLabel";
            iDTipoDocumentoLabel.Size = new System.Drawing.Size(89, 13);
            iDTipoDocumentoLabel.TabIndex = 6;
            iDTipoDocumentoLabel.Text = "Tipo Documento:";
            iDTipoDocumentoLabel.Click += new System.EventHandler(this.IDTipoDocumentoLabel_Click);
            // 
            // iDTipoDocumentoComboBox
            // 
            this.iDTipoDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proveedorBindingSource, "IDTipoDocumento", true));
            this.iDTipoDocumentoComboBox.DataSource = this.tipoDocumentoBindingSource;
            this.iDTipoDocumentoComboBox.DisplayMember = "Descripcion";
            this.iDTipoDocumentoComboBox.FormattingEnabled = true;
            this.iDTipoDocumentoComboBox.Location = new System.Drawing.Point(339, 39);
            this.iDTipoDocumentoComboBox.Name = "iDTipoDocumentoComboBox";
            this.iDTipoDocumentoComboBox.Size = new System.Drawing.Size(140, 21);
            this.iDTipoDocumentoComboBox.TabIndex = 7;
            this.iDTipoDocumentoComboBox.ValueMember = "IDTipoDocumento";
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new System.Drawing.Point(485, 42);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 8;
            documentoLabel.Text = "Documento:";
            documentoLabel.Click += new System.EventHandler(this.DocumentoLabel_Click);
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Documento", true));
            this.documentoTextBox.Location = new System.Drawing.Point(556, 39);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(142, 20);
            this.documentoTextBox.TabIndex = 9;
            // 
            // nombresContactoLabel
            // 
            nombresContactoLabel.AutoSize = true;
            nombresContactoLabel.Location = new System.Drawing.Point(12, 95);
            nombresContactoLabel.Name = "nombresContactoLabel";
            nombresContactoLabel.Size = new System.Drawing.Size(98, 13);
            nombresContactoLabel.TabIndex = 10;
            nombresContactoLabel.Text = "Nombres Contacto:";
            // 
            // nombresContactoTextBox
            // 
            this.nombresContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "NombresContacto", true));
            this.nombresContactoTextBox.Location = new System.Drawing.Point(116, 92);
            this.nombresContactoTextBox.Name = "nombresContactoTextBox";
            this.nombresContactoTextBox.Size = new System.Drawing.Size(231, 20);
            this.nombresContactoTextBox.TabIndex = 11;
            // 
            // apellidosContactoLabel
            // 
            apellidosContactoLabel.AutoSize = true;
            apellidosContactoLabel.Location = new System.Drawing.Point(364, 95);
            apellidosContactoLabel.Name = "apellidosContactoLabel";
            apellidosContactoLabel.Size = new System.Drawing.Size(98, 13);
            apellidosContactoLabel.TabIndex = 12;
            apellidosContactoLabel.Text = "Apellidos Contacto:";
            apellidosContactoLabel.Click += new System.EventHandler(this.ApellidosContactoLabel_Click);
            // 
            // apellidosContactoTextBox
            // 
            this.apellidosContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "ApellidosContacto", true));
            this.apellidosContactoTextBox.Location = new System.Drawing.Point(468, 92);
            this.apellidosContactoTextBox.Name = "apellidosContactoTextBox";
            this.apellidosContactoTextBox.Size = new System.Drawing.Size(231, 20);
            this.apellidosContactoTextBox.TabIndex = 13;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(55, 121);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 14;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(117, 118);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(582, 20);
            this.direccionTextBox.TabIndex = 15;
            // 
            // telefono1Label
            // 
            telefono1Label.AutoSize = true;
            telefono1Label.Location = new System.Drawing.Point(52, 147);
            telefono1Label.Name = "telefono1Label";
            telefono1Label.Size = new System.Drawing.Size(58, 13);
            telefono1Label.TabIndex = 16;
            telefono1Label.Text = "Telefono1:";
            // 
            // telefono1TextBox
            // 
            this.telefono1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Telefono1", true));
            this.telefono1TextBox.Location = new System.Drawing.Point(116, 144);
            this.telefono1TextBox.Name = "telefono1TextBox";
            this.telefono1TextBox.Size = new System.Drawing.Size(231, 20);
            this.telefono1TextBox.TabIndex = 17;
            // 
            // telefono2Label
            // 
            telefono2Label.AutoSize = true;
            telefono2Label.Location = new System.Drawing.Point(377, 147);
            telefono2Label.Name = "telefono2Label";
            telefono2Label.Size = new System.Drawing.Size(58, 13);
            telefono2Label.TabIndex = 18;
            telefono2Label.Text = "Telefono2:";
            telefono2Label.Click += new System.EventHandler(this.Telefono2Label_Click);
            // 
            // telefono2TextBox
            // 
            this.telefono2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Telefono2", true));
            this.telefono2TextBox.Location = new System.Drawing.Point(441, 144);
            this.telefono2TextBox.Name = "telefono2TextBox";
            this.telefono2TextBox.Size = new System.Drawing.Size(257, 20);
            this.telefono2TextBox.TabIndex = 19;
            this.telefono2TextBox.TextChanged += new System.EventHandler(this.Telefono2TextBox_TextChanged);
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(72, 173);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 20;
            notasLabel.Text = "Notas:";
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(117, 173);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(581, 78);
            this.notasTextBox.TabIndex = 21;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacionComercial.DSAplicacionComercialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // dSAplicacionComercial1
            // 
            this.dSAplicacionComercial1.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDocumentoBindingSource1
            // 
            this.tipoDocumentoBindingSource1.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource1.DataSource = this.dSAplicacionComercial1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDProveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDTipoDocumento";
            this.dataGridViewTextBoxColumn3.DataSource = this.tipoDocumentoBindingSource1;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "TipoDocumento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDTipoDocumento";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Documento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombresContacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "NombresContacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ApellidosContacto";
            this.dataGridViewTextBoxColumn6.HeaderText = "ApellidosContacto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono1";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefono1";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefono2";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefono2";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn11.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 472);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(telefono2Label);
            this.Controls.Add(this.telefono2TextBox);
            this.Controls.Add(telefono1Label);
            this.Controls.Add(this.telefono1TextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(apellidosContactoLabel);
            this.Controls.Add(this.apellidosContactoTextBox);
            this.Controls.Add(nombresContactoLabel);
            this.Controls.Add(this.nombresContactoTextBox);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(iDTipoDocumentoLabel);
            this.Controls.Add(this.iDTipoDocumentoComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(iDProveedorLabel);
            this.Controls.Add(this.iDProveedorTextBox);
            this.Controls.Add(this.proveedorDataGridView);
            this.Controls.Add(this.proveedorBindingNavigator);
            this.Name = "FrmProveedor";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingNavigator)).EndInit();
            this.proveedorBindingNavigator.ResumeLayout(false);
            this.proveedorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DSAplicacionComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private DSAplicacionComercialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proveedorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton proveedorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView proveedorDataGridView;
        private System.Windows.Forms.TextBox iDProveedorTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox iDTipoDocumentoComboBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox nombresContactoTextBox;
        private System.Windows.Forms.TextBox apellidosContactoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefono1TextBox;
        private System.Windows.Forms.TextBox telefono2TextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private DSAplicacionComercial dSAplicacionComercial1;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}