namespace Aula62
{
    partial class F_FilhoCheckBox
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
            Cb_Ônibus = new CheckBox();
            Cb_Navio = new CheckBox();
            Cb_Avião = new CheckBox();
            Cb_Carro = new CheckBox();
            SuspendLayout();
            // 
            // Cb_Ônibus
            // 
            Cb_Ônibus.AutoSize = true;
            Cb_Ônibus.Location = new Point(12, 102);
            Cb_Ônibus.Name = "Cb_Ônibus";
            Cb_Ônibus.Size = new Size(77, 24);
            Cb_Ônibus.TabIndex = 7;
            Cb_Ônibus.Text = "Ônibus";
            Cb_Ônibus.UseVisualStyleBackColor = true;
            Cb_Ônibus.CheckedChanged += Cb_Ônibus_CheckedChanged;
            // 
            // Cb_Navio
            // 
            Cb_Navio.AutoSize = true;
            Cb_Navio.Location = new Point(12, 72);
            Cb_Navio.Name = "Cb_Navio";
            Cb_Navio.Size = new Size(70, 24);
            Cb_Navio.TabIndex = 6;
            Cb_Navio.Text = "Navio";
            Cb_Navio.UseVisualStyleBackColor = true;
            Cb_Navio.CheckedChanged += Cb_Navio_CheckedChanged;
            // 
            // Cb_Avião
            // 
            Cb_Avião.AutoSize = true;
            Cb_Avião.Location = new Point(12, 42);
            Cb_Avião.Name = "Cb_Avião";
            Cb_Avião.Size = new Size(69, 24);
            Cb_Avião.TabIndex = 5;
            Cb_Avião.Text = "Avião";
            Cb_Avião.UseVisualStyleBackColor = true;
            Cb_Avião.CheckedChanged += Cb_Avião_CheckedChanged;
            // 
            // Cb_Carro
            // 
            Cb_Carro.AutoSize = true;
            Cb_Carro.Location = new Point(12, 12);
            Cb_Carro.Name = "Cb_Carro";
            Cb_Carro.Size = new Size(67, 24);
            Cb_Carro.TabIndex = 4;
            Cb_Carro.Text = "Carro";
            Cb_Carro.UseVisualStyleBackColor = true;
            Cb_Carro.CheckedChanged += Cb_Carro_CheckedChanged;
            // 
            // F_FilhoCheckBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 264);
            Controls.Add(Cb_Ônibus);
            Controls.Add(Cb_Navio);
            Controls.Add(Cb_Avião);
            Controls.Add(Cb_Carro);
            Name = "F_FilhoCheckBox";
            Text = "F_FilhoCheckBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox Cb_Ônibus;
        private CheckBox Cb_Navio;
        private CheckBox Cb_Avião;
        private CheckBox Cb_Carro;
    }
}