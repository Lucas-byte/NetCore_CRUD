using Core.Entities;
using Core.Interfaces;
using Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dapper.Data
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository() : base()
        {

        }

        public async Task<IEnumerable<UserModel>> GetSelectUsers()
        {
            var query = "SELECT u.Codigo as Id, u.DataCriacao as CreationDate," +
                        "u.Nome as Name, u.Email as Email FROM usuarios u WHERE u.DataDelecao IS NULL;";

            await using var connection = new MySqlConnection(ConnectionString);

            return await connection.QueryAsync<UserModel>(query);
        }

        public async Task<UserModel> GetUserById(int id)
        {
            var query = "SELECT u.Codigo as Id, u.DataCriacao as CreationDate," +
                        @"u.Nome as Name, u.Email as Email FROM usuarios u WHERE u.Codigo = @id AND u.DataDelecao IS NULL;";

            await using var connection = new MySqlConnection(ConnectionString);

            return await connection.QueryFirstOrDefaultAsync<UserModel>(query, new { id });
        }
    }
}
