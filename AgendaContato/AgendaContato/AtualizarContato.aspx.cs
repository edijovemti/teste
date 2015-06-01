using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgendaContato.Data;
using System.Data.SqlClient;

namespace AgendaContato
{
    public partial class AtualizarContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Atualiza contato
            Contato A = new Contato();
            A.Id = Convert.ToInt32(txtidcontato.Text);
            A.Nome = txtNome.Text;
            A.Telefone = txtTelefone.Text;
            A.Skype = txtSkype.Text;
            A.Email = txtEmail.Text;
            A.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

            ContatoDA da = new ContatoDA();
            //int qtdRegistrosAfetados = 
            da.AtualizarContato(A);

           // return qtdRegistrosAfetados;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Busca o registro
            int @id=Convert.ToInt32(txtidcontato.Text);
            ContatoDA da = new ContatoDA();

           
         
           // conexao.Open();
            

           // SqlCommand comando = conexao.CreateCommand();
           // comando.CommandText = "SELECT IDCONTATO,NOME,DATANASCIMENTO,SKYPE,TELEFONE FROM CONTATO WHERE IDCONTATO=@id";
            //comando.CommandType = System.Data.CommandType.Text;
           // SqlDataReader reader = comando.ExecuteReader();
            
           // GrdCategorias.DataSource = reader;
            //GrdCategorias.DataBind();

           // conexao.Close();
        }
        }
     }
      

       
 