using Microsoft.AspNetCore.Mvc;
using CSTSWebAPI.Models;
using Newtonsoft.Json;

namespace CSTSWebAPI.Controllers;

public class TopicController : Controller
{
  

  //public string Index()
  //{
  //  return "Hi";
  //}
   private readonly ITopicData _Data;
  
    public TopicController(ITopicData data)
  {
    _Data = data;
  }

  [HttpGet("/topic")]
  public async Task<IActionResult> Index()
  {
    //return View(await _Data.GetAllTopics());

    List<Models.Topic> topics = new List<Models.Topic>();
    
      var result = await _Data.GetAllTopics();

    foreach (var item in result)
    {
      topics.Add(new Models.Topic
      {
        Id = item.Id,
        TopicName = item.TopicName,
        VideoName= item.VideoName,
        VideoURL = item.VideoURL
      });
    }

    return View(topics);
  }

  [HttpGet("/topic/{id}")]
  public async Task<IActionResult> GetATopic(int id)
  {
    // return View(_Data.GetTopic(id));

    Models.Topic topic = new Models.Topic();

    var item = await _Data.GetTopic(id);

    topic.Id = item.Id;
    topic.TopicName = item.TopicName;
    topic.VideoName = item.VideoName;
    topic.VideoURL = item.VideoURL;
  
    return View(topic);

  }

  //[HttpPost("topic")]
  //public async Task<IResult> InsertTopic(Topic topic)
  //{
  //  try
  //  {
  //    await _Data.InsertTopic(topic);
  //    return Results.Ok();
  //  }
  //  catch (Exception ex)
  //  {
  //    return Results.Problem(ex.Message);
  //  }

  //}

  //[HttpDelete("/topic")]
  //public async Task<IResult> DeleteTopic(int id)
  //{
  //  try
  //  {
  //    await _Data.DeleteTopic(id);
  //    return Results.Ok();
  //  }
  //  catch (Exception ex)
  //  {
  //    return Results.Problem(ex.Message);
  //  }

}




