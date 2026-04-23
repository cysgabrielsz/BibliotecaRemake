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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BibliotecaRemake
{
    public partial class Funcionarios : UserControl
    {
        public Funcionarios()
        {
            InitializeComponent();            
            FuncionariosTableAdapter funcionario = new FuncionariosTableAdapter();
            var dados = from linha in funcionario.GetData()
                        select linha;
            foreach (var linha in dados)
            {
                lboFuncionarios.Items.Add(linha);
            }
            AtualizarLista();
            txtSenha.Visible = false;
            lblSenha.Visible = false;
        }

        private void AtualizarLista()
        {
            lboFuncionarios.Items.Clear();
            FuncionariosTableAdapter funcionariosDados = new FuncionariosTableAdapter();
            var dados = from linha in funcionariosDados.GetData()
                        select linha;

            foreach (FuncionariosRow dado in dados) lboFuncionarios.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtUsuarios.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCargo.Text = "";
            txtPesquisa.Text = "";
            cbAtivo.Checked = false;
        }

        private void lboFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboFuncionarios.SelectedItem == null) return;

            FuncionariosRow funcionario = lboFuncionarios.SelectedItem as FuncionariosRow;

            if (funcionario == null) return;    
            txtUsuarios.Text = funcionario.NomeUsuario;
            txtSenha.Text = funcionario.SenhaHash;
            txtNome.Text = funcionario.NomeCompleto;
            txtEmail.Text = funcionario.Email;
            txtCargo.Text = funcionario.Cargo;
            cbAtivo.Checked = funcionario.Ativo;
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            if (btnAjustes.Text == "Cadastrar")
            {
                string usuario = txtUsuarios.Text;
                string senha = txtSenha.Text;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string cargo = txtCargo.Text;
                bool ativo = cbAtivo.Checked ? true : false;

                try
                {
                    FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                    funcionarios.Insert(usuario, senha, nome, cargo, email, DateTime.Now, ativo);  
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
            lboFuncionarios.Items.Clear();
            if (txtPesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            string textoDigitado = txtPesquisa.Text;
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var dados = from linha in funcionarios.GetData()
                        where linha.NomeCompleto.ToLower().Contains(textoDigitado.ToLower())
                        select linha;
            foreach (var funcionario in dados) lboFuncionarios.Items.Add(funcionario);
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (lboFuncionarios.SelectedItem == null) return;

            FuncionariosRow funcionario = lboFuncionarios.SelectedItem as FuncionariosRow;
            if (funcionario == null) return;
            funcionario.NomeUsuario = txtUsuarios.Text;
            funcionario.SenhaHash = txtSenha.Text;
            funcionario.NomeCompleto = txtNome.Text;            
            funcionario.Cargo = txtCargo.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Ativo = cbAtivo.Checked ? true : false;
            try
            {
                FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                funcionarios.Update(funcionario.FuncionarioID, funcionario.NomeUsuario, funcionario.SenhaHash, funcionario.NomeCompleto, funcionario.Cargo, funcionario.Email, DateTime.Now, funcionario.Ativo);
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Funcionario");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lboFuncionarios.SelectedItem == null) return;
            FuncionariosRow funcionario = lboFuncionarios.SelectedItem as FuncionariosRow;
            if (funcionario == null) return;
            try
            {
                FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                funcionarios.Delete(funcionario.FuncionarioID);
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover Funcionario");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (lboFuncionarios.SelectedItem == null) return;
            lboFuncionarios.ClearSelected();
            txtUsuarios.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCargo.Text = "";
            txtPesquisa.Text = "";
            cbAtivo.Checked = false;
            AtualizarLista();
        }
    }
}
