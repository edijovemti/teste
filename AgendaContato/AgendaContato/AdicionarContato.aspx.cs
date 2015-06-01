using System;
using System.Data.SqlClient;
using System.Text;
using AgendaContato.Data;

namespace AgendaContato
{
    public partial class AdicionarContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            int qtdRegistrosAfetados = CadastrarContato();
        }

        private int CadastrarContato()
        {
            Contato c = new Contato();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;
            c.Skype = txtSkype.Text;
            c.Email = txtEmail.Text;
            c.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

            ContatoDA da = new ContatoDA();
            int qtdRegistrosAfetados = da.AdicionarContato(c);

            return qtdRegistrosAfetados;
        }
        



        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}