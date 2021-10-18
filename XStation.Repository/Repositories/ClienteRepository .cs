using System;
using System.Collections.Generic;
using System.Text;
using XStation.Repository.Entities;
using XStation.Repository.Interfaces;
using Dapper;
using System.Data.SqlClient;
using System.Linq;




namespace XStation.Repository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private string connectionString;

        public ClienteRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Cliente GetByCpf(string cpf)
        {
            var query = "select * from Cliente Where Cpf = @Cpf";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cliente>(query, new { Cpf = cpf }).SingleOrDefault();
            }

        }

        public void Insert(Cliente obj)
        {
            var query = "insert into Usuario(Nome ,Cpf, Telefone1, Telefone2, DataCriacao,DataNascimento) " +
               "values(@Nome,@Cpf, @telefone1, @telefone2, @DataCriacao,@DataNascimento)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Update(Cliente obj)
        {
            var query = "update Cliente set Nome = @Nome, Cpf= @Cpf, Telefone1 = @Telefone1, Telefone2 = @Telefone2, DataCriacao =@DataCriacao, DataNascimento = @DataNascimento" +
                "Where @IdCliente = @IdCliente";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(int id)
        {
            var query = "Delete from Cliente where IdCliente =@IdCliente";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, new { IdCliente = id });
            }
        }

        public List<Cliente> GetAll()
        {
            var query = "select * from Cliente";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cliente>(query).ToList();
            }
        }

        public Cliente GetById(int id)
        {
            var query = "select * from Cliente where IdCliente = @IdCliente";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cliente>(query, new  { IdFornecedor = id }).SingleOrDefault();
            }
        }
    }
}
