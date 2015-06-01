using System.Data.SqlClient;

namespace AgendaContato.Data
{
    //Classe estática não precisa ser instanciada para ser utilizada
    public static class CommandHelper
    {
        //Método estático pode ser invocado a partir da classe estática sem instância
        //Retorna um objeto int e recebe dois parâmetros: SqlConnection e SqlCommand
        public static int ExecutaComando(SqlConnection conexao, SqlCommand comando)
        {
            //abre a conexão
            conexao.Open();
            //executa o comando e obtem a quantidade de registros afetados
            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();
            //fecha a conexão
            conexao.Close();
            //retorna a quantidade de registros afetados
            return quantidadeRegistrosAfetados;
        }
    }
}
