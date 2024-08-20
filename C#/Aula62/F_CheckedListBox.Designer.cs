namespace Aula62
{
    partial class F_CheckedListBox
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
            Clb_Transportes = new CheckedListBox();
            Btn_MostrarSelecionados = new Button();
            Btn_LimparLista = new Button();
            Btn_ResetarLista = new Button();
            Btn_AddNovoTransporte = new Button();
            Tb_NovoTransporte = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Clb_Transportes
            // 
            Clb_Transportes.FormattingEnabled = true;
            Clb_Transportes.Items.AddRange(new object[] { "Carro", "Avião", "Navio", "Ônibus", "Trem" });
            Clb_Transportes.Location = new Point(12, 12);
            Clb_Transportes.Name = "Clb_Transportes";
            Clb_Transportes.Size = new Size(150, 422);
            Clb_Transportes.TabIndex = 0;
            // 
            // Btn_MostrarSelecionados
            // 
            Btn_MostrarSelecionados.Location = new Point(168, 12);
            Btn_MostrarSelecionados.Name = "Btn_MostrarSelecionados";
            Btn_MostrarSelecionados.Size = new Size(360, 30);
            Btn_MostrarSelecionados.TabIndex = 1;
            Btn_MostrarSelecionados.Text = "Mostras Selecionados";
            Btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            Btn_MostrarSelecionados.Click += Btn_MostrarSelecionados_Click;
            // 
            // Btn_LimparLista
            // 
            Btn_LimparLista.Location = new Point(168, 48);
            Btn_LimparLista.Name = "Btn_LimparLista";
            Btn_LimparLista.Size = new Size(360, 33);
            Btn_LimparLista.TabIndex = 2;
            Btn_LimparLista.Text = "Limpar Lista";
            Btn_LimparLista.UseVisualStyleBackColor = true;
            Btn_LimparLista.Click += Btn_LimparLista_Click;
            // 
            // Btn_ResetarLista
            // 
            Btn_ResetarLista.Location = new Point(168, 87);
            Btn_ResetarLista.Name = "Btn_ResetarLista";
            Btn_ResetarLista.Size = new Size(360, 31);
            Btn_ResetarLista.TabIndex = 3;
            Btn_ResetarLista.Text = "Resetar Lista";
            Btn_ResetarLista.UseVisualStyleBackColor = true;
            Btn_ResetarLista.Click += Btn_ResetarLista_Click;
            // 
            // Btn_AddNovoTransporte
            // 
            Btn_AddNovoTransporte.Location = new Point(168, 407);
            Btn_AddNovoTransporte.Name = "Btn_AddNovoTransporte";
            Btn_AddNovoTransporte.Size = new Size(360, 27);
            Btn_AddNovoTransporte.TabIndex = 4;
            Btn_AddNovoTransporte.Text = "Adicionar Novo Transporte";
            Btn_AddNovoTransporte.UseVisualStyleBackColor = true;
            Btn_AddNovoTransporte.Click += Btn_AddNovoTransporte_Click;
            // 
            // Tb_NovoTransporte
            // 
            Tb_NovoTransporte.Location = new Point(168, 374);
            Tb_NovoTransporte.Name = "Tb_NovoTransporte";
            Tb_NovoTransporte.Size = new Size(360, 27);
            Tb_NovoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 351);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 6;
            label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 441);
            Controls.Add(label1);
            Controls.Add(Tb_NovoTransporte);
            Controls.Add(Btn_AddNovoTransporte);
            Controls.Add(Btn_ResetarLista);
            Controls.Add(Btn_LimparLista);
            Controls.Add(Btn_MostrarSelecionados);
            Controls.Add(Clb_Transportes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_CheckedListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckedListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox Clb_Transportes;
        private Button Btn_MostrarSelecionados;
        private Button Btn_LimparLista;
        private Button Btn_ResetarLista;
        private Button Btn_AddNovoTransporte;
        private TextBox Tb_NovoTransporte;
        private Label label1;
    }
}