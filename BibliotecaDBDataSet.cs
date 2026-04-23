using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System.Linq;

namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {

        public partial class RequisicoesRow
        {
            public string Devolucao
            {
                get
                {
                    try
                    {
                        return DataDevolucao.ToString();
                    }
                    catch
                    {
                        return "Devolvido";
                    }
                }
            }
            public override string ToString()
            {
                LivrosTableAdapter livros = new LivrosTableAdapter();
                LivrosRow livro = (from linha in livros.GetData() where linha.LivroID == this.LivroID select linha).FirstOrDefault();
                return RequisicaoID.ToString() + " - " + livro.Titulo;
            }


        }
        partial class RequisicoesDataTable
        {

        }

        public partial class FuncionariosRow
        {
            public override string ToString()
            {
                return this.FuncionarioID + " - " + this.NomeCompleto;
            }
        }
        partial class FuncionariosDataTable
        {
        }

        partial class UsuariosDataTable
        {

        }

        public partial class UsuariosRow
        {
            public override string ToString()
            {
                return this.UsuarioID + " - " + this.Nome;
            }
        }

        public partial class LivrosRow
        {
            public override string ToString()
            {
                return this.LivroID + " - " + this.Titulo;
            }
        }
    }
}

namespace BibliotecaRemake.BibliotecaDBDataSetTableAdapters
{
    partial class LivrosTableAdapter
    {
    }

    public partial class UsuariosTableAdapter {
    }
}
