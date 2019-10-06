using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DapperDemo.DAL
{
    public class DataAccessObject : IDataAccessObject
    {
        private readonly string _connectionString;

        public DataAccessObject(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public IEnumerable<UserDTO> GetAllUsers(string filter)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return filter == "" 
                    ? connection.Query<UserDTO>("spSystemUser_Get", commandType: CommandType.StoredProcedure) 
                    : connection.Query<UserDTO>("spSystemUser_GetFiltered", new {Filter = filter}, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateUser(UserDTO user)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Execute("dbo.spSystemUser_Create", new {user.FirstName, user.LastName}, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
