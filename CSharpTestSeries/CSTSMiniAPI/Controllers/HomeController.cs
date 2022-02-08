using Microsoft.AspNetCore.Mvc;

namespace CSTSMiniAPI;
public class HomeController : Controller
{
  [HttpGet("/Topic")]
  private static async Task<IResult> GetTopics(ITopicData data)
  {
    try
    {
      return Results.Ok(await data.GetAllTopics());
    }
    catch (Exception ex)
    {

      return Results.Problem(ex.Message);
    }
  }

  [HttpGet("/Topic/{id}")]
  private static async Task<IResult> GetATopic(ITopicData data, int id)
  {
    try
    {
      var results = await data.GetTopic(id);
      if (results == null) return Results.NotFound();
      return Results.Ok(results);
    }
    catch (Exception ex)
    {

      return Results.Problem(ex.Message);
    }
  }

  //[HttpPost("/Topic")]
  //private static async Task<IResult> InsertTopic(Topic topic, ITopicData data)
  //{
  //  try
  //  {
  //    await data.InsertTopic(topic);
  //    return Results.Ok();
  //  }
  //  catch (Exception ex)
  //  {
  //    return Results.Problem(ex.Message);
  //  }

  //}

  //[HttpDelete("/Topic")]
  //private static async Task<IResult> DeleteTopic(ITopicData data, int id)
  //{
  //  try
  //  {
  //    await data.DeleteTopic(id);
  //    return Results.Ok();
  //  }
  //  catch (Exception ex)
  //  {
  //    return Results.Problem(ex.Message);
  //  }

  //}

}

