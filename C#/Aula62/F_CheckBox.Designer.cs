namespace Aula62
{
    partial class F_CheckBox
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
            Cb_Carro = new CheckBox();
            Cb_Avião = new CheckBox();
            Cb_Navio = new CheckBox();
            Cb_Ônibus = new CheckBox();
            Btn_Transportes = new Button();
            Cb_Patinete = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Cb_Carro
            // 
            Cb_Carro.AutoSize = true;
            Cb_Carro.Location = new Point(12, 12);
            Cb_Carro.Name = "Cb_Carro";
            Cb_Carro.Size = new Size(67, 24);
            Cb_Carro.TabIndex = 0;
            Cb_Carro.Text = "Carro";
            Cb_Carro.UseVisualStyleBackColor = true;
            // 
            // Cb_Avião
            // 
            Cb_Avião.AutoSize = true;
            Cb_Avião.Location = new Point(12, 42);
            Cb_Avião.Name = "Cb_Avião";
            Cb_Avião.Size = new Size(69, 24);
            Cb_Avião.TabIndex = 1;
            Cb_Avião.Text = "Avião";
            Cb_Avião.UseVisualStyleBackColor = true;
            // 
            // Cb_Navio
            // 
            Cb_Navio.AutoSize = true;
            Cb_Navio.Location = new Point(12, 72);
            Cb_Navio.Name = "Cb_Navio";
            Cb_Navio.Size = new Size(70, 24);
            Cb_Navio.TabIndex = 2;
            Cb_Navio.Text = "Navio";
            Cb_Navio.UseVisualStyleBackColor = true;
            // 
            // Cb_Ônibus
            // 
            Cb_Ônibus.AutoSize = true;
            Cb_Ônibus.Location = new Point(12, 102);
            Cb_Ônibus.Name = "Cb_Ônibus";
            Cb_Ônibus.Size = new Size(77, 24);
            Cb_Ônibus.TabIndex = 3;
            Cb_Ônibus.Text = "Ônibus";
            Cb_Ônibus.UseVisualStyleBackColor = true;
            // 
            // Btn_Transportes
            // 
            Btn_Transportes.Location = new Point(181, 9);
            Btn_Transportes.Name = "Btn_Transportes";
            Btn_Transportes.Size = new Size(343, 29);
            Btn_Transportes.TabIndex = 4;
            Btn_Transportes.Text = "Transportes marcados";
            Btn_Transportes.UseVisualStyleBackColor = true;
            Btn_Transportes.Click += Btn_Transportes_Click;
            // 
            // Cb_Patinete
            // 
            Cb_Patinete.AutoSize = true;
            Cb_Patinete.Location = new Point(12, 206);
            Cb_Patinete.Name = "Cb_Patinete";
            Cb_Patinete.Size = new Size(84, 24);
            Cb_Patinete.TabIndex = 5;
            Cb_Patinete.Text = "Patinete";
            Cb_Patinete.UseVisualStyleBackColor = true;
            Cb_Patinete.CheckedChanged += Cb_Patinete_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(181, 44);
            button1.Name = "button1";
            button1.Size = new Size(343, 29);
            button1.TabIndex = 6;
            button1.Text = "Abrir formulário filho";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // F_CheckBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 565);
            Controls.Add(button1);
            Controls.Add(Cb_Patinete);
            Controls.Add(Btn_Transportes);
            Controls.Add(Cb_Ônibus);
            Controls.Add(Cb_Navio);
            Controls.Add(Cb_Avião);
            Controls.Add(Cb_Carro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_CheckBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Btn_Transportes;
        private CheckBox Cb_Patinete;
        public CheckBox Cb_Carro;
        public CheckBox Cb_Avião;
        public CheckBox Cb_Navio;
        public CheckBox Cb_Ônibus;
        private Button button1;
    }
}