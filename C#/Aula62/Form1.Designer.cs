namespace Aula62
{
    partial class F_Principal
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
            Btn_Adicionar = new Button();
            Tb_Veículo = new TextBox();
            Lb_1 = new Label();
            Tb_ListaVeículos = new TextBox();
            Btn_Limpar = new Button();
            Btn_Mostrar = new Button();
            Btn_ValNum = new Button();
            menuStrip1 = new MenuStrip();
            conToolStripMenuItem = new ToolStripMenuItem();
            checkboxToolStripMenuItem = new ToolStripMenuItem();
            checkedLIToolStripMenuItem = new ToolStripMenuItem();
            comboBoxToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Adicionar
            // 
            Btn_Adicionar.Location = new Point(322, 82);
            Btn_Adicionar.Name = "Btn_Adicionar";
            Btn_Adicionar.Size = new Size(134, 29);
            Btn_Adicionar.TabIndex = 0;
            Btn_Adicionar.Text = "Adicionar";
            Btn_Adicionar.UseVisualStyleBackColor = true;
            Btn_Adicionar.Click += Btn_Adicionar_Click;
            // 
            // Tb_Veículo
            // 
            Tb_Veículo.Location = new Point(12, 85);
            Tb_Veículo.Name = "Tb_Veículo";
            Tb_Veículo.Size = new Size(300, 27);
            Tb_Veículo.TabIndex = 1;
            // 
            // Lb_1
            // 
            Lb_1.AutoSize = true;
            Lb_1.Location = new Point(12, 62);
            Lb_1.Name = "Lb_1";
            Lb_1.Size = new Size(126, 20);
            Lb_1.TabIndex = 2;
            Lb_1.Text = "Digite um veículo";
            // 
            // Tb_ListaVeículos
            // 
            Tb_ListaVeículos.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Tb_ListaVeículos.Location = new Point(12, 118);
            Tb_ListaVeículos.Multiline = true;
            Tb_ListaVeículos.Name = "Tb_ListaVeículos";
            Tb_ListaVeículos.ReadOnly = true;
            Tb_ListaVeículos.Size = new Size(443, 500);
            Tb_ListaVeículos.TabIndex = 3;
            Tb_ListaVeículos.TextChanged += textBox2_TextChanged;
            // 
            // Btn_Limpar
            // 
            Btn_Limpar.Location = new Point(12, 624);
            Btn_Limpar.Name = "Btn_Limpar";
            Btn_Limpar.Size = new Size(443, 29);
            Btn_Limpar.TabIndex = 4;
            Btn_Limpar.Text = "Limpar";
            Btn_Limpar.UseVisualStyleBackColor = true;
            Btn_Limpar.Click += Btn_Limpar_Click;
            // 
            // Btn_Mostrar
            // 
            Btn_Mostrar.Location = new Point(12, 669);
            Btn_Mostrar.Name = "Btn_Mostrar";
            Btn_Mostrar.Size = new Size(443, 29);
            Btn_Mostrar.TabIndex = 5;
            Btn_Mostrar.Text = "Mostrar Veículos";
            Btn_Mostrar.UseVisualStyleBackColor = true;
            Btn_Mostrar.Click += Btn_Mostrar_Click;
            // 
            // Btn_ValNum
            // 
            Btn_ValNum.Location = new Point(12, 719);
            Btn_ValNum.Name = "Btn_ValNum";
            Btn_ValNum.Size = new Size(443, 29);
            Btn_ValNum.TabIndex = 6;
            Btn_ValNum.Text = "Valor da variável num";
            Btn_ValNum.UseVisualStyleBackColor = true;
            Btn_ValNum.Click += Btn_ValNum_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { conToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(468, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // conToolStripMenuItem
            // 
            conToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkboxToolStripMenuItem, checkedLIToolStripMenuItem, comboBoxToolStripMenuItem });
            conToolStripMenuItem.Name = "conToolStripMenuItem";
            conToolStripMenuItem.Size = new Size(115, 24);
            conToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            checkboxToolStripMenuItem.Size = new Size(224, 26);
            checkboxToolStripMenuItem.Text = "Checkbox";
            checkboxToolStripMenuItem.Click += checkboxToolStripMenuItem_Click;
            // 
            // checkedLIToolStripMenuItem
            // 
            checkedLIToolStripMenuItem.Name = "checkedLIToolStripMenuItem";
            checkedLIToolStripMenuItem.Size = new Size(224, 26);
            checkedLIToolStripMenuItem.Text = "CheckedListBox";
            checkedLIToolStripMenuItem.Click += checkedLIToolStripMenuItem_Click;
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(224, 26);
            comboBoxToolStripMenuItem.Text = "ComboBox";
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 753);
            Controls.Add(Btn_ValNum);
            Controls.Add(Btn_Mostrar);
            Controls.Add(Btn_Limpar);
            Controls.Add(Tb_ListaVeículos);
            Controls.Add(Lb_1);
            Controls.Add(Tb_Veículo);
            Controls.Add(Btn_Adicionar);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "F_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Componentes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Adicionar;
        private TextBox Tb_Veículo;
        private Label Lb_1;
        private Button Btn_Limpar;
        private Button Btn_Mostrar;
        private Button Btn_ValNum;
        public TextBox Tb_ListaVeículos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conToolStripMenuItem;
        private ToolStripMenuItem checkboxToolStripMenuItem;
        private ToolStripMenuItem checkedLIToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
    }
}