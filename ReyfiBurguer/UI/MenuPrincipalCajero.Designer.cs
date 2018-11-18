namespace ReyfiBurguer.UI.Registros
{
    partial class MenuPrincipalCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalCajero));
            this.IniciarCajaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IniciarCajaButton
            // 
            this.IniciarCajaButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IniciarCajaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarCajaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarCajaButton.Image = global::ReyfiBurguer.Properties.Resources.Stack_of_Money_100px;
            this.IniciarCajaButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IniciarCajaButton.Location = new System.Drawing.Point(53, 58);
            this.IniciarCajaButton.Name = "IniciarCajaButton";
            this.IniciarCajaButton.Size = new System.Drawing.Size(190, 133);
            this.IniciarCajaButton.TabIndex = 0;
            this.IniciarCajaButton.Text = "Iniciar caja";
            this.IniciarCajaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IniciarCajaButton.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipalCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReyfiBurguer.Properties.Resources.Logo;
            this.ClientSize = new System.Drawing.Size(298, 242);
            this.Controls.Add(this.IniciarCajaButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipalCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal (Cajero)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarCajaButton;
    }
}