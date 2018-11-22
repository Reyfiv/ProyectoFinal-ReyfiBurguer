namespace ReyfiBurguer.UI.Registros
{
    partial class rCombos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCombos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreComboTextBox = new System.Windows.Forms.TextBox();
            this.ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.ComboDataGridView = new System.Windows.Forms.DataGridView();
            this.PrecioTotalComboTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ComboIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ComboId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del combo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Productos agregados al combo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio total del combo";
            // 
            // ComboIdNumericUpDown
            // 
            this.ComboIdNumericUpDown.Location = new System.Drawing.Point(179, 17);
            this.ComboIdNumericUpDown.Name = "ComboIdNumericUpDown";
            this.ComboIdNumericUpDown.Size = new System.Drawing.Size(106, 23);
            this.ComboIdNumericUpDown.TabIndex = 5;
            // 
            // NombreComboTextBox
            // 
            this.NombreComboTextBox.Location = new System.Drawing.Point(179, 57);
            this.NombreComboTextBox.Name = "NombreComboTextBox";
            this.NombreComboTextBox.Size = new System.Drawing.Size(250, 23);
            this.NombreComboTextBox.TabIndex = 6;
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.Location = new System.Drawing.Point(179, 103);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(173, 24);
            this.ProductoComboBox.TabIndex = 7;
            // 
            // ComboDataGridView
            // 
            this.ComboDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComboDataGridView.Location = new System.Drawing.Point(27, 180);
            this.ComboDataGridView.Name = "ComboDataGridView";
            this.ComboDataGridView.ReadOnly = true;
            this.ComboDataGridView.Size = new System.Drawing.Size(402, 174);
            this.ComboDataGridView.TabIndex = 8;
            
            // 
            // PrecioTotalComboTextBox
            // 
            this.PrecioTotalComboTextBox.Location = new System.Drawing.Point(329, 412);
            this.PrecioTotalComboTextBox.Name = "PrecioTotalComboTextBox";
            this.PrecioTotalComboTextBox.ReadOnly = true;
            this.PrecioTotalComboTextBox.Size = new System.Drawing.Size(100, 23);
            this.PrecioTotalComboTextBox.TabIndex = 9;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarButton.Image = global::ReyfiBurguer.Properties.Resources.Plus_25px;
            this.AgregarButton.Location = new System.Drawing.Point(371, 97);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(40, 34);
            this.AgregarButton.TabIndex = 10;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.Image = global::ReyfiBurguer.Properties.Resources.Search_25px;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(344, 9);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(85, 36);
            this.BuscarButton.TabIndex = 15;
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
            this.NuevoButton.Location = new System.Drawing.Point(55, 454);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(88, 58);
            this.NuevoButton.TabIndex = 16;
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
            this.GuardarButton.Location = new System.Drawing.Point(179, 454);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 58);
            this.GuardarButton.TabIndex = 17;
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
            this.EliminarButton.Location = new System.Drawing.Point(305, 454);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(88, 58);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = global::ReyfiBurguer.Properties.Resources.salir;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(27, 360);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(124, 33);
            this.RemoverButton.TabIndex = 19;
            this.RemoverButton.Text = "-Remover fila";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 522);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PrecioTotalComboTextBox);
            this.Controls.Add(this.ComboDataGridView);
            this.Controls.Add(this.ProductoComboBox);
            this.Controls.Add(this.NombreComboTextBox);
            this.Controls.Add(this.ComboIdNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rCombos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de combos";
            ((System.ComponentModel.ISupportInitialize)(this.ComboIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ComboIdNumericUpDown;
        private System.Windows.Forms.TextBox NombreComboTextBox;
        private System.Windows.Forms.ComboBox ProductoComboBox;
        private System.Windows.Forms.DataGridView ComboDataGridView;
        private System.Windows.Forms.TextBox PrecioTotalComboTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}