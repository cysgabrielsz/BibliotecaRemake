namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
        public partial class  FuncionariosRow
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
