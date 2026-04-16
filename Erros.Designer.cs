namespace BibliotecaRemake
{
    partial class Erros
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
            this.tpErro = new System.Windows.Forms.TableLayoutPanel();
            this.lblErro = new MaterialSkin.Controls.MaterialLabel();
            this.btnErro = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.tpErro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tpErro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 376);
            this.panel1.TabIndex = 0;
            // 
            // tpErro
            // 
            this.tpErro.ColumnCount = 1;
            this.tpErro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpErro.Controls.Add(this.lblErro, 0, 0);
            this.tpErro.Controls.Add(this.btnErro, 0, 1);
            this.tpErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpErro.Location = new System.Drawing.Point(0, 0);
            this.tpErro.Name = "tpErro";
            this.tpErro.RowCount = 2;
            this.tpErro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpErro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpErro.Size = new System.Drawing.Size(508, 376);
            this.tpErro.TabIndex = 0;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblErro.Depth = 0;
            this.lblErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.White;
            this.lblErro.Location = new System.Drawing.Point(3, 0);
            this.lblErro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(502, 188);
            this.lblErro.TabIndex = 0;
            this.lblErro.Text = "materialLabel1";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnErro
            // 
            this.btnErro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnErro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnErro.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErro.ForeColor = System.Drawing.Color.White;
            this.btnErro.Location = new System.Drawing.Point(3, 191);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(502, 182);
            this.btnErro.TabIndex = 1;
            this.btnErro.Text = "Voltar";
            // 
            // Erros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Erros";
            this.Size = new System.Drawing.Size(508, 376);
            this.panel1.ResumeLayout(false);
            this.tpErro.ResumeLayout(false);
            this.tpErro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tpErro;
        private MaterialSkin.Controls.MaterialLabel lblErro;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnErro;
    }
}
