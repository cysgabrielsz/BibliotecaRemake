using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    public partial class Telainicial : Form
    {
        private Erros erros;
        private Livros livros;
        private Requisicao emprestimos;
        private Funcionarios funcionarios;
        private Usuarios usuarios;
        public Telainicial()
        {
            InitializeComponent();
            erros = new Erros();
            erros.Dock = DockStyle.Fill;  
            tpErro.Controls.Add(erros);
            erros.Controls.Find("btnErro", true).First().Click += VoltarTelaPrincipal;
            //localiza o botão 'btnErro', verfifca se existe, se existir retorna o primeiro e adiciona a função de clique 

            livros = new Livros();
            tpLivros.Controls.Add(livros);

            emprestimos = new Requisicao();
            tpRequisicao.Controls.Add(emprestimos);

            funcionarios = new Funcionarios();
            tpFuncionarios.Controls.Add(funcionarios);

            usuarios = new Usuarios();
            tpUsuario.Controls.Add(usuarios);


        }       

        private void VoltarTelaPrincipal(object quemchama, EventArgs evento)
        {
            tp.SelectTab(tpTelaPrincipal);
        }        

        private void btnLivros_Click(object sender, EventArgs e)
        {
            //abre tela de livros
            Livros livros = new Livros();
            AbrirTela(livros);
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            //abre tela de emprestimos
            Requisicao emprestimos = new Requisicao();
            AbrirTela(emprestimos);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            //abre tela de funcionarios
            Funcionarios funcionarios = new Funcionarios();
            AbrirTela(funcionarios);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //abre tela de usuarios
            Usuarios usuarios = new Usuarios();
            AbrirTela(usuarios);
        }

        private void AbrirTela(UserControl tela)
        {
            //metodo para abrir as telas dentro do panelConteudo, limpando o que tiver antes
            foreach (Control controle in panelConteudo.Controls)
            {
                controle.Dispose();
            }
            panelConteudo.Controls.Clear();
            
            //adiciona a nova tela ao panelConteudo
            tela.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(tela);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //abre tela de inicio
            Inicio inicio = new Inicio();
            AbrirTela(inicio);
        }
    }
}
