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
    public partial class ucDevolver : UserControl
    {
        public ucDevolver()
        {
            InitializeComponent();            
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            //limpa os itens atuais para evitar duplicação
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();            
            var obterFuncionarios = from linha in funcionarios.GetData() select linha;
            foreach (var funcionario in obterFuncionarios)
            {
                cboFuncionarios.Items.Add(funcionario);
            }
            cboFuncionarios.SelectedIndex = -1;

            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            lboPendencia.Items.Clear();
            foreach (var requisicao in requisicoes.GetData())
            {
                if (requisicao.Status == null || requisicao.Status != "Devolvido")
                {
                    lboPendencia.Items.Add(requisicao);
                }
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            // Verifica se um funcionário e uma requisição foram selecionados
            if (cboFuncionarios.SelectedIndex == -1 || lboPendencia.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma requisição e um funcionário para processar a devolução.");
                return;
            }
            // Obtém a requisição e o funcionário selecionados
            RequisicoesRow requisicaoSelecionada = lboPendencia.SelectedItem as RequisicoesRow;
            FuncionariosRow funcionarioSelecionado = cboFuncionarios.SelectedItem as FuncionariosRow;
             if (requisicaoSelecionada == null || funcionarioSelecionado == null) return;
            QueriesTableAdapter consulta = new QueriesTableAdapter();
            consulta.DevolverLivro(requisicaoSelecionada.RequisicaoID, funcionarioSelecionado.FuncionarioID);
                MessageBox.Show("Livro devolvido com sucesso!");
                AtualizarLista();
        }

    }
}
