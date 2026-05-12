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

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            //atualizar a lista de usuários
            lboUsuarios.Items.Clear();
            UsuariosTableAdapter usuariosDados = new UsuariosTableAdapter();
            var dados = from linha in usuariosDados.GetData()
                        select linha;

            foreach (UsuariosRow dado in dados) lboUsuarios.Items.Add(dado);
        }

        private void LimparElementos()
        {
            // Limpa os TextBox do formulário
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void lboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;

            btnAcoes.Visible = false;
            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;

            //se o usuario selecionado for null retorna, caso contrário, preenche os TextBox com as informações do usuário selecionado
            if (usuario == null) return;
            
            btnAjustes.Text = "Atualizar";
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtTelefone.Text = usuario.Telefone;


        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            
            if (btnAjustes.Text == "Cadastrar")
            {
                // Cadastrar usuário
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
            if (txtNome.Text == "Atualizar")
            {

            }

            // ATUALIZAR
            // Atualizar usuário
            else if (btnAjustes.Text == "Atualizar")
            {
                // Verifica se existe item selecionado
                if (lboUsuarios.SelectedItem == null) return;

                UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;

                if (usuario == null) return;

                try
                {
                    UsuariosTableAdapter usuarios = new UsuariosTableAdapter();

                    // Atualiza os dados no banco
                    usuarios.Update(
                        usuario.UsuarioID,
                        txtNome.Text,
                        txtEmail.Text,
                        txtTelefone.Text
                    );

                    MessageBox.Show("Atualizado com sucesso!");

                    // Resetar tela
                    btnAjustes.Text = "Cadastrar";

                    LimparElementos();
                    AtualizarLista();
                    lboUsuarios.ClearSelected();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Filtrar a lista de usuários com base no texto digitado
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
            //atualizar usuário
            if (lboUsuarios.SelectedItem == null) return;

            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
            //se o usuario for null retorna
            if (usuario == null) return;
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Telefone = txtTelefone.Text;

            try
            {
                // Atualiza os dados no banco
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
            // Limpar seleção
            if (lboUsuarios.SelectedItem == null) return;
            lboUsuarios.ClearSelected();
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            AtualizarLista();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //excluindo usuário
            if (lboUsuarios.SelectedItem == null) return;
            UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
            //se o usuario for null retorna
            if (usuario == null) return;
            try
            {
                // Exclui o usuário do banco
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
