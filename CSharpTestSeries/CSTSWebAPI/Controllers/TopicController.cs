using Microsoft.AspNetCore.Mvc;


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
   public IActionResult Index()
  {
    return View(_Data.GetAllTopics());
  }

  [HttpGet("/topic/{id}")]
  public IActionResult GetATopic(int id)
  {
      return View(_Data.GetTopic(id));
   }

  [HttpPost("topic")]
  public async Task<IResult> InsertTopic(Topic topic)
  {
    try
    {
      await _Data.InsertTopic(topic);
      return Results.Ok();
    }
    catch (Exception ex)
    {
      return Results.Problem(ex.Message);
    }

  }

  [HttpDelete("/topic")]
  public async Task<IResult> DeleteTopic(int id)
  {
    try
    {
      await _Data.DeleteTopic(id);
      return Results.Ok();
    }
    catch (Exception ex)
    {
      return Results.Problem(ex.Message);
    }

  }


}

