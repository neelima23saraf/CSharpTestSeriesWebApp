namespace CSTSMiniAPI;

public static class Api
{
  public static void ConfigureApi(this WebApplication app)
  {
    //All of the API end points
    app.MapGet("/Topic", GetTopics);
    app.MapGet("/Topic/{id}", GetATopic);
    app.MapGet("/question/{id}", GetQuestions);
    //app.MapPost("/Topic", InsertTopic);
    //app.MapDelete("/Topic", DeleteTopic);
    //app.MapGet("/question/{id}", GetQuestions);
  }


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

  private static async Task<IResult> GetQuestions(IQuestionData data, int id)
  { 
    try{
      var results = await data.GetQuestionsForATopic(id);
      if (results == null) return Results.NotFound();
      return Results.Ok(results);
    }
    catch (Exception ex)
    {

      return Results.Problem(ex.Message);
    }

  }

  //private static async Task<IResult> InsertTopic(Topic topic, ITopicData data)
  //{
  //  try
  //  {
  //    await data.InsertTopic(topic);
  //    return Results.Ok();
  //  }
  //  catch (Exception ex)
  //  {
  //    return  Results.Problem(ex.Message);
  //  }

  //}

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
