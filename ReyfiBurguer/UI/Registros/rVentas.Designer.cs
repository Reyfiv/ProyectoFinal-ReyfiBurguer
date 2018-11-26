namespace ReyfiBurguer.UI.Registros
{
    partial class rVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rVentas));
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CombosListView = new System.Windows.Forms.ListView();
            this.VentasProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EfectivoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.DevueltaTextBox = new System.Windows.Forms.TextBox();
            this.PagarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ProductosListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.VentasComboDataGridView = new System.Windows.Forms.DataGridView();
            this.RevomerComboButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VentasProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasComboDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Combos";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(1104, 653);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(124, 23);
            this.FechaDateTimePicker.TabIndex = 2;
            this.FechaDateTimePicker.Visible = false;
            // 
            // CombosListView
            // 
            this.CombosListView.Location = new System.Drawing.Point(406, 47);
            this.CombosListView.Name = "CombosListView";
            this.CombosListView.Size = new System.Drawing.Size(381, 629);
            this.CombosListView.TabIndex = 4;
            this.CombosListView.UseCompatibleStateImageBehavior = false;
            this.CombosListView.View = System.Windows.Forms.View.SmallIcon;
            this.CombosListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CombosListView_MouseClick);
            // 
            // VentasProductosDataGridView
            // 
            this.VentasProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasProductosDataGridView.Location = new System.Drawing.Point(805, 28);
            this.VentasProductosDataGridView.Name = "VentasProductosDataGridView";
            this.VentasProductosDataGridView.ReadOnly = true;
            this.VentasProductosDataGridView.Size = new System.Drawing.Size(542, 192);
            this.VentasProductosDataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(829, 526);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(829, 578);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Efectivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(829, 627);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Devuelta";
            // 
            // EfectivoNumericUpDown
            // 
            this.EfectivoNumericUpDown.DecimalPlaces = 2;
            this.EfectivoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EfectivoNumericUpDown.Location = new System.Drawing.Point(944, 576);
            this.EfectivoNumericUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.EfectivoNumericUpDown.Name = "EfectivoNumericUpDown";
            this.EfectivoNumericUpDown.Size = new System.Drawing.Size(100, 32);
            this.EfectivoNumericUpDown.TabIndex = 25;
            this.EfectivoNumericUpDown.ValueChanged += new System.EventHandler(this.EfectivoNumericUpDown_ValueChanged);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TotalTextBox.Location = new System.Drawing.Point(944, 520);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 32);
            this.TotalTextBox.TabIndex = 26;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.TotalTextBox_TextChanged);
            // 
            // DevueltaTextBox
            // 
            this.DevueltaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DevueltaTextBox.Location = new System.Drawing.Point(944, 624);
            this.DevueltaTextBox.Name = "DevueltaTextBox";
            this.DevueltaTextBox.ReadOnly = true;
            this.DevueltaTextBox.Size = new System.Drawing.Size(100, 32);
            this.DevueltaTextBox.TabIndex = 27;
            // 
            // PagarButton
            // 
            this.PagarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PagarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PagarButton.Image = global::ReyfiBurguer.Properties.Resources.Cash_in_Hand_32px;
            this.PagarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PagarButton.Location = new System.Drawing.Point(1104, 559);
            this.PagarButton.Name = "PagarButton";
            this.PagarButton.Size = new System.Drawing.Size(124, 62);
            this.PagarButton.TabIndex = 21;
            this.PagarButton.Text = "Pagar";
            this.PagarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PagarButton.UseVisualStyleBackColor = true;
            this.PagarButton.Click += new System.EventHandler(this.PagarButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoverButton.Image = global::ReyfiBurguer.Properties.Resources.salir;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(1223, 226);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(124, 33);
            this.RemoverButton.TabIndex = 20;
            this.RemoverButton.Text = "-Remover fila";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Orden de productos";
            // 
            // ProductosListView
            // 
            this.ProductosListView.Location = new System.Drawing.Point(12, 50);
            this.ProductosListView.Name = "ProductosListView";
            this.ProductosListView.Size = new System.Drawing.Size(381, 629);
            this.ProductosListView.TabIndex = 29;
            this.ProductosListView.UseCompatibleStateImageBehavior = false;
            this.ProductosListView.View = System.Windows.Forms.View.SmallIcon;
            this.ProductosListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductosListView_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Productos";
            // 
            // button1
            // 
            this.button1.Image = global::ReyfiBurguer.Properties.Resources.Cash_Register_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(651, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cerrar Sesion ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentasComboDataGridView
            // 
            this.VentasComboDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasComboDataGridView.Location = new System.Drawing.Point(805, 265);
            this.VentasComboDataGridView.Name = "VentasComboDataGridView";
            this.VentasComboDataGridView.ReadOnly = true;
            this.VentasComboDataGridView.Size = new System.Drawing.Size(542, 223);
            this.VentasComboDataGridView.TabIndex = 32;
            // 
            // RevomerComboButton
            // 
            this.RevomerComboButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevomerComboButton.Image = global::ReyfiBurguer.Properties.Resources.salir;
            this.RevomerComboButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RevomerComboButton.Location = new System.Drawing.Point(1223, 494);
            this.RevomerComboButton.Name = "RevomerComboButton";
            this.RevomerComboButton.Size = new System.Drawing.Size(124, 33);
            this.RevomerComboButton.TabIndex = 33;
            this.RevomerComboButton.Text = "-Remover fila";
            this.RevomerComboButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RevomerComboButton.UseVisualStyleBackColor = true;
            this.RevomerComboButton.Click += new System.EventHandler(this.RevomerComboButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Orden de combos";
            // 
            // rVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReyfiBurguer.Properties.Resources.Logo;
            this.ClientSize = new System.Drawing.Size(1370, 691);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RevomerComboButton);
            this.Controls.Add(this.VentasComboDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductosListView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DevueltaTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.EfectivoNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PagarButton);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.VentasProductosDataGridView);
            this.Controls.Add(this.CombosListView);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rVentas";
            this.Text = "Ventas / Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.VentasProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasComboDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.ListView CombosListView;
        private System.Windows.Forms.DataGridView VentasProductosDataGridView;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button PagarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown EfectivoNumericUpDown;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox DevueltaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ProductosListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RevomerComboButton;
        private System.Windows.Forms.DataGridView VentasComboDataGridView;
        private System.Windows.Forms.Label label7;
    }
}