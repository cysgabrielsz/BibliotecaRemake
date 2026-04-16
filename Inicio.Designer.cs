namespace BibliotecaRemake
{
    partial class Inicio
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
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblMensagens = new System.Windows.Forms.ListBox();
            this.lblLivros = new System.Windows.Forms.ListBox();
            this.panelConteudo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.panelConteudo.Controls.Add(this.lblMensagem);
            this.panelConteudo.Controls.Add(this.panel2);
            this.panelConteudo.Controls.Add(this.lblBiblioteca);
            this.panelConteudo.Controls.Add(this.panel1);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(725, 476);
            this.panelConteudo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(145)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.lblLivros);
            this.panel1.Location = new System.Drawing.Point(365, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 292);
            this.panel1.TabIndex = 0;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.ForeColor = System.Drawing.Color.White;
            this.lblBiblioteca.Location = new System.Drawing.Point(386, 70);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(276, 40);
            this.lblBiblioteca.TabIndex = 7;
            this.lblBiblioteca.Text = "Livros do Momento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(145)))), ((int)(((byte)(110)))));
            this.panel2.Controls.Add(this.lblMensagens);
            this.panel2.Location = new System.Drawing.Point(23, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 292);
            this.panel2.TabIndex = 1;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(79, 70);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(166, 40);
            this.lblMensagem.TabIndex = 8;
            this.lblMensagem.Text = "Mensagens";
            // 
            // lblMensagens
            // 
            this.lblMensagens.FormattingEnabled = true;
            this.lblMensagens.Location = new System.Drawing.Point(23, 23);
            this.lblMensagens.Name = "lblMensagens";
            this.lblMensagens.Size = new System.Drawing.Size(277, 251);
            this.lblMensagens.TabIndex = 0;
            // 
            // lblLivros
            // 
            this.lblLivros.FormattingEnabled = true;
            this.lblLivros.Location = new System.Drawing.Point(20, 23);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(277, 251);
            this.lblLivros.TabIndex = 1;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelConteudo);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(725, 476);
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lblMensagens;
        private System.Windows.Forms.ListBox lblLivros;
    }
}
