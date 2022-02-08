using CSTSDataAccess.Models;


namespace CSTSDataAccess.Data;

public interface ITopicData
{
  Task<IEnumerable<Topic>> GetAllTopics();
  Task<Topic?> GetTopic(int id);
  //Task InsertTopic(Topic topic);
  //Task DeleteTopic(int id);
}
