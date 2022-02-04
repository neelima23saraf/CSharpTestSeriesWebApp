using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace CSTSDataAccess.DBAccess;
public class SQLDataAccess : ISQLDataAccess
{
  private readonly IConfiguration _config;
  public SQLDataAccess(IConfiguration config)
  {
    _config = config;
  }

  //public async Task<IEnumerable<T>> LoadData<T, U>(string storeProcedure, U parameters, string connectionId = "CSTSConnectionString")
  //{
  //  using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
  //  return await connection.QueryAsync<T>(storeProcedure, parameters, commandType: CommandType.StoredProcedure);
  //}


  //public async Task SaveData<U>(string storeProcedure, U parameters, string connectionId = "CSTSConnectionString")
  //{
  //  using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
  //  await connection.ExecuteAsync(storeProcedure, parameters, commandType: CommandType.StoredProcedure);
  //}

  public IEnumerable<T> LoadData<T, U>(string storeProcedure, U parameters, string connectionId = "CSTSConnectionString")
  {
    using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
    return connection.Query<T>(storeProcedure, parameters, commandType: CommandType.StoredProcedure);
  }


  public async Task SaveData<U>(string storeProcedure, U parameters, string connectionId = "CSTSConnectionString")
  {
    using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
    await connection.ExecuteAsync(storeProcedure, parameters, commandType: CommandType.StoredProcedure);
  }
}
