namespace Aula61
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tb_1 = new TextBox();
            Btn_OK = new Button();
            Lb_nome = new Label();
            SuspendLayout();
            // 
            // Tb_1
            // 
            Tb_1.Location = new Point(30, 24);
            Tb_1.Name = "Tb_1";
            Tb_1.Size = new Size(249, 27);
            Tb_1.TabIndex = 0;
            // 
            // Btn_OK
            // 
            Btn_OK.BackColor = Color.Black;
            Btn_OK.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_OK.ForeColor = Color.FromArgb(192, 0, 0);
            Btn_OK.Location = new Point(30, 71);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(249, 74);
            Btn_OK.TabIndex = 1;
            Btn_OK.Text = "OK";
            Btn_OK.UseVisualStyleBackColor = false;
            Btn_OK.Click += Btn_OK_Click;
            // 
            // Lb_nome
            // 
            Lb_nome.AutoSize = true;
            Lb_nome.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_nome.Location = new Point(30, 162);
            Lb_nome.Name = "Lb_nome";
            Lb_nome.Size = new Size(249, 35);
            Lb_nome.TabIndex = 2;
            Lb_nome.Text = "AAAAAAAAAAAAA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 789);
            Controls.Add(Lb_nome);
            Controls.Add(Btn_OK);
            Controls.Add(Tb_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tb_1;
        private Button Btn_OK;
        private Label Lb_nome;
    }
}