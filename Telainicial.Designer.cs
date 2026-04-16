namespace BibliotecaRemake
{
    partial class Telainicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tp = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTelaPrincipal = new System.Windows.Forms.TabPage();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelBiblioteca = new System.Windows.Forms.Panel();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnUsuarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnFuncionarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEmprestimos = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnLivros = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tpErro = new System.Windows.Forms.TabPage();
            this.tpUsuario = new System.Windows.Forms.TabPage();
            this.tpLivros = new System.Windows.Forms.TabPage();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.tpRequisicao = new System.Windows.Forms.TabPage();
            this.btnInicio = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tp.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.panelBiblioteca.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp
            // 
            this.tp.Controls.Add(this.tpTelaPrincipal);
            this.tp.Controls.Add(this.tpErro);
            this.tp.Controls.Add(this.tpUsuario);
            this.tp.Controls.Add(this.tpLivros);
            this.tp.Controls.Add(this.tpFuncionarios);
            this.tp.Controls.Add(this.tpRequisicao);
            this.tp.Depth = 0;
            this.tp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tp.Location = new System.Drawing.Point(0, 0);
            this.tp.MouseState = MaterialSkin.MouseState.HOVER;
            this.tp.Name = "tp";
            this.tp.SelectedIndex = 0;
            this.tp.Size = new System.Drawing.Size(923, 592);
            this.tp.TabIndex = 0;
            // 
            // tpTelaPrincipal
            // 
            this.tpTelaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.tpTelaPrincipal.Controls.Add(this.panelConteudo);
            this.tpTelaPrincipal.Controls.Add(this.panelBiblioteca);
            this.tpTelaPrincipal.Controls.Add(this.panel1);
            this.tpTelaPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpTelaPrincipal.Name = "tpTelaPrincipal";
            this.tpTelaPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelaPrincipal.Size = new System.Drawing.Size(915, 566);
            this.tpTelaPrincipal.TabIndex = 0;
            this.tpTelaPrincipal.Text = "Tela Principal";
            // 
            // panelConteudo
            // 
            this.panelConteudo.Location = new System.Drawing.Point(190, 88);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(722, 475);
            this.panelConteudo.TabIndex = 5;
            // 
            // panelBiblioteca
            // 
            this.panelBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
            this.panelBiblioteca.Controls.Add(this.lblBiblioteca);
            this.panelBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.panelBiblioteca.Name = "panelBiblioteca";
            this.panelBiblioteca.Size = new System.Drawing.Size(915, 82);
            this.panelBiblioteca.TabIndex = 4;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.ForeColor = System.Drawing.Color.White;
            this.lblBiblioteca.Location = new System.Drawing.Point(31, 18);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(153, 40);
            this.lblBiblioteca.TabIndex = 6;
            this.lblBiblioteca.Text = "Biblioteca";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(145)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnFuncionarios);
            this.panel1.Controls.Add(this.btnEmprestimos);
            this.panel1.Controls.Add(this.btnLivros);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(8, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 290);
            this.panel1.TabIndex = 3;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(42, 1);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(91, 40);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Animated = true;
            this.btnUsuarios.AutoRoundedCorners = true;
            this.btnUsuarios.BorderRadius = 21;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 191);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(171, 45);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Animated = true;
            this.btnFuncionarios.AutoRoundedCorners = true;
            this.btnFuncionarios.BorderRadius = 21;
            this.btnFuncionarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFuncionarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFuncionarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Location = new System.Drawing.Point(3, 242);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(171, 45);
            this.btnFuncionarios.TabIndex = 4;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.Animated = true;
            this.btnEmprestimos.AutoRoundedCorners = true;
            this.btnEmprestimos.BorderRadius = 21;
            this.btnEmprestimos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmprestimos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmprestimos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmprestimos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmprestimos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.btnEmprestimos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimos.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimos.Location = new System.Drawing.Point(3, 140);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(171, 45);
            this.btnEmprestimos.TabIndex = 3;
            this.btnEmprestimos.Text = "Emprestimos";
            this.btnEmprestimos.Click += new System.EventHandler(this.btnEmprestimos_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.Animated = true;
            this.btnLivros.AutoRoundedCorners = true;
            this.btnLivros.BackColor = System.Drawing.Color.Transparent;
            this.btnLivros.BorderRadius = 21;
            this.btnLivros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLivros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLivros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLivros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLivros.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(3, 89);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(171, 45);
            this.btnLivros.TabIndex = 2;
            this.btnLivros.Text = "Livros";
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // tpErro
            // 
            this.tpErro.Location = new System.Drawing.Point(4, 22);
            this.tpErro.Name = "tpErro";
            this.tpErro.Padding = new System.Windows.Forms.Padding(3);
            this.tpErro.Size = new System.Drawing.Size(792, 424);
            this.tpErro.TabIndex = 1;
            this.tpErro.Text = "Erro";
            this.tpErro.UseVisualStyleBackColor = true;
            // 
            // tpUsuario
            // 
            this.tpUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuario.Size = new System.Drawing.Size(792, 424);
            this.tpUsuario.TabIndex = 2;
            this.tpUsuario.Text = "Usuario";
            this.tpUsuario.UseVisualStyleBackColor = true;
            // 
            // tpLivros
            // 
            this.tpLivros.Location = new System.Drawing.Point(4, 22);
            this.tpLivros.Name = "tpLivros";
            this.tpLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivros.Size = new System.Drawing.Size(792, 424);
            this.tpLivros.TabIndex = 3;
            this.tpLivros.Text = "Livros";
            this.tpLivros.UseVisualStyleBackColor = true;
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarios.Size = new System.Drawing.Size(792, 424);
            this.tpFuncionarios.TabIndex = 4;
            this.tpFuncionarios.Text = "Funcionarios";
            this.tpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tpRequisicao
            // 
            this.tpRequisicao.Location = new System.Drawing.Point(4, 22);
            this.tpRequisicao.Name = "tpRequisicao";
            this.tpRequisicao.Padding = new System.Windows.Forms.Padding(3);
            this.tpRequisicao.Size = new System.Drawing.Size(792, 424);
            this.tpRequisicao.TabIndex = 5;
            this.tpRequisicao.Text = "Requisicao";
            this.tpRequisicao.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Animated = true;
            this.btnInicio.AutoRoundedCorners = true;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BorderRadius = 21;
            this.btnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(3, 38);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(171, 45);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // Telainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 592);
            this.Controls.Add(this.tp);
            this.Name = "Telainicial";
            this.Text = "Form1";
            this.tp.ResumeLayout(false);
            this.tpTelaPrincipal.ResumeLayout(false);
            this.panelBiblioteca.ResumeLayout(false);
            this.panelBiblioteca.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tp;
        private System.Windows.Forms.TabPage tpTelaPrincipal;
        private System.Windows.Forms.TabPage tpErro;
        private System.Windows.Forms.TabPage tpUsuario;
        private System.Windows.Forms.TabPage tpLivros;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private System.Windows.Forms.TabPage tpRequisicao;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLivros;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEmprestimos;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnUsuarios;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFuncionarios;
        private System.Windows.Forms.Panel panelBiblioteca;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panelConteudo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnInicio;
    }
}

