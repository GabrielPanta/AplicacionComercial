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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 41);
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
            this.ProveedorComboBox.Location = new System.Drawing.Point(91, 38);
            this.ProveedorComboBox.Name = "ProveedorComboBox";
            this.ProveedorComboBox.Size = new System.Drawing.Size(419, 21);
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
            this.BodegaComboBox.Location = new System.Drawing.Point(91, 65);
            this.BodegaComboBox.Name = "BodegaComboBox";
            this.BodegaComboBox.Size = new System.Drawing.Size(419, 21);
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
            this.label3.Location = new System.Drawing.Point(41, 68);
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
            this.label4.Location = new System.Drawing.Point(35, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Producto";
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(91, 92);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(288, 20);
            this.ProductoTextBox.TabIndex = 7;
            this.ProductoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ProductoTextBox_Validating);
            // 
            // BuscarProveedorButton
            // 
            this.BuscarProveedorButton.Location = new System.Drawing.Point(542, 38);
            this.BuscarProveedorButton.Name = "BuscarProveedorButton";
            this.BuscarProveedorButton.Size = new System.Drawing.Size(47, 21);
            this.BuscarProveedorButton.TabIndex = 8;
            this.BuscarProveedorButton.Text = "...";
            this.BuscarProveedorButton.UseVisualStyleBackColor = true;
            this.BuscarProveedorButton.Click += new System.EventHandler(this.BuscarProveedorButton_Click);
            // 
            // BuscarProductoButton
            // 
            this.BuscarProductoButton.Location = new System.Drawing.Point(404, 92);
            this.BuscarProductoButton.Name = "BuscarProductoButton";
            this.BuscarProductoButton.Size = new System.Drawing.Size(47, 21);
            this.BuscarProductoButton.TabIndex = 9;
            this.BuscarProductoButton.Text = "...";
            this.BuscarProductoButton.UseVisualStyleBackColor = true;
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProductoLabel.Location = new System.Drawing.Point(457, 96);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(70, 13);
            this.ProductoLabel.TabIndex = 10;
            this.ProductoLabel.Text = "Producto...";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
    }
}