using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AgendaContato.Data
{
    public class ContatoDA
    {
        //Método para adicionar um contato
        //Passa por parâmetro um objeto do tipo da classe Contato
        public int AdicionarContato(Contato contato)
        {
            //cria o comando sql utilizando o StringBuilder
            StringBuilder query = new StringBuilder();
            query.Append("insert into Contato (Nome, Telefone, DataNascimento, Skype, Email)");
            query.Append(" values (@nome, @telefone, @nascimento, @skype, @email)");

            //cria os parâmetros para passar para o SqlCommand
            SqlParameter paramNome = new SqlParameter("@nome", contato.Nome);
            SqlParameter paramTelefone = new SqlParameter("@telefone", contato.Telefone);
            SqlParameter paramDataNascimento = new SqlParameter("@nascimento", contato.DataNascimento);
            SqlParameter paramSkype = new SqlParameter("@skype", contato.Skype);
            SqlParameter paramEmail = new SqlParameter("@email", contato.Email);

            //cria a conexão a partir do ConexaoHelper (classe estática)
            SqlConnection conexao = ConexaoHelper.CriarConexao();
            //cria o comando a partir da conexão
            SqlCommand comando = conexao.CreateCommand();

            //passa o comando sql (query) para o comando
            comando.CommandText = query.ToString();
            //informa o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;

            //adiciona os parâmetros para o comando
            comando.Parameters.Add(paramNome);
            comando.Parameters.Add(paramTelefone);
            comando.Parameters.Add(paramDataNascimento);
            comando.Parameters.Add(paramSkype);
            comando.Parameters.Add(paramEmail);

            //executa o comando com o CommandHelper (classe estática) e obtém o retorno do método
            int quantidadeRegistrosAfetados = CommandHelper.ExecutaComando(conexao, comando);

            return quantidadeRegistrosAfetados;
        }

        //Método para listar todos os contatos
        //Retorna uma lista de objetos do tipo da classe Contato
        public List<Contato> ListarContato()
        {
            //Instancia uma lista dos tipos da classe Contato
            List<Contato> contatos = new List<Contato>();
            //Retornar a lista de contatos
            return contatos;
        }
         
        //excluuir o contato
        public int  ExcluirContato(int idContato)
        {
           // StringBuilder query = new StringBuilder();
            //query.Append("delete from contato where idContato=@idcontato");
            string query =(" delete from contato where IdContato = @idcontato");


            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@idcontato";
            param1.Value=idContato;
            
            SqlConnection conexao =ConexaoHelper.CriarConexao();

            SqlCommand comando =conexao.CreateCommand();
            comando.Parameters.Add(param1);
            comando.CommandText = query;
            comando.CommandType = System.Data.CommandType.Text;

            int qtd = CommandHelper.ExecutaComando(conexao,comando);
            return qtd;
        }

        public void AtualizarContato(Contato contato)

        {
            string Connstring = ("update Contato set Nome = @nome,Telefone = @telefone,DataNascimento = @nascimento,Skype = @skype,Email=@email where idcontato=@idcontato");
             //cria os parâmetros para passar para o SqlCommand
            SqlParameter paramId = new SqlParameter("@idcontato", contato.Id);
            SqlParameter paramNome = new SqlParameter("@nome", contato.Nome);
            SqlParameter paramTelefone = new SqlParameter("@telefone", contato.Telefone);
            SqlParameter paramDataNascimento = new SqlParameter("@nascimento", contato.DataNascimento);
            SqlParameter paramSkype = new SqlParameter("@skype", contato.Skype);
            SqlParameter paramEmail = new SqlParameter("@email", contato.Email);
            
           
            // SqlConnection conexao = new SqlConnection();
           // conexao.Open();
            //cria a conexão a partir do ConexaoHelper (classe estática)
            SqlConnection conexao = ConexaoHelper.CriarConexao();
            //cria o comando a partir da conexão
            SqlCommand comando = conexao.CreateCommand();

            //passa o comando sql (query) para o comando
            comando.CommandText = (Connstring);
            //informa o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;

            //adiciona os parâmetros para o comando
            comando.Parameters.Add(paramId);
            comando.Parameters.Add(paramNome);
            comando.Parameters.Add(paramTelefone);
            comando.Parameters.Add(paramDataNascimento);
            comando.Parameters.Add(paramSkype);
            comando.Parameters.Add(paramEmail);

            //executa o comando com o CommandHelper (classe estática) e obtém o retorno do método
            int quantidadeRegistrosAfetados = CommandHelper.ExecutaComando(conexao, comando);

            //return quantidadeRegistrosAfetados;
        }

        public void BuscarContato(Contato contato)
        {
           // int idcontato =
            Contato c = null;
            string query = "select idcontato, Nome,Skype, Telefone, Email,DataNascimento from contato where idcontato=@id";

            SqlParameter paramId = new SqlParameter("@id",contato.Id);

            //cria a conexão a partir do ConexaoHelper (classe estática)
            SqlConnection conexao = ConexaoHelper.CriarConexao();
            //cria o comando a partir da conexão
            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = query.ToString();

            comando.CommandType = System.Data.CommandType.Text;
            
            comando.Parameters.Add(paramId);
            conexao.Open();

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                c = new Contato();
                c.Id = Convert.ToInt32(reader["idcontato"]);
                c.Nome = reader["Nome"].ToString();
                c.Skype = reader["Skype"].ToString();
                c.Telefone= reader["Telefone"].ToString();
                c.DataNascimento =Convert.ToDateTime(reader["DataNascimento"].ToString());
                c.Email=reader["Email"].ToString();
            }
            conexao.Close();
            
            }
        
        }

    }

