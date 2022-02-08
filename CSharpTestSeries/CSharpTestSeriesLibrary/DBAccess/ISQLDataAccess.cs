
namespace CSTSDataAccess.DBAccess;

public interface ISQLDataAccess
{
  Task<IEnumerable<T>> LoadData<T, U>(string storeProcedure, U parameters, string connectionId = "CSTSConnectionString");
  //IEnumerable<T> LoadData<T, U>(string storeProcedure, U parameters, string connectionId = "CSTSConnectionString");
  Task SaveData<U>(string storeProcedure, U parameters, string connectionId = "CSTSConnectionString");
}
