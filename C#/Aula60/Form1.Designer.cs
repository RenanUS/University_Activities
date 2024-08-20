namespace Aula60
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
            Btn_Mãe = new Button();
            label1 = new Label();
            Lb_AAA = new Label();
            TB_ = new TextBox();
            SuspendLayout();
            // 
            // Btn_Mãe
            // 
            Btn_Mãe.BackColor = Color.RosyBrown;
            Btn_Mãe.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Mãe.ForeColor = Color.Black;
            Btn_Mãe.Location = new Point(12, 68);
            Btn_Mãe.Name = "Btn_Mãe";
            Btn_Mãe.Size = new Size(220, 57);
            Btn_Mãe.TabIndex = 0;
            Btn_Mãe.Text = "Mãe de jambis";
            Btn_Mãe.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // Lb_AAA
            // 
            Lb_AAA.AutoSize = true;
            Lb_AAA.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Lb_AAA.Location = new Point(12, 24);
            Lb_AAA.Name = "Lb_AAA";
            Lb_AAA.Size = new Size(132, 41);
            Lb_AAA.TabIndex = 2;
            Lb_AAA.Text = "AAAAAA";
            Lb_AAA.Click += AAAAAAA_Click;
            // 
            // TB_
            // 
            TB_.Location = new Point(12, 131);
            TB_.Name = "TB_";
            TB_.Size = new Size(216, 23);
            TB_.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TB_);
            Controls.Add(Lb_AAA);
            Controls.Add(label1);
            Controls.Add(Btn_Mãe);
            Name = "Form1";
            Text = "Curso de C#";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Mãe;
        private Label label1;
        private Label Lb_AAA;
        private TextBox TB_;
    }
}