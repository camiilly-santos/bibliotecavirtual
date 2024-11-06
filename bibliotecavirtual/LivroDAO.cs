using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecavirtual
{
    internal class LivroDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public LivroDAO() //método construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Livro livro)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText =
            @"INSERT INTO 
            Livro VALUES 
            (@título, @autor, @data_lancamento, @Pais_origem, @descricao)";

            Command.Parameters.AddWithValue("@título", livro.Titulo);
            Command.Parameters.AddWithValue("@autor", livro.Autor);
            Command.Parameters.AddWithValue("@data_lancamento", livro.Data_lancamento);
            Command.Parameters.AddWithValue("Pais_origem", livro.Pais_origem);
            Command.Parameters.AddWithValue("@descricao", livro.Descricao);


            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "livro no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }


        public void Update(Livro livro)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Property SET 
            Título = @título,
            Data_lancamento = @data_lancamento,
            Pais_origem = @Pais_origem, 
            Descricao = @descricao)
            WHERE CodLivro = @code";

            Command.Parameters.AddWithValue("@título", livro.Titulo);
            Command.Parameters.AddWithValue("@autor", livro.Autor);
            Command.Parameters.AddWithValue("@data_lancamento", livro.Data_lancamento);
            Command.Parameters.AddWithValue("Pais_origem", livro.Pais_origem);
            Command.Parameters.AddWithValue("@descricao", livro.Descricao);
            Command.Parameters.AddWithValue("@code", livro.CodLivro);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização de " +
                    "livro no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int codLivro)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Livro 
            WHERE CodLivro = @code";
            Command.Parameters.AddWithValue("@code", codLivro);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "livro no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Livro> ListAllLivros()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Livro";

            List<Livro> Livro = new List<Livro>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Livro livro = new Livro(
                        (int)rd["CodLivro"],
                        (string)rd["Titulo"],
                        (string)rd["Autor"],
                        (string)rd["Data_lancamento"],
                        (string)rd["Pais_origem"],
                        (string)rd["Descricao"]

                        );
                    Livro.Add(livro);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de livros no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return Livro;
        }
    }
}
