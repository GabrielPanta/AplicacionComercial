namespace AplicacionComercial
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.ComprasDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new AplicacionComercial.DSAplicacionComercial();
            this.BodegaComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.proveedorTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.ProveedorTableAdapter();
            this.bodegaTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.BodegaTableAdapter();
            this.compraTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.CompraTableAdapter();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.BuscarProveedorButton = new System.Windows.Forms.Button();
            this.BuscarProductoButton = new System.Windows.Forms.Button();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CostoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductoPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalIvaTextBox = new System.Windows.Forms.TextBox();
            this.totalNetoTextBox = new System.Windows.Forms.TextBox();
            this.totalDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.totalBrutoTextBox = new System.Windows.Forms.TextBox();
            this.GrabarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.BorrarTodoButton = new System.Windows.Forms.Button();
            this.BorrarLineaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ComprasDateTimePicker
            // 
            this.ComprasDateTimePicker.Location = new System.Drawing.Point(107, 29);
            this.ComprasDateTimePicker.Name = "ComprasDateTimePicker";
            this.ComprasDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ComprasDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proveedor";
            // 
            // ProveedorComboBox
            // 
            this.ProveedorComboBox.DataSource = this.proveedorBindingSource;
            this.ProveedorComboBox.DisplayMember = "Nombre";
            this.ProveedorComboBox.FormattingEnabled = true;
            this.ProveedorComboBox.Location = new System.Drawing.Point(107, 55);
            this.ProveedorComboBox.Name = "ProveedorComboBox";
            this.ProveedorComboBox.Size = new System.Drawing.Size(477, 21);
            this.ProveedorComboBox.TabIndex = 3;
            this.ProveedorComboBox.ValueMember = "IDProveedor";
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
            // BodegaComboBox
            // 
            this.BodegaComboBox.DataSource = this.bodegaBindingSource;
            this.BodegaComboBox.DisplayMember = "Descripcion";
            this.BodegaComboBox.FormattingEnabled = true;
            this.BodegaComboBox.Location = new System.Drawing.Point(107, 82);
            this.BodegaComboBox.Name = "BodegaComboBox";
            this.BodegaComboBox.Size = new System.Drawing.Size(477, 21);
            this.BodegaComboBox.TabIndex = 5;
            this.BodegaComboBox.ValueMember = "IDBodega";
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bodega";
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // compraBindingSource1
            // 
            this.compraBindingSource1.DataMember = "Compra";
            this.compraBindingSource1.DataSource = this.dSAplicacionComercial;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Producto";
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(107, 109);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(160, 20);
            this.ProductoTextBox.TabIndex = 7;
            this.ProductoTextBox.TextChanged += new System.EventHandler(this.ProductoTextBox_TextChanged);
            this.ProductoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ProductoTextBox_Validating);
            // 
            // BuscarProveedorButton
            // 
            this.BuscarProveedorButton.Location = new System.Drawing.Point(613, 55);
            this.BuscarProveedorButton.Name = "BuscarProveedorButton";
            this.BuscarProveedorButton.Size = new System.Drawing.Size(47, 21);
            this.BuscarProveedorButton.TabIndex = 8;
            this.BuscarProveedorButton.Text = "...";
            this.BuscarProveedorButton.UseVisualStyleBackColor = true;
            this.BuscarProveedorButton.Click += new System.EventHandler(this.BuscarProveedorButton_Click);
            // 
            // BuscarProductoButton
            // 
            this.BuscarProductoButton.Location = new System.Drawing.Point(296, 109);
            this.BuscarProductoButton.Name = "BuscarProductoButton";
            this.BuscarProductoButton.Size = new System.Drawing.Size(47, 21);
            this.BuscarProductoButton.TabIndex = 9;
            this.BuscarProductoButton.Text = "...";
            this.BuscarProductoButton.UseVisualStyleBackColor = true;
            this.BuscarProductoButton.Click += new System.EventHandler(this.BuscarProductoButton_Click);
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProductoLabel.Location = new System.Drawing.Point(349, 113);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(70, 13);
            this.ProductoLabel.TabIndex = 10;
            this.ProductoLabel.Text = "Producto...";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(107, 135);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(160, 20);
            this.CantidadTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // CostoTextBox
            // 
            this.CostoTextBox.Location = new System.Drawing.Point(107, 161);
            this.CostoTextBox.Name = "CostoTextBox";
            this.CostoTextBox.Size = new System.Drawing.Size(160, 20);
            this.CostoTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Costo";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(107, 187);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(160, 20);
            this.DescuentoTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "%Descuento";
            // 
            // AñadirButton
            // 
            this.AñadirButton.Image = ((System.Drawing.Image)(resources.GetObject("AñadirButton.Image")));
            this.AñadirButton.Location = new System.Drawing.Point(296, 151);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(75, 69);
            this.AñadirButton.TabIndex = 17;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowUserToAddRows = false;
            this.DetalleDataGridView.AllowUserToDeleteRows = false;
            this.DetalleDataGridView.AllowUserToOrderColumns = true;
            this.DetalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetalleDataGridView.Location = new System.Drawing.Point(-4, 226);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.ReadOnly = true;
            this.DetalleDataGridView.Size = new System.Drawing.Size(983, 239);
            this.DetalleDataGridView.TabIndex = 18;
            // 
            // ProductoPictureBox
            // 
            this.ProductoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductoPictureBox.Location = new System.Drawing.Point(705, 4);
            this.ProductoPictureBox.Name = "ProductoPictureBox";
            this.ProductoPictureBox.Size = new System.Drawing.Size(262, 216);
            this.ProductoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductoPictureBox.TabIndex = 19;
            this.ProductoPictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Totales";
            // 
            // totalIvaTextBox
            // 
            this.totalIvaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalIvaTextBox.Location = new System.Drawing.Point(601, 471);
            this.totalIvaTextBox.Name = "totalIvaTextBox";
            this.totalIvaTextBox.ReadOnly = true;
            this.totalIvaTextBox.Size = new System.Drawing.Size(118, 20);
            this.totalIvaTextBox.TabIndex = 21;
            // 
            // totalNetoTextBox
            // 
            this.totalNetoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalNetoTextBox.Location = new System.Drawing.Point(849, 471);
            this.totalNetoTextBox.Name = "totalNetoTextBox";
            this.totalNetoTextBox.ReadOnly = true;
            this.totalNetoTextBox.Size = new System.Drawing.Size(118, 20);
            this.totalNetoTextBox.TabIndex = 22;
            // 
            // totalDescuentoTextBox
            // 
            this.totalDescuentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDescuentoTextBox.Location = new System.Drawing.Point(725, 471);
            this.totalDescuentoTextBox.Name = "totalDescuentoTextBox";
            this.totalDescuentoTextBox.ReadOnly = true;
            this.totalDescuentoTextBox.Size = new System.Drawing.Size(118, 20);
            this.totalDescuentoTextBox.TabIndex = 23;
            // 
            // totalBrutoTextBox
            // 
            this.totalBrutoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalBrutoTextBox.Location = new System.Drawing.Point(477, 471);
            this.totalBrutoTextBox.Name = "totalBrutoTextBox";
            this.totalBrutoTextBox.ReadOnly = true;
            this.totalBrutoTextBox.Size = new System.Drawing.Size(118, 20);
            this.totalBrutoTextBox.TabIndex = 24;
            // 
            // GrabarButton
            // 
            this.GrabarButton.Image = ((System.Drawing.Image)(resources.GetObject("GrabarButton.Image")));
            this.GrabarButton.Location = new System.Drawing.Point(377, 151);
            this.GrabarButton.Name = "GrabarButton";
            this.GrabarButton.Size = new System.Drawing.Size(75, 69);
            this.GrabarButton.TabIndex = 25;
            this.GrabarButton.Text = "Grabar";
            this.GrabarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GrabarButton.UseVisualStyleBackColor = true;
            this.GrabarButton.Click += new System.EventHandler(this.GrabarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.Location = new System.Drawing.Point(458, 151);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 69);
            this.CancelarButton.TabIndex = 26;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // BorrarTodoButton
            // 
            this.BorrarTodoButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarTodoButton.Image")));
            this.BorrarTodoButton.Location = new System.Drawing.Point(620, 151);
            this.BorrarTodoButton.Name = "BorrarTodoButton";
            this.BorrarTodoButton.Size = new System.Drawing.Size(75, 69);
            this.BorrarTodoButton.TabIndex = 28;
            this.BorrarTodoButton.Text = "Borrar Todo";
            this.BorrarTodoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrarTodoButton.UseVisualStyleBackColor = true;
            this.BorrarTodoButton.Click += new System.EventHandler(this.BorrarTodoButton_Click);
            // 
            // BorrarLineaButton
            // 
            this.BorrarLineaButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarLineaButton.Image")));
            this.BorrarLineaButton.Location = new System.Drawing.Point(539, 151);
            this.BorrarLineaButton.Name = "BorrarLineaButton";
            this.BorrarLineaButton.Size = new System.Drawing.Size(75, 69);
            this.BorrarLineaButton.TabIndex = 27;
            this.BorrarLineaButton.Text = "Borrar Línea";
            this.BorrarLineaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrarLineaButton.UseVisualStyleBackColor = true;
            this.BorrarLineaButton.Click += new System.EventHandler(this.BorrarLineaButton_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 514);
            this.Controls.Add(this.BorrarTodoButton);
            this.Controls.Add(this.BorrarLineaButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GrabarButton);
            this.Controls.Add(this.totalBrutoTextBox);
            this.Controls.Add(this.totalDescuentoTextBox);
            this.Controls.Add(this.totalNetoTextBox);
            this.Controls.Add(this.totalIvaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductoPictureBox);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.AñadirButton);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CostoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.BuscarProductoButton);
            this.Controls.Add(this.BuscarProveedorButton);
            this.Controls.Add(this.ProductoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BodegaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProveedorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComprasDateTimePicker);
            this.Name = "FrmCompras";
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompras_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ComprasDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProveedorComboBox;
        private System.Windows.Forms.ComboBox BodegaComboBox;
        private System.Windows.Forms.Label label3;
        private DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DSAplicacionComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSAplicacionComercialTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private DSAplicacionComercialTableAdapters.CompraTableAdapter compraTableAdapter;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.BindingSource compraBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.Button BuscarProveedorButton;
        private System.Windows.Forms.Button BuscarProductoButton;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox ProductoPictureBox;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CostoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalDescuentoTextBox;
        private System.Windows.Forms.TextBox totalNetoTextBox;
        private System.Windows.Forms.TextBox totalIvaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalBrutoTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GrabarButton;
        private System.Windows.Forms.Button BorrarTodoButton;
        private System.Windows.Forms.Button BorrarLineaButton;
    }
}