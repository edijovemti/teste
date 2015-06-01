using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgendaContato.Data;

namespace AgendaContato
{
    public partial class ExcluirContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnexcluir_Click(object sender, EventArgs e)
        {  
            // faz ver o contatoDA de outro metodo
            ContatoDA da = new ContatoDA();
            int id = Convert.ToInt32(TxtIdcontado.Text);

            int quantidade = da.ExcluirContato(id);
           
            
        }
    }
}