﻿using CSTSDataAccess.DBAccess;
using CSTSDataAccess.Models;

namespace CSTSDataAccess.Data;

public class TopicData : ITopicData
{
  private readonly ISQLDataAccess _db;

  public TopicData(ISQLDataAccess db)
  {
    _db = db;
  }


  /// <summary>
  /// Get all the topics from the database  
  /// </summary>
  /// <returns></returns>
  public Task<IEnumerable<Topic>> GetAllTopics() => _db.LoadData<Topic, dynamic>("dbo.GetAllTopics", new { });

  //TODO - Get One
  public async Task<Topic?> GetTopic(int id)
  {
    var result = await _db.LoadData<Topic, dynamic>("dbo.GetTopic", new { Id = id });
    return result.FirstOrDefault();
  }

  // TODO - Insert

  public Task InsertTopic(Topic topic) => _db.SaveData("dbo.InsertTopic", new { topic.TopicName, topic.VideoName, topic.VideoURL });

  // TODO - Delete

  public Task DeleteTopic(int id) => _db.SaveData("dbo.DeleteTopic", new { id = id });


}
