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
    public partial class ucEmprestar : UserControl
    {
        public ucEmprestar()
        {
            InitializeComponent();
            // Sera removido no futuro
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var obterFuncionarios = from linha in funcionarios.GetData() select linha;
            foreach (var funcionario in obterFuncionarios)
            {
                cboFuncionarios.Items.Add(funcionario);
            }
            cboFuncionarios.SelectedIndex = -1;
            //Ate aq
            AtualizarLista();

        }

        private void AtualizarLista()
        {
            //trazendo os livros e usuarios para os listbox
            LivrosTableAdapter livros = new LivrosTableAdapter();
            var obterLivros = from linha in livros.GetData() select linha;
            foreach (var livro in obterLivros)
            {
                lboLivros.Items.Add(livro);
            }

            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var obterUsuarios = from linha in usuarios.GetData()
                                select linha;
            foreach (var usuario in obterUsuarios) lboUsuarios.Items.Add(usuario);

        }

        private void btnEmprestar_Click(object sender, EventArgs e)

        {
            // Verificando se os itens foram selecionados
            LivrosRow livroSelecionado = lboLivros.SelectedItem as LivrosRow;
            UsuariosRow usuarioSelecionado = lboUsuarios.SelectedItem as UsuariosRow;
            FuncionariosRow funcionarioSelecionado = cboFuncionarios.SelectedItem as FuncionariosRow;

            // Verificando se os itens foram selecionados
            if (usuarioSelecionado == null) return;
            else if (funcionarioSelecionado == null) return;
            else if (livroSelecionado == null) return;

            // Realizando o emprestimo
            QueriesTableAdapter consulta = new QueriesTableAdapter();
            consulta.EmprestarLivro(
                livroSelecionado.LivroID,
                funcionarioSelecionado.FuncionarioID,
                usuarioSelecionado.UsuarioID

            );
            // Limpando as seleções e atualizando as listas
            MessageBox.Show($"O emprestimo fico para ser devolvido no dia {DateTime.Now.AddDays(7)}");

        }

        private void txtLivros_TextChanged(object sender, EventArgs e)
        {
            // Verificando se o campo de pesquisa esta vazio
            TextBox pesquisa = sender as TextBox;
            if (pesquisa.Text == "")
            {                
                return;
            }
            lboLivros.ClearSelected();

            lboLivros.Items.Clear();
            // Realizando a pesquisa
            string textoDigitado = txtLivros.Text;
            LivrosTableAdapter dados = new LivrosTableAdapter();
            var livros = from linha in dados.GetData()
                         where linha.Titulo.ToLower().Contains(textoDigitado.ToLower())
                         select linha;
            foreach (var livro in livros) lboLivros.Items.Add(livro);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Verificando se o campo de pesquisa esta vazio
            TextBox pesquisa = sender as TextBox;
            if (pesquisa.Text == "") return;
            lboUsuarios.ClearSelected();
            lboUsuarios.Items.Clear();
            string textodigitado = txtUsuario.Text;
            UsuariosTableAdapter dados = new UsuariosTableAdapter();
            // Realizando a pesquisa
            var usuarios = (from linha in dados.GetData()
                            where linha.Nome.ToLower().Contains(textodigitado.ToLower()) 
                            select linha);
            foreach (var usuario in usuarios) lboUsuarios.Items.Add(usuario);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando as seleções e os campos de pesquisa
            lboLivros.ClearSelected();
            lboLivros.Items.Clear();
            lboUsuarios.ClearSelected();
            lboUsuarios.Items.Clear();
            cboFuncionarios.SelectedIndex = -1;
            txtLivros.Text = "";
            txtUsuario.Text = "";
            AtualizarLista();

        }
    }
}
