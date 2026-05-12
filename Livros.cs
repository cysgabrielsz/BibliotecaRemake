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
    public partial class Livros : UserControl
    {
        public Livros()
        {
            InitializeComponent();
            AtualizarLista();
        }

        // Atualiza a ListBox com os livros do banco
        private void AtualizarLista()
        {
            lboDados.Items.Clear();
            LivrosTableAdapter LivrosDados = new LivrosTableAdapter();
            var dados = from linha in LivrosDados.GetData()
                        select linha;

            foreach (LivrosRow dado in dados) lboDados.Items.Add(dado);
        }

        // Limpa os TextBox do formulário       
        private void LimparElementos()
        {
            txtTitulo.Text = "";
            txtGenero.Text = "";
            txtAutor.Text = "";
            txtEditora.Text = "";
            txtISBN.Text = "";
            txtQuantidade.Text = "";
        }

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sai se nada estiver selecionado
            if (lboDados.SelectedItem == null) return;

            LivrosRow livro = lboDados.SelectedItem as LivrosRow;

            if (livro == null) return;

            // Muda os botões para modo edição
            btnAcoes.Text = "Excluir";
            btnAjustes.Text = "Atualizar";
            // Preenche os campos com os dados do livro
            txtTitulo.Text = livro.Titulo;
            txtGenero.Text = livro.Genero;
            txtAutor.Text = livro.Autor;
            txtEditora.Text = livro.Editora;
            txtISBN.Text = livro.ISBN;
            txtQuantidade.Text = livro.QuantidadeDisponivel.ToString();
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboDados.SelectedItem == null) return;
                LivrosRow livro = lboDados.SelectedItem as LivrosRow;
                if (livro == null) return;
                // Exclui o livro do banco
                LivrosTableAdapter livros = new LivrosTableAdapter();
                livros.Delete(livro.LivroID);
                // Atualiza a lista e limpa os campos
                AtualizarLista();
              
                LimparElementos();

                btnAcoes.Text = "Atualizar Lista";
                btnAjustes.Text = "Cadastrar";
            }
        }

        //limpar seleção
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboDados.ClearSelected();
            AtualizarLista();
            LimparElementos();
            btnAcoes.Text = "Atualizar Lista";
            btnAjustes.Text = "Cadastrar";
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            if (btnAjustes.Text == "Cadastrar")
            {
                //dando insert nos itens
                string titulo = txtTitulo.Text;
                string genero = txtGenero.Text;
                string autor = txtAutor.Text;
                string editora = txtEditora.Text;
                string isbn = txtISBN.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Insert(titulo, genero, autor, editora, isbn, quantidade);
                    LimparElementos();
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Coloca numero", "Erro de digitação");

                }
            }
            if(txtTitulo.Text == "Atualizar")
            {

            }

            // ATUALIZAR
            else if (btnAjustes.Text == "Atualizar")
            {
                if (lboDados.SelectedItem == null) return;

                LivrosRow livro = lboDados.SelectedItem as LivrosRow;
                if (livro == null) return;

                try
                {
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Update(
                        livro.LivroID,
                        txtTitulo.Text,
                        txtAutor.Text,
                        txtGenero.Text,
                        txtEditora.Text,
                        txtISBN.Text,
                        int.Parse(txtQuantidade.Text)
                    ); LimparElementos();

                    MessageBox.Show("Atualizado com sucesso!");

                    btnAjustes.Text = "Cadastrar";

                    LimparElementos();
                    AtualizarLista();
                    lboDados.ClearSelected();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //pesquisa
            TextBox pesquisa = sender as TextBox;
            if (pesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }
            lboDados.ClearSelected();

            lboDados.Items.Clear();
            string textoDigitado = txtPesquisa.Text;
            LivrosTableAdapter dados = new LivrosTableAdapter();
            var livros = from linha in dados.GetData()
                         where linha.Titulo.ToLower().Contains(textoDigitado.ToLower())
                         select linha;
            foreach (var livro in livros) lboDados.Items.Add(livro);
        }




    }
}
