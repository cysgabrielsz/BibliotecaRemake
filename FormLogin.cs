using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    public partial class FormLogin : Form
    {
        public bool saida;
        public FormLogin()
        {
            InitializeComponent();                     
        }

        private void llblSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {                        
            verificarUsuarioTableAdapter consulta = new verificarUsuarioTableAdapter();
            var usuario = (from linha in consulta.GetData(txtUsuario.Text, txtSenha.Text)
                           select linha).FirstOrDefault();
            if (usuario == null )
            {
                MessageBox.Show("O login está incorreto ou nao existe. \nVerificar com o suporte. ");
                return;
            }
            saida = true;
            Close();
        }   
    }
}
