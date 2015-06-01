using System.Data.SqlClient;

namespace AgendaContato.Data
{
    //Classe estática não precisa ser instanciada para ser utilizada
    public static class ConexaoHelper
    {
        //Método estático pode ser invocado a partir da classe estática sem instância
        //Retorna um objeto SqlConnection
        public static SqlConnection CriarConexao()
        {
            //string de conexão do banco de dados
            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename= C:\Users\edijovem\Desktop\AgendaContato\AgendaContato\App_Data\AgendaContato.mdf;Integrated Security=True;User Instance=True";

            //cria uma instância da class SqlConnection
            SqlConnection conexao = new SqlConnection();
            //atribui o valor da variável para a propriedade do objeto conexao
            conexao.ConnectionString = connString;
            //retorna o objeto conexao
            return conexao;
        }
    }
}
