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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telainicial));
            this.tp = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTelaPrincipal = new System.Windows.Forms.TabPage();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelBiblioteca = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new Siticone.Desktop.UI.WinForms.SiticoneButton();
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
            this.tabcontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.tpEmprestar = new System.Windows.Forms.TabPage();
            this.tpDevolver = new System.Windows.Forms.TabPage();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tp.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.panelBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpRequisicao.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tp.Controls.Add(this.tabPage1);
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
            this.panelBiblioteca.Controls.Add(this.pictureBox1);
            this.panelBiblioteca.Controls.Add(this.lblBiblioteca);
            this.panelBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.panelBiblioteca.Name = "panelBiblioteca";
            this.panelBiblioteca.Size = new System.Drawing.Size(915, 82);
            this.panelBiblioteca.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.ForeColor = System.Drawing.Color.White;
            this.lblBiblioteca.Location = new System.Drawing.Point(86, 22);
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
            this.btnInicio.Text = "🏠 Inicio";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
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
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 191);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(171, 45);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = " 🧍‍♂️ Usuarios";
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
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Location = new System.Drawing.Point(3, 242);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(171, 45);
            this.btnFuncionarios.TabIndex = 4;
            this.btnFuncionarios.Text = " 👨‍💻Funcionarios";
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
            this.btnEmprestimos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEmprestimos.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimos.Location = new System.Drawing.Point(3, 140);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(171, 45);
            this.btnEmprestimos.TabIndex = 3;
            this.btnEmprestimos.Text = "⇄ Emprestimos";
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
            this.btnLivros.Text = "📚 Livros";
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // tpErro
            // 
            this.tpErro.Location = new System.Drawing.Point(4, 22);
            this.tpErro.Name = "tpErro";
            this.tpErro.Padding = new System.Windows.Forms.Padding(3);
            this.tpErro.Size = new System.Drawing.Size(915, 566);
            this.tpErro.TabIndex = 1;
            this.tpErro.Text = "Erro";
            this.tpErro.UseVisualStyleBackColor = true;
            // 
            // tpUsuario
            // 
            this.tpUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuario.Size = new System.Drawing.Size(915, 566);
            this.tpUsuario.TabIndex = 2;
            this.tpUsuario.Text = "Usuario";
            this.tpUsuario.UseVisualStyleBackColor = true;
            // 
            // tpLivros
            // 
            this.tpLivros.Location = new System.Drawing.Point(4, 22);
            this.tpLivros.Name = "tpLivros";
            this.tpLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivros.Size = new System.Drawing.Size(915, 566);
            this.tpLivros.TabIndex = 3;
            this.tpLivros.Text = "Livros";
            this.tpLivros.UseVisualStyleBackColor = true;
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarios.Size = new System.Drawing.Size(915, 566);
            this.tpFuncionarios.TabIndex = 4;
            this.tpFuncionarios.Text = "Funcionarios";
            this.tpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tpRequisicao
            // 
            this.tpRequisicao.Controls.Add(this.tableLayoutPanel1);
            this.tpRequisicao.Location = new System.Drawing.Point(4, 22);
            this.tpRequisicao.Name = "tpRequisicao";
            this.tpRequisicao.Padding = new System.Windows.Forms.Padding(3);
            this.tpRequisicao.Size = new System.Drawing.Size(915, 566);
            this.tpRequisicao.TabIndex = 5;
            this.tpRequisicao.Text = "Requisicao";
            this.tpRequisicao.UseVisualStyleBackColor = true;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tpPrincipal);
            this.tabcontrol.Controls.Add(this.tpEmprestar);
            this.tabcontrol.Controls.Add(this.tpDevolver);
            this.tabcontrol.Controls.Add(this.tpConsultar);
            this.tabcontrol.Depth = 0;
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(3, 117);
            this.tabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(903, 440);
            this.tabcontrol.TabIndex = 0;
            this.tabcontrol.Tag = "";
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrincipal.Size = new System.Drawing.Size(895, 414);
            this.tpPrincipal.TabIndex = 0;
            this.tpPrincipal.Text = "Principal";
            this.tpPrincipal.UseVisualStyleBackColor = true;
            // 
            // tpEmprestar
            // 
            this.tpEmprestar.Location = new System.Drawing.Point(4, 22);
            this.tpEmprestar.Name = "tpEmprestar";
            this.tpEmprestar.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestar.Size = new System.Drawing.Size(901, 534);
            this.tpEmprestar.TabIndex = 1;
            this.tpEmprestar.Text = "Emprestar";
            this.tpEmprestar.UseVisualStyleBackColor = true;
            // 
            // tpDevolver
            // 
            this.tpDevolver.Location = new System.Drawing.Point(4, 22);
            this.tpDevolver.Name = "tpDevolver";
            this.tpDevolver.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolver.Size = new System.Drawing.Size(901, 534);
            this.tpDevolver.TabIndex = 2;
            this.tpDevolver.Text = "Devolver";
            this.tpDevolver.UseVisualStyleBackColor = true;
            // 
            // tpConsultar
            // 
            this.tpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultar.Size = new System.Drawing.Size(901, 534);
            this.tpConsultar.TabIndex = 3;
            this.tpConsultar.Text = "Consultar";
            this.tpConsultar.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 566);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabcontrol, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.35714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.64286F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 560);
            this.tableLayoutPanel1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpRequisicao.ResumeLayout(false);
            this.tabcontrol.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl tabcontrol;
        private System.Windows.Forms.TabPage tpPrincipal;
        private System.Windows.Forms.TabPage tpEmprestar;
        private System.Windows.Forms.TabPage tpDevolver;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

