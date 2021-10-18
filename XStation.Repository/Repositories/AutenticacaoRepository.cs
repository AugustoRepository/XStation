using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using XStation.Repository.Entities;
using XStation.Repository.Interfaces;

namespace XStation.Repository.Repositories
{
    public class AutenticacaoRepository : IAutenticacaoRepository
    {
        private string connectionString;

        public AutenticacaoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Autenticacao GetByEmail(string email)
        {
            var query = "select * from Autenticacao where Email = @Email";
           using(var connection = new SqlConnection(connectionString))
            {
                 return connection.Query<Autenticacao>
                    (query, new { email }).SingleOrDefault();
            }           
        }

        public Autenticacao GetByEmailESenha(string email, string senha)
        {
            var query = "select * from Autenticacao where Email =@Email and Senha =@Senha";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Autenticacao>(query, new { email, senha }).SingleOrDefault();
            }
        }

        public void Insert(Autenticacao obj)
        {
            var query = "insert into Autenticacao(IdAutenticacao,Email, Senha) " +
                "Values (@IdAutenticacao ,@Email, @Senha)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Update(Autenticacao obj)
        {
            var query = "update funcionario set Email =@Email, Senha = @Senha " +
                "where Email = @Email";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(int id)
        {
            var query = "delete from Autenticacao where Email = @Email";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, new { Id = id });
            }
        }

        public List<Autenticacao> GetAll()
        {
            var query = "select * from Autenticacao";
            using(var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Autenticacao>(query).ToList();
            }
        }

        public Autenticacao GetById(int id)
        {
            var query = "select * from Autenticacao where IdAutenticacao = @IdAutenticacao";

            using(var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Autenticacao>(query, new { IdAutenticacao = id }).SingleOrDefault();
            }
        }
    }
}
