﻿namespace AplicacionComercial
{
    partial class FrmProducto
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
            System.Windows.Forms.Label iDProductoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDDepartamentoLabel;
            System.Windows.Forms.Label iDIVALabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label iDMedidaLabel;
            System.Windows.Forms.Label medidaLabel;
            System.Windows.Forms.Label imagenLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new AplicacionComercial.DSAplicacionComercial();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial1 = new AplicacionComercial.DSAplicacionComercial();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new AplicacionComercial.DSAplicacionComercialTableAdapters.TableAdapterManager();
            this.iDProductoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iDDepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.departamentoTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.DepartamentoTableAdapter();
            this.iDIVAComboBox = new System.Windows.Forms.ComboBox();
            this.iVATableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.IVATableAdapter();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.iDMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.medidaTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.MedidaTableAdapter();
            this.medidaTextBox = new System.Windows.Forms.TextBox();
            this.imagenTextBox = new System.Windows.Forms.TextBox();
            this.BuscarImagenButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarrasGroupBox = new System.Windows.Forms.GroupBox();
            this.AgregarBarraButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraDataGridView = new System.Windows.Forms.DataGridView();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BodegasGroupBox = new System.Windows.Forms.GroupBox();
            this.AgregarBodegaButton = new System.Windows.Forms.Button();
            this.BodegasDataGridView = new System.Windows.Forms.DataGridView();
            this.iDBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasReposicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.BodegaTableAdapter();
            this.barraTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.BarraTableAdapter();
            this.bodegaProductoTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.BodegaProductoTableAdapter();
            iDProductoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            iDDepartamentoLabel = new System.Windows.Forms.Label();
            iDIVALabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            iDMedidaLabel = new System.Windows.Forms.Label();
            medidaLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarrasGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).BeginInit();
            this.BodegasGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BodegasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.Location = new System.Drawing.Point(39, 38);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(67, 13);
            iDProductoLabel.TabIndex = 2;
            iDProductoLabel.Text = "ID Producto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(37, 64);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // iDDepartamentoLabel
            // 
            iDDepartamentoLabel.AutoSize = true;
            iDDepartamentoLabel.Location = new System.Drawing.Point(26, 90);
            iDDepartamentoLabel.Name = "iDDepartamentoLabel";
            iDDepartamentoLabel.Size = new System.Drawing.Size(77, 13);
            iDDepartamentoLabel.TabIndex = 6;
            iDDepartamentoLabel.Text = "Departamento:";
            // 
            // iDIVALabel
            // 
            iDIVALabel.AutoSize = true;
            iDIVALabel.Location = new System.Drawing.Point(406, 90);
            iDIVALabel.Name = "iDIVALabel";
            iDIVALabel.Size = new System.Drawing.Size(27, 13);
            iDIVALabel.TabIndex = 8;
            iDIVALabel.Text = "IVA:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(63, 117);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 10;
            precioLabel.Text = "Precio:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(65, 170);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 12;
            notasLabel.Text = "Notas:";
            // 
            // iDMedidaLabel
            // 
            iDMedidaLabel.AutoSize = true;
            iDMedidaLabel.Location = new System.Drawing.Point(47, 143);
            iDMedidaLabel.Name = "iDMedidaLabel";
            iDMedidaLabel.Size = new System.Drawing.Size(56, 13);
            iDMedidaLabel.TabIndex = 14;
            iDMedidaLabel.Text = "IDMedida:";
            // 
            // medidaLabel
            // 
            medidaLabel.AutoSize = true;
            medidaLabel.Location = new System.Drawing.Point(388, 143);
            medidaLabel.Name = "medidaLabel";
            medidaLabel.Size = new System.Drawing.Size(45, 13);
            medidaLabel.TabIndex = 16;
            medidaLabel.Text = "Medida:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(340, 119);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(45, 13);
            imagenLabel.TabIndex = 18;
            imagenLabel.Text = "Imagen:";
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productoBindingNavigatorSaveItem});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(991, 25);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
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
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // productoBindingNavigatorSaveItem
            // 
            this.productoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productoBindingNavigatorSaveItem.Image")));
            this.productoBindingNavigatorSaveItem.Name = "productoBindingNavigatorSaveItem";
            this.productoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productoBindingNavigatorSaveItem.Click += new System.EventHandler(this.ProductoBindingNavigatorSaveItem_Click);
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AllowUserToOrderColumns = true;
            this.productoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(0, 409);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.Size = new System.Drawing.Size(991, 267);
            this.productoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.dataGridViewTextBoxColumn1.FillWeight = 85.27921F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.FillWeight = 203.0457F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDDepartamento";
            this.dataGridViewTextBoxColumn3.DataSource = this.departamentoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.FillWeight = 85.27921F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDDepartamento";
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDIVA";
            this.dataGridViewTextBoxColumn4.DataSource = this.iVABindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn4.FillWeight = 85.27921F;
            this.dataGridViewTextBoxColumn4.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDIVA";
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.FillWeight = 85.27921F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn6.FillWeight = 85.27921F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Imagen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Imagen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IDMedida";
            this.dataGridViewTextBoxColumn8.DataSource = this.medidaBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn8.FillWeight = 85.27921F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Unidad Medida";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "IDMedida";
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataMember = "Medida";
            this.medidaBindingSource.DataSource = this.dSAplicacionComercial1;
            // 
            // dSAplicacionComercial1
            // 
            this.dSAplicacionComercial1.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Medida";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn9.FillWeight = 85.27921F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarraTableAdapter = null;
            this.tableAdapterManager.BodegaProductoTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.MedidaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacionComercial.DSAplicacionComercialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // iDProductoTextBox
            // 
            this.iDProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IDProducto", true));
            this.iDProductoTextBox.Location = new System.Drawing.Point(109, 35);
            this.iDProductoTextBox.Name = "iDProductoTextBox";
            this.iDProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDProductoTextBox.TabIndex = 3;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(109, 61);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(540, 20);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // iDDepartamentoComboBox
            // 
            this.iDDepartamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDDepartamento", true));
            this.iDDepartamentoComboBox.DataSource = this.departamentoBindingSource;
            this.iDDepartamentoComboBox.DisplayMember = "Descripcion";
            this.iDDepartamentoComboBox.FormattingEnabled = true;
            this.iDDepartamentoComboBox.Location = new System.Drawing.Point(109, 87);
            this.iDDepartamentoComboBox.Name = "iDDepartamentoComboBox";
            this.iDDepartamentoComboBox.Size = new System.Drawing.Size(249, 21);
            this.iDDepartamentoComboBox.TabIndex = 7;
            this.iDDepartamentoComboBox.ValueMember = "IDDepartamento";
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // iDIVAComboBox
            // 
            this.iDIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDIVA", true));
            this.iDIVAComboBox.DataSource = this.iVABindingSource;
            this.iDIVAComboBox.DisplayMember = "Descripcion";
            this.iDIVAComboBox.FormattingEnabled = true;
            this.iDIVAComboBox.Location = new System.Drawing.Point(439, 87);
            this.iDIVAComboBox.Name = "iDIVAComboBox";
            this.iDIVAComboBox.Size = new System.Drawing.Size(210, 21);
            this.iDIVAComboBox.TabIndex = 9;
            this.iDIVAComboBox.ValueMember = "IDIVA";
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(109, 114);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(151, 20);
            this.precioTextBox.TabIndex = 11;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(109, 167);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(540, 75);
            this.notasTextBox.TabIndex = 13;
            // 
            // iDMedidaComboBox
            // 
            this.iDMedidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDMedida", true));
            this.iDMedidaComboBox.DataSource = this.medidaBindingSource;
            this.iDMedidaComboBox.DisplayMember = "Descripcion";
            this.iDMedidaComboBox.FormattingEnabled = true;
            this.iDMedidaComboBox.Location = new System.Drawing.Point(109, 140);
            this.iDMedidaComboBox.Name = "iDMedidaComboBox";
            this.iDMedidaComboBox.Size = new System.Drawing.Size(249, 21);
            this.iDMedidaComboBox.TabIndex = 15;
            this.iDMedidaComboBox.ValueMember = "IDMedida";
            // 
            // medidaTableAdapter
            // 
            this.medidaTableAdapter.ClearBeforeFill = true;
            // 
            // medidaTextBox
            // 
            this.medidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Medida", true));
            this.medidaTextBox.Location = new System.Drawing.Point(439, 140);
            this.medidaTextBox.Name = "medidaTextBox";
            this.medidaTextBox.Size = new System.Drawing.Size(210, 20);
            this.medidaTextBox.TabIndex = 17;
            // 
            // imagenTextBox
            // 
            this.imagenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Imagen", true));
            this.imagenTextBox.Location = new System.Drawing.Point(391, 114);
            this.imagenTextBox.Name = "imagenTextBox";
            this.imagenTextBox.Size = new System.Drawing.Size(224, 20);
            this.imagenTextBox.TabIndex = 19;
            // 
            // BuscarImagenButton
            // 
            this.BuscarImagenButton.Location = new System.Drawing.Point(621, 114);
            this.BuscarImagenButton.Name = "BuscarImagenButton";
            this.BuscarImagenButton.Size = new System.Drawing.Size(28, 23);
            this.BuscarImagenButton.TabIndex = 20;
            this.BuscarImagenButton.Text = "...";
            this.BuscarImagenButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(685, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 181);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BarrasGroupBox
            // 
            this.BarrasGroupBox.Controls.Add(this.AgregarBarraButton);
            this.BarrasGroupBox.Controls.Add(this.textBox1);
            this.BarrasGroupBox.Controls.Add(this.label1);
            this.BarrasGroupBox.Controls.Add(this.BarraDataGridView);
            this.BarrasGroupBox.Location = new System.Drawing.Point(12, 248);
            this.BarrasGroupBox.Name = "BarrasGroupBox";
            this.BarrasGroupBox.Size = new System.Drawing.Size(306, 155);
            this.BarrasGroupBox.TabIndex = 22;
            this.BarrasGroupBox.TabStop = false;
            this.BarrasGroupBox.Text = "Codigos de Barras";
            // 
            // AgregarBarraButton
            // 
            this.AgregarBarraButton.Location = new System.Drawing.Point(211, 22);
            this.AgregarBarraButton.Name = "AgregarBarraButton";
            this.AgregarBarraButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarBarraButton.TabIndex = 3;
            this.AgregarBarraButton.Text = "Agregar";
            this.AgregarBarraButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barra";
            // 
            // BarraDataGridView
            // 
            this.BarraDataGridView.AllowUserToAddRows = false;
            this.BarraDataGridView.AllowUserToDeleteRows = false;
            this.BarraDataGridView.AllowUserToOrderColumns = true;
            this.BarraDataGridView.AutoGenerateColumns = false;
            this.BarraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BarraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.barraDataGridViewTextBoxColumn});
            this.BarraDataGridView.DataSource = this.barraBindingSource;
            this.BarraDataGridView.Location = new System.Drawing.Point(6, 52);
            this.BarraDataGridView.Name = "BarraDataGridView";
            this.BarraDataGridView.ReadOnly = true;
            this.BarraDataGridView.Size = new System.Drawing.Size(280, 95);
            this.BarraDataGridView.TabIndex = 0;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barraDataGridViewTextBoxColumn
            // 
            this.barraDataGridViewTextBoxColumn.DataPropertyName = "Barra";
            this.barraDataGridViewTextBoxColumn.HeaderText = "Barra";
            this.barraDataGridViewTextBoxColumn.Name = "barraDataGridViewTextBoxColumn";
            this.barraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barraBindingSource
            // 
            this.barraBindingSource.DataMember = "Barra";
            this.barraBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // BodegasGroupBox
            // 
            this.BodegasGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodegasGroupBox.Controls.Add(this.AgregarBodegaButton);
            this.BodegasGroupBox.Controls.Add(this.BodegasDataGridView);
            this.BodegasGroupBox.Location = new System.Drawing.Point(343, 248);
            this.BodegasGroupBox.Name = "BodegasGroupBox";
            this.BodegasGroupBox.Size = new System.Drawing.Size(563, 155);
            this.BodegasGroupBox.TabIndex = 23;
            this.BodegasGroupBox.TabStop = false;
            this.BodegasGroupBox.Text = "Parametros de Bodegas";
            // 
            // AgregarBodegaButton
            // 
            this.AgregarBodegaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarBodegaButton.Location = new System.Drawing.Point(482, 19);
            this.AgregarBodegaButton.Name = "AgregarBodegaButton";
            this.AgregarBodegaButton.Size = new System.Drawing.Size(75, 26);
            this.AgregarBodegaButton.TabIndex = 3;
            this.AgregarBodegaButton.Text = "Agregar";
            this.AgregarBodegaButton.UseVisualStyleBackColor = true;
            // 
            // BodegasDataGridView
            // 
            this.BodegasDataGridView.AllowUserToAddRows = false;
            this.BodegasDataGridView.AllowUserToDeleteRows = false;
            this.BodegasDataGridView.AllowUserToOrderColumns = true;
            this.BodegasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodegasDataGridView.AutoGenerateColumns = false;
            this.BodegasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BodegasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBodegaDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn,
            this.minimoDataGridViewTextBoxColumn,
            this.maximoDataGridViewTextBoxColumn,
            this.diasReposicionDataGridViewTextBoxColumn,
            this.cantidadMinimaDataGridViewTextBoxColumn});
            this.BodegasDataGridView.DataSource = this.bodegaProductoBindingSource;
            this.BodegasDataGridView.Location = new System.Drawing.Point(6, 52);
            this.BodegasDataGridView.Name = "BodegasDataGridView";
            this.BodegasDataGridView.ReadOnly = true;
            this.BodegasDataGridView.Size = new System.Drawing.Size(551, 95);
            this.BodegasDataGridView.TabIndex = 0;
            // 
            // iDBodegaDataGridViewTextBoxColumn
            // 
            this.iDBodegaDataGridViewTextBoxColumn.DataPropertyName = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.HeaderText = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.Name = "iDBodegaDataGridViewTextBoxColumn";
            this.iDBodegaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDProductoDataGridViewTextBoxColumn1
            // 
            this.iDProductoDataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.Name = "iDProductoDataGridViewTextBoxColumn1";
            this.iDProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minimoDataGridViewTextBoxColumn
            // 
            this.minimoDataGridViewTextBoxColumn.DataPropertyName = "Minimo";
            this.minimoDataGridViewTextBoxColumn.HeaderText = "Minimo";
            this.minimoDataGridViewTextBoxColumn.Name = "minimoDataGridViewTextBoxColumn";
            this.minimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maximoDataGridViewTextBoxColumn
            // 
            this.maximoDataGridViewTextBoxColumn.DataPropertyName = "Maximo";
            this.maximoDataGridViewTextBoxColumn.HeaderText = "Maximo";
            this.maximoDataGridViewTextBoxColumn.Name = "maximoDataGridViewTextBoxColumn";
            this.maximoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasReposicionDataGridViewTextBoxColumn
            // 
            this.diasReposicionDataGridViewTextBoxColumn.DataPropertyName = "DiasReposicion";
            this.diasReposicionDataGridViewTextBoxColumn.HeaderText = "DiasReposicion";
            this.diasReposicionDataGridViewTextBoxColumn.Name = "diasReposicionDataGridViewTextBoxColumn";
            this.diasReposicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadMinimaDataGridViewTextBoxColumn
            // 
            this.cantidadMinimaDataGridViewTextBoxColumn.DataPropertyName = "CantidadMinima";
            this.cantidadMinimaDataGridViewTextBoxColumn.HeaderText = "CantidadMinima";
            this.cantidadMinimaDataGridViewTextBoxColumn.Name = "cantidadMinimaDataGridViewTextBoxColumn";
            this.cantidadMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodegaProductoBindingSource
            // 
            this.bodegaProductoBindingSource.DataMember = "BodegaProducto";
            this.bodegaProductoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // barraTableAdapter
            // 
            this.barraTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaProductoTableAdapter
            // 
            this.bodegaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 674);
            this.Controls.Add(this.BodegasGroupBox);
            this.Controls.Add(this.BarrasGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuscarImagenButton);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(this.imagenTextBox);
            this.Controls.Add(medidaLabel);
            this.Controls.Add(this.medidaTextBox);
            this.Controls.Add(iDMedidaLabel);
            this.Controls.Add(this.iDMedidaComboBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(iDIVALabel);
            this.Controls.Add(this.iDIVAComboBox);
            this.Controls.Add(iDDepartamentoLabel);
            this.Controls.Add(this.iDDepartamentoComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(iDProductoLabel);
            this.Controls.Add(this.iDProductoTextBox);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.productoBindingNavigator);
            this.Name = "FrmProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarrasGroupBox.ResumeLayout(false);
            this.BarrasGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).EndInit();
            this.BodegasGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BodegasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSAplicacionComercialTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DSAplicacionComercialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.TextBox iDProductoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox iDDepartamentoComboBox;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DSAplicacionComercialTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.ComboBox iDIVAComboBox;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSAplicacionComercialTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.ComboBox iDMedidaComboBox;
        private DSAplicacionComercial dSAplicacionComercial1;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private DSAplicacionComercialTableAdapters.MedidaTableAdapter medidaTableAdapter;
        private System.Windows.Forms.TextBox medidaTextBox;
        private System.Windows.Forms.TextBox imagenTextBox;
        private System.Windows.Forms.Button BuscarImagenButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox BarrasGroupBox;
        private System.Windows.Forms.Button AgregarBarraButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BarraDataGridView;
        private System.Windows.Forms.GroupBox BodegasGroupBox;
        private System.Windows.Forms.Button AgregarBodegaButton;
        private System.Windows.Forms.DataGridView BodegasDataGridView;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSAplicacionComercialTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.BindingSource barraBindingSource;
        private DSAplicacionComercialTableAdapters.BarraTableAdapter barraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource;
        private DSAplicacionComercialTableAdapters.BodegaProductoTableAdapter bodegaProductoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasReposicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMinimaDataGridViewTextBoxColumn;
    }
}