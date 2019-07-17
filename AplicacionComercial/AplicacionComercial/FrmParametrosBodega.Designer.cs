namespace AplicacionComercial
{
    partial class FrmParametrosBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametrosBodega));
            this.label1 = new System.Windows.Forms.Label();
            this.BodegaComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new AplicacionComercial.DSAplicacionComercial();
            this.bodegaTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.BodegaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CantidadMinimaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DiasReposicionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadMaximaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadMinimaOrdenarNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadMinimaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasReposicionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadMaximaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadMinimaOrdenarNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega";
            // 
            // BodegaComboBox
            // 
            this.BodegaComboBox.DataSource = this.bodegaBindingSource;
            this.BodegaComboBox.DisplayMember = "Descripcion";
            this.BodegaComboBox.FormattingEnabled = true;
            this.BodegaComboBox.Location = new System.Drawing.Point(154, 12);
            this.BodegaComboBox.Name = "BodegaComboBox";
            this.BodegaComboBox.Size = new System.Drawing.Size(279, 21);
            this.BodegaComboBox.TabIndex = 1;
            this.BodegaComboBox.ValueMember = "IDBodega";
            this.BodegaComboBox.SelectedIndexChanged += new System.EventHandler(this.BodegaComboBox_SelectedIndexChanged);
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock";
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(154, 39);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.ReadOnly = true;
            this.StockTextBox.Size = new System.Drawing.Size(160, 20);
            this.StockTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = " Cantidad Maxima";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dias Reposicion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad Minima";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad Minima a  Ordenar";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.Location = new System.Drawing.Point(354, 106);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(79, 61);
            this.CancelarButton.TabIndex = 13;
            this.CancelarButton.Text = "Eliminar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Image = ((System.Drawing.Image)(resources.GetObject("AceptarButton.Image")));
            this.AceptarButton.Location = new System.Drawing.Point(354, 39);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(79, 61);
            this.AceptarButton.TabIndex = 12;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CantidadMinimaNumericUpDown
            // 
            this.CantidadMinimaNumericUpDown.Location = new System.Drawing.Point(154, 67);
            this.CantidadMinimaNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CantidadMinimaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadMinimaNumericUpDown.Name = "CantidadMinimaNumericUpDown";
            this.CantidadMinimaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantidadMinimaNumericUpDown.TabIndex = 14;
            this.CantidadMinimaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DiasReposicionNumericUpDown
            // 
            this.DiasReposicionNumericUpDown.Location = new System.Drawing.Point(154, 93);
            this.DiasReposicionNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.DiasReposicionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiasReposicionNumericUpDown.Name = "DiasReposicionNumericUpDown";
            this.DiasReposicionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DiasReposicionNumericUpDown.TabIndex = 15;
            this.DiasReposicionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CantidadMaximaNumericUpDown
            // 
            this.CantidadMaximaNumericUpDown.Location = new System.Drawing.Point(154, 119);
            this.CantidadMaximaNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.CantidadMaximaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadMaximaNumericUpDown.Name = "CantidadMaximaNumericUpDown";
            this.CantidadMaximaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantidadMaximaNumericUpDown.TabIndex = 16;
            this.CantidadMaximaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CantidadMinimaOrdenarNumericUpDown
            // 
            this.CantidadMinimaOrdenarNumericUpDown.Location = new System.Drawing.Point(154, 145);
            this.CantidadMinimaOrdenarNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CantidadMinimaOrdenarNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadMinimaOrdenarNumericUpDown.Name = "CantidadMinimaOrdenarNumericUpDown";
            this.CantidadMinimaOrdenarNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantidadMinimaOrdenarNumericUpDown.TabIndex = 17;
            this.CantidadMinimaOrdenarNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmParametrosBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 175);
            this.Controls.Add(this.CantidadMinimaOrdenarNumericUpDown);
            this.Controls.Add(this.CantidadMaximaNumericUpDown);
            this.Controls.Add(this.DiasReposicionNumericUpDown);
            this.Controls.Add(this.CantidadMinimaNumericUpDown);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BodegaComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParametrosBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Parametros Bodega";
            this.Load += new System.EventHandler(this.FrmParametrosBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadMinimaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasReposicionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadMaximaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadMinimaOrdenarNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BodegaComboBox;
        private DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSAplicacionComercialTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.NumericUpDown CantidadMinimaNumericUpDown;
        private System.Windows.Forms.NumericUpDown DiasReposicionNumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadMaximaNumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadMinimaOrdenarNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}