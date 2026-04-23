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
            cboFuncionarios.SelectedIndex = 0;
            //Ate aq
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
            LivrosRow livroSelecionado = lboLivros.SelectedItem as LivrosRow;
            UsuariosRow usuarioSelecionado = lboUsuarios.SelectedItem as UsuariosRow;
            FuncionariosRow funcionarioSelecionado = cboFuncionarios.SelectedItem as FuncionariosRow;

            if (usuarioSelecionado == null) return;
            else if (funcionarioSelecionado == null) return;
            else if (livroSelecionado == null) return;

            QueriesTableAdapter consulta = new QueriesTableAdapter();
            consulta.EmprestarLivro(
                livroSelecionado.LivroID,
                funcionarioSelecionado.FuncionarioID,
                usuarioSelecionado.UsuarioID

            );
            MessageBox.Show($"O emprestimo fico para ser devolvido no dia {DateTime.Now.AddDays(7)}");

        }

    }
}
