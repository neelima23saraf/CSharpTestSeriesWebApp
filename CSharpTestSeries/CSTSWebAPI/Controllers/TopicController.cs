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
   public async Task<IResult> GetTopics()
  {
    try
    {
      return Results.Ok(await _Data.GetAllTopics());
    }
    catch (Exception ex)
    {

      return Results.Problem(ex.Message);
    }
  }

  [HttpGet("/topic/{id}")]
  public async Task<IResult> GetATopic(int id)
  {
    try
    {
      var results = await _Data.GetTopic(id);
      if (results == null) return Results.NotFound();
      return Results.Ok(results);
    }
    catch (Exception ex)
    {

      return Results.Problem(ex.Message);
    }
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

