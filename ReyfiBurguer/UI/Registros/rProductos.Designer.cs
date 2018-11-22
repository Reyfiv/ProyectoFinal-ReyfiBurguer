namespace ReyfiBurguer.UI.Registros
{
    partial class rProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TipoProductoComboBox = new System.Windows.Forms.ComboBox();
            this.DescripcionComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductoId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.DecimalPlaces = 2;
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(196, 140);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(205, 23);
            this.PrecioNumericUpDown.TabIndex = 3;
            // 
            // ProductoIdNumericUpDown
            // 
            this.ProductoIdNumericUpDown.Location = new System.Drawing.Point(196, 19);
            this.ProductoIdNumericUpDown.Name = "ProductoIdNumericUpDown";
            this.ProductoIdNumericUpDown.Size = new System.Drawing.Size(77, 23);
            this.ProductoIdNumericUpDown.TabIndex = 4;
            // 
            // NombreProductoTextBox
            // 
            this.NombreProductoTextBox.Location = new System.Drawing.Point(196, 58);
            this.NombreProductoTextBox.Name = "NombreProductoTextBox";
            this.NombreProductoTextBox.Size = new System.Drawing.Size(205, 23);
            this.NombreProductoTextBox.TabIndex = 5;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.Image = global::ReyfiBurguer.Properties.Resources.Search_25px;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(316, 11);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(85, 36);
            this.BuscarButton.TabIndex = 14;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoButton.Image = global::ReyfiBurguer.Properties.Resources.Add_List_32px;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(36, 235);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(88, 58);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.Image = global::ReyfiBurguer.Properties.Resources.Save_32px;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(158, 235);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 58);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Image = global::ReyfiBurguer.Properties.Resources.Delete_File_32px;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(287, 235);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(88, 58);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo de producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descripcion";
            // 
            // TipoProductoComboBox
            // 
            this.TipoProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoProductoComboBox.FormattingEnabled = true;
            this.TipoProductoComboBox.Items.AddRange(new object[] {
            "Carne de Hamburgesa",
            "Carne de Whopper",
            "2 Carnes de Whopper",
            "Nugets",
            "Filete de pollo",
            "Filete Crispy de pollo",
            "Filete de Pescado",
            "Refresco",
            "Papas",
            "Cebolla",
            "Helado"});
            this.TipoProductoComboBox.Location = new System.Drawing.Point(196, 101);
            this.TipoProductoComboBox.Name = "TipoProductoComboBox";
            this.TipoProductoComboBox.Size = new System.Drawing.Size(205, 24);
            this.TipoProductoComboBox.TabIndex = 20;
            // 
            // DescripcionComboBox
            // 
            this.DescripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescripcionComboBox.FormattingEnabled = true;
            this.DescripcionComboBox.Items.AddRange(new object[] {
            "A la parrilla",
            "Crujiente",
            "Bebidas",
            "Fritos",
            "Postre"});
            this.DescripcionComboBox.Location = new System.Drawing.Point(196, 182);
            this.DescripcionComboBox.Name = "DescripcionComboBox";
            this.DescripcionComboBox.Size = new System.Drawing.Size(205, 24);
            this.DescripcionComboBox.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 312);
            this.Controls.Add(this.DescripcionComboBox);
            this.Controls.Add(this.TipoProductoComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NombreProductoTextBox);
            this.Controls.Add(this.ProductoIdNumericUpDown);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.NumericUpDown ProductoIdNumericUpDown;
        private System.Windows.Forms.TextBox NombreProductoTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoProductoComboBox;
        private System.Windows.Forms.ComboBox DescripcionComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}