using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
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
using static BibliotecaRemake.BibliotecaDBDataSet;

namespace BibliotecaRemake
{
    public partial class Requisicao : UserControl
    {
        public Requisicao()
        {
            InitializeComponent();          
        }       

        private void AbrirTela(UserControl tela)
        {

            foreach (Control controle in panelConteudo.Controls)
            {
                controle.Dispose();
            }
            panelConteudo.Controls.Clear();

            tela.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(tela);
        }

        private void tpPrincipal_Click(object sender, EventArgs e)
        {
            ucPrincipal ucPrincipal = new ucPrincipal();
            AbrirTela(ucPrincipal);
        }

        private void tpEmprestar_Click(object sender, EventArgs e)
        {
            ucEmprestar ucEmprestar = new ucEmprestar();
            AbrirTela(ucEmprestar);
        }

        private void tpDevolver_Click(object sender, EventArgs e)
        {
            ucDevolver ucDevolver = new ucDevolver();
            AbrirTela(ucDevolver);
        }

        private void tpConsultar_Click(object sender, EventArgs e)
        {
            ucConsultar ucConsultar = new ucConsultar();
            AbrirTela(ucConsultar);
        }

    }
}