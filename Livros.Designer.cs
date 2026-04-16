namespace BibliotecaRemake
{
    partial class Livros
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
            this.txtAutor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbleditora = new System.Windows.Forms.Label();
            this.txtGenero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditora = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lboDados = new System.Windows.Forms.ListBox();
            this.txtISBN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtQuantidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnAcoes);
            this.panel1.Controls.Add(this.btnAjustes);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.lblPesquisa);
            this.panel1.Controls.Add(this.lblAutor);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.lbleditora);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEditora);
            this.panel1.Controls.Add(this.lboDados);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 475);
            this.panel1.TabIndex = 30;
            // 
            // txtAutor
            // 
            this.txtAutor.Depth = 0;
            this.txtAutor.Hint = "digite o Autor...";
            this.txtAutor.Location = new System.Drawing.Point(76, 187);
            this.txtAutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.SelectedText = "";
            this.txtAutor.SelectionLength = 0;
            this.txtAutor.SelectionStart = 0;
            this.txtAutor.Size = new System.Drawing.Size(236, 23);
            this.txtAutor.TabIndex = 22;
            this.txtAutor.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(73, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.Location = new System.Drawing.Point(395, 82);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(298, 26);
            this.txtPesquisa.TabIndex = 27;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(72, 115);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(67, 20);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Genero:";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.ForeColor = System.Drawing.Color.Black;
            this.lblPesquisa.Location = new System.Drawing.Point(391, 59);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(162, 20);
            this.lblPesquisa.TabIndex = 25;
            this.lblPesquisa.Text = "Pesquise por um livro:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.White;
            this.lblAutor.Location = new System.Drawing.Point(72, 164);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(52, 20);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Depth = 0;
            this.txtTitulo.Hint = "digite o Titulo...";
            this.txtTitulo.Location = new System.Drawing.Point(75, 95);
            this.txtTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.Size = new System.Drawing.Size(237, 23);
            this.txtTitulo.TabIndex = 24;
            this.txtTitulo.UseSystemPasswordChar = false;
            // 
            // lbleditora
            // 
            this.lbleditora.AutoSize = true;
            this.lbleditora.BackColor = System.Drawing.Color.Transparent;
            this.lbleditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditora.ForeColor = System.Drawing.Color.White;
            this.lbleditora.Location = new System.Drawing.Point(72, 213);
            this.lbleditora.Name = "lbleditora";
            this.lbleditora.Size = new System.Drawing.Size(64, 20);
            this.lbleditora.TabIndex = 7;
            this.lbleditora.Text = "Editora:";
            // 
            // txtGenero
            // 
            this.txtGenero.Depth = 0;
            this.txtGenero.Hint = "digite o Genero...";
            this.txtGenero.Location = new System.Drawing.Point(76, 138);
            this.txtGenero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.PasswordChar = '\0';
            this.txtGenero.SelectedText = "";
            this.txtGenero.SelectionLength = 0;
            this.txtGenero.SelectionStart = 0;
            this.txtGenero.Size = new System.Drawing.Size(236, 23);
            this.txtGenero.TabIndex = 23;
            this.txtGenero.UseSystemPasswordChar = false;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(72, 262);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(51, 20);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "ISBN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantidade:";
            // 
            // txtEditora
            // 
            this.txtEditora.Depth = 0;
            this.txtEditora.Hint = "digite a Editora...";
            this.txtEditora.Location = new System.Drawing.Point(75, 236);
            this.txtEditora.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.PasswordChar = '\0';
            this.txtEditora.SelectedText = "";
            this.txtEditora.SelectionLength = 0;
            this.txtEditora.SelectionStart = 0;
            this.txtEditora.Size = new System.Drawing.Size(237, 23);
            this.txtEditora.TabIndex = 21;
            this.txtEditora.UseSystemPasswordChar = false;
            // 
            // lboDados
            // 
            this.lboDados.FormattingEnabled = true;
            this.lboDados.Location = new System.Drawing.Point(395, 115);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(298, 290);
            this.lboDados.TabIndex = 14;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboDados_SelectedIndexChanged);
            // 
            // txtISBN
            // 
            this.txtISBN.Depth = 0;
            this.txtISBN.Hint = "digite o ISBN...";
            this.txtISBN.Location = new System.Drawing.Point(77, 285);
            this.txtISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.SelectedText = "";
            this.txtISBN.SelectionLength = 0;
            this.txtISBN.SelectionStart = 0;
            this.txtISBN.Size = new System.Drawing.Size(235, 23);
            this.txtISBN.TabIndex = 20;
            this.txtISBN.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.Hint = "digite a Quantidade...";
            this.txtQuantidade.Location = new System.Drawing.Point(76, 334);
            this.txtQuantidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.Size = new System.Drawing.Size(236, 23);
            this.txtQuantidade.TabIndex = 19;
            this.txtQuantidade.UseSystemPasswordChar = false;
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
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
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
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(547, 409);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(146, 33);
            this.btnRemover.TabIndex = 44;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "Livros";
            this.Size = new System.Drawing.Size(745, 481);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label lblAutor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo;
        private System.Windows.Forms.Label lbleditora;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGenero;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditora;
        private System.Windows.Forms.ListBox lboDados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtISBN;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnRemover;
    }
}
