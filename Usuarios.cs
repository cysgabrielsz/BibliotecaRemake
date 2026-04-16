using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaRemake.BibliotecaDBDataSet;

namespace BibliotecaRemake
{
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
            UsuariosTableAdapter usuario = new UsuariosTableAdapter();
            var dados = from linha in usuario.GetData()
                        select linha;
            foreach (var linha in dados)
            {
                lboUsuarios.Items.Add(linha);
            }

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lboUsuarios.Items.Clear();
            UsuariosTableAdapter usuariosDados = new UsuariosTableAdapter();
            var dados = from linha in usuariosDados.GetData()
                        select linha;

            foreach (UsuariosRow dado in dados) lboUsuarios.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void lboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;

            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;

            if (usuario == null) return;

            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtTelefone.Text = usuario.Telefone;
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            if (btnAjustes.Text == "Cadastrar")
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                try
                {
                    UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                    usuarios.Insert(nome, email, telefone);
                    LimparElementos();
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de digitação");

                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lboUsuarios.Items.Clear();
            if (txtPesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            string textoDigitado = txtPesquisa.Text;
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var dados = from linha in usuarios.GetData()
                        where linha.Nome.ToLower().Contains(textoDigitado.ToLower())
                        select linha;
            foreach (var usuario in dados) lboUsuarios.Items.Add(usuario);
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;

            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
            if (usuario == null) return;
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Telefone = txtTelefone.Text;

            try
            {
                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                usuarios.Update(usuario.UsuarioID, usuario.Nome, usuario.Email, usuario.Telefone);
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar usuário");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;
            lboUsuarios.ClearSelected();
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            AtualizarLista();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;
            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
            if (usuario == null) return;
            try
            {
                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                usuarios.Delete(usuario.UsuarioID);
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover usuário");
            }
        }
    }
}
