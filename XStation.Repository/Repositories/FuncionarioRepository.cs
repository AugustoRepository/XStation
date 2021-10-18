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
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private string connectionString;

        public FuncionarioRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Funcionario GetByCpf(string cpf)
        {
            var query = "select * from Funcionario Where Cpf = @Cpf";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query, new { Cpf = cpf }).SingleOrDefault();
            }

        }

        public void Insert(Funcionario obj)
        {
            var query = "insert into Usuario(Nome,Cpf, Telefone1, Telefone2, DataCriacao,DataNascimento) " +
               "values(@Nome,@Cpf, @telefone1, @telefone2, @DataCriacao,@DataNascimento)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Update(Funcionario obj)
        {
            var query = "update Funcionario set Nome = @Nome, Cpf= @Cpf, Telefone1 = @Telefone1, Telefone2 = @Telefone2, DataCriacao =@DataCriacao, DataNascimento = @DataNascimento" +
                "Where @IdFuncionairo = @IdFuncionario";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(int id)
        {
            var query = "Delete from Funcionario where IdFuncionairo =@IdFuncionairo";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, new { IdFuncionario = id });
            }
        }

        public List<Funcionario> GetAll()
        {
            var query = "select * from Funcionario";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query).ToList();
            }
        }

        public Funcionario GetById(int id)
        {
            var query = "select * from Funcionairo where IdFuncionario = @IdFuncionario";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query, new  { IdFornecedor = id }).SingleOrDefault();
            }
        }
    }
}
