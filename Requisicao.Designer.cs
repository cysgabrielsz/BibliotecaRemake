namespace BibliotecaRemake
{
    partial class Requisicao
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lboEmprestimos = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.lboEmprestimos);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnAcoes);
            this.panel1.Controls.Add(this.btnAjustes);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 475);
            this.panel1.TabIndex = 32;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(547, 409);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(146, 33);
            this.btnRemover.TabIndex = 43;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "digite o Nome...";
            this.txtNome.Location = new System.Drawing.Point(73, 192);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(237, 23);
            this.txtNome.TabIndex = 36;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(69, 169);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(69, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "digite o Email...";
            this.txtEmail.Location = new System.Drawing.Point(73, 241);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(237, 23);
            this.txtEmail.TabIndex = 38;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Hint = "digite o Telefone...";
            this.txtTelefone.Location = new System.Drawing.Point(73, 290);
            this.txtTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.Size = new System.Drawing.Size(237, 23);
            this.txtTelefone.TabIndex = 39;
            this.txtTelefone.UseSystemPasswordChar = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(69, 267);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 40;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lboEmprestimos
            // 
            this.lboEmprestimos.FormattingEnabled = true;
            this.lboEmprestimos.Location = new System.Drawing.Point(395, 115);
            this.lboEmprestimos.Name = "lboEmprestimos";
            this.lboEmprestimos.Size = new System.Drawing.Size(298, 277);
            this.lboEmprestimos.TabIndex = 34;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(395, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 33);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "limpar selecao";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnAcoes
            // 
            this.btnAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
            this.btnAcoes.ForeColor = System.Drawing.Color.White;
            this.btnAcoes.Location = new System.Drawing.Point(208, 409);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(127, 33);
            this.btnAcoes.TabIndex = 31;
            this.btnAcoes.Text = "Atualizar lista";
            this.btnAcoes.UseVisualStyleBackColor = false;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(53, 409);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(128, 33);
            this.btnAjustes.TabIndex = 30;
            this.btnAjustes.Text = "Cadastrar";
            this.btnAjustes.UseVisualStyleBackColor = false;
            // 
            // Requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Requisicao";
            this.Size = new System.Drawing.Size(723, 474);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemover;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ListBox lboEmprestimos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnAjustes;
    }
}
