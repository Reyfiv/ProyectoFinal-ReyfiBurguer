namespace ReyfiBurguer.UI.Consultas
{
    partial class cVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cVentas));
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.FechaDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaHastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "Todos",
            "Fecha",
            "Total"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(14, 47);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltrarComboBox.TabIndex = 27;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(162, 47);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(235, 23);
            this.CriterioTextBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Criterio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Filtrar";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(13, 128);
            this.ConsultaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.ReadOnly = true;
            this.ConsultaDataGridView.Size = new System.Drawing.Size(496, 272);
            this.ConsultaDataGridView.TabIndex = 23;
            // 
            // FechaDesdeDateTimePicker
            // 
            this.FechaDesdeDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaDesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDesdeDateTimePicker.Location = new System.Drawing.Point(90, 88);
            this.FechaDesdeDateTimePicker.Name = "FechaDesdeDateTimePicker";
            this.FechaDesdeDateTimePicker.Size = new System.Drawing.Size(96, 23);
            this.FechaDesdeDateTimePicker.TabIndex = 29;
            // 
            // FechaHastaDateTimePicker
            // 
            this.FechaHastaDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaHastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaHastaDateTimePicker.Location = new System.Drawing.Point(305, 88);
            this.FechaHastaDateTimePicker.Name = "FechaHastaDateTimePicker";
            this.FechaHastaDateTimePicker.Size = new System.Drawing.Size(92, 23);
            this.FechaHastaDateTimePicker.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Hasta";
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImprimirButton.Image = global::ReyfiBurguer.Properties.Resources.Print_32px;
            this.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImprimirButton.Location = new System.Drawing.Point(14, 407);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(107, 49);
            this.ImprimirButton.TabIndex = 33;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.Image = global::ReyfiBurguer.Properties.Resources.Search_25px;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(424, 40);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(85, 36);
            this.BuscarButton.TabIndex = 28;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // cVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 465);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaHastaDateTimePicker);
            this.Controls.Add(this.FechaDesdeDateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FiltrarComboBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.DateTimePicker FechaDesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaHastaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ImprimirButton;
    }
}