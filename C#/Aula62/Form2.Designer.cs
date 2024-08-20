namespace Aula62
{
    partial class Form2
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
            Tb_ListaVeículos = new TextBox();
            SuspendLayout();
            // 
            // Tb_ListaVeículos
            // 
            Tb_ListaVeículos.Location = new Point(12, 12);
            Tb_ListaVeículos.Multiline = true;
            Tb_ListaVeículos.Name = "Tb_ListaVeículos";
            Tb_ListaVeículos.Size = new Size(429, 668);
            Tb_ListaVeículos.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 692);
            Controls.Add(Tb_ListaVeículos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Veículos";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tb_ListaVeículos;
    }
}