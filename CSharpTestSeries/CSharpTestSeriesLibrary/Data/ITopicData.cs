using CSTSDataAccess.Models;


namespace CSTSDataAccess.Data;

public interface ITopicData
{
  IEnumerable<Topic> GetAllTopics();
  Topic? GetTopic(int id);
  Task InsertTopic(Topic topic);
  Task DeleteTopic(int id);
}
