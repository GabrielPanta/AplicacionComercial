namespace AplicacionComercial
{
    partial class FrmBuscarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarProducto));
            this.ProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.iDProductoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.descripcionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.descripcionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iDProductoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarfiltros = new System.Windows.Forms.Button();
            this.rbtIgual = new System.Windows.Forms.RadioButton();
            this.rbtTermine = new System.Windows.Forms.RadioButton();
            this.rbtEmpiece = new System.Windows.Forms.RadioButton();
            this.rbtContenga = new System.Windows.Forms.RadioButton();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new AplicacionComercial.DSAplicacionComercial();
            this.iDIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.ProductoTableAdapter();
            this.departamentoTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.DepartamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoDataGridView
            // 
            this.ProductoDataGridView.AllowUserToAddRows = false;
            this.ProductoDataGridView.AllowUserToDeleteRows = false;
            this.ProductoDataGridView.AllowUserToOrderColumns = true;
            this.ProductoDataGridView.AutoGenerateColumns = false;
            this.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.iDDepartamentoDataGridViewTextBoxColumn,
            this.iDIVADataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn,
            this.iDMedidaDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn});
            this.ProductoDataGridView.DataSource = this.productoBindingSource;
            this.ProductoDataGridView.Location = new System.Drawing.Point(0, 128);
            this.ProductoDataGridView.Name = "ProductoDataGridView";
            this.ProductoDataGridView.ReadOnly = true;
            this.ProductoDataGridView.Size = new System.Drawing.Size(801, 297);
            this.ProductoDataGridView.TabIndex = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDProductoToolStripLabel,
            this.iDProductoToolStripTextBox,
            this.descripcionToolStripLabel,
            this.descripcionToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(804, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // iDProductoToolStripTextBox
            // 
            this.iDProductoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iDProductoToolStripTextBox.Name = "iDProductoToolStripTextBox";
            this.iDProductoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // descripcionToolStripLabel
            // 
            this.descripcionToolStripLabel.Name = "descripcionToolStripLabel";
            this.descripcionToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.descripcionToolStripLabel.Text = "Descripcion:";
            // 
            // descripcionToolStripTextBox
            // 
            this.descripcionToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descripcionToolStripTextBox.Name = "descripcionToolStripTextBox";
            this.descripcionToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillByToolStripButton.Image")));
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // iDProductoToolStripLabel
            // 
            this.iDProductoToolStripLabel.Name = "iDProductoToolStripLabel";
            this.iDProductoToolStripLabel.Size = new System.Drawing.Size(70, 22);
            this.iDProductoToolStripLabel.Text = "IDProducto:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(582, 38);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 31);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(582, 75);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarfiltros);
            this.groupBox1.Controls.Add(this.rbtIgual);
            this.groupBox1.Controls.Add(this.rbtTermine);
            this.groupBox1.Controls.Add(this.rbtEmpiece);
            this.groupBox1.Controls.Add(this.rbtContenga);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Criterio";
            // 
            // btnQuitarfiltros
            // 
            this.btnQuitarfiltros.Location = new System.Drawing.Point(405, 19);
            this.btnQuitarfiltros.Name = "btnQuitarfiltros";
            this.btnQuitarfiltros.Size = new System.Drawing.Size(125, 29);
            this.btnQuitarfiltros.TabIndex = 4;
            this.btnQuitarfiltros.Text = "Quitar Filtros";
            this.btnQuitarfiltros.UseVisualStyleBackColor = true;
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.Location = new System.Drawing.Point(310, 28);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(66, 17);
            this.rbtIgual.TabIndex = 3;
            this.rbtIgual.Text = "Igual a...";
            this.rbtIgual.UseVisualStyleBackColor = true;
            // 
            // rbtTermine
            // 
            this.rbtTermine.AutoSize = true;
            this.rbtTermine.Location = new System.Drawing.Point(217, 28);
            this.rbtTermine.Name = "rbtTermine";
            this.rbtTermine.Size = new System.Drawing.Size(87, 17);
            this.rbtTermine.TabIndex = 2;
            this.rbtTermine.Text = "Termine en...";
            this.rbtTermine.UseVisualStyleBackColor = true;
            // 
            // rbtEmpiece
            // 
            this.rbtEmpiece.AutoSize = true;
            this.rbtEmpiece.Location = new System.Drawing.Point(105, 28);
            this.rbtEmpiece.Name = "rbtEmpiece";
            this.rbtEmpiece.Size = new System.Drawing.Size(93, 17);
            this.rbtEmpiece.TabIndex = 1;
            this.rbtEmpiece.Text = "Empiece por...";
            this.rbtEmpiece.UseVisualStyleBackColor = true;
            // 
            // rbtContenga
            // 
            this.rbtContenga.AutoSize = true;
            this.rbtContenga.Checked = true;
            this.rbtContenga.Location = new System.Drawing.Point(6, 28);
            this.rbtContenga.Name = "rbtContenga";
            this.rbtContenga.Size = new System.Drawing.Size(80, 17);
            this.rbtContenga.TabIndex = 0;
            this.rbtContenga.TabStop = true;
            this.rbtContenga.Text = "Contenga...";
            this.rbtContenga.UseVisualStyleBackColor = true;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDepartamentoDataGridViewTextBoxColumn
            // 
            this.iDDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IDDepartamento";
            this.iDDepartamentoDataGridViewTextBoxColumn.DataSource = this.departamentoBindingSource;
            this.iDDepartamentoDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDDepartamentoDataGridViewTextBoxColumn.HeaderText = " Departamento";
            this.iDDepartamentoDataGridViewTextBoxColumn.Name = "iDDepartamentoDataGridViewTextBoxColumn";
            this.iDDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDepartamentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDepartamentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDepartamentoDataGridViewTextBoxColumn.ValueMember = "IDDepartamento";
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDIVADataGridViewTextBoxColumn
            // 
            this.iDIVADataGridViewTextBoxColumn.DataPropertyName = "IDIVA";
            this.iDIVADataGridViewTextBoxColumn.HeaderText = "IDIVA";
            this.iDIVADataGridViewTextBoxColumn.Name = "iDIVADataGridViewTextBoxColumn";
            this.iDIVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMedidaDataGridViewTextBoxColumn
            // 
            this.iDMedidaDataGridViewTextBoxColumn.DataPropertyName = "IDMedida";
            this.iDMedidaDataGridViewTextBoxColumn.HeaderText = "IDMedida";
            this.iDMedidaDataGridViewTextBoxColumn.Name = "iDMedidaDataGridViewTextBoxColumn";
            this.iDMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "Medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 422);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.ProductoDataGridView);
            this.Name = "FrmBuscarProducto";
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.FrmBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductoDataGridView;
        private DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSAplicacionComercialTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DSAplicacionComercialTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripTextBox iDProductoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel descripcionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox descripcionToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripLabel iDProductoToolStripLabel;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitarfiltros;
        private System.Windows.Forms.RadioButton rbtIgual;
        private System.Windows.Forms.RadioButton rbtTermine;
        private System.Windows.Forms.RadioButton rbtEmpiece;
        private System.Windows.Forms.RadioButton rbtContenga;
    }
}