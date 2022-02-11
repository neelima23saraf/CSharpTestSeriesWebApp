using Microsoft.AspNetCore.Mvc;
using CSTSWebAPI.Models;

namespace CSTSWebAPI.Controllers;
public class QuestionController : Controller
{
  private readonly IQuestionData _Data;

  public QuestionController(IQuestionData data)
  
  {
    _Data = data;
  }

  [HttpGet("/question/{id}")]
  public async Task<IActionResult> Index(int id, int pg=1)
  {

    List<Questions> questions = new List<Questions>();

    var result = await _Data.GetQuestionsForATopic(id);
    if (result != null)
    {
      foreach (var item in result)
      {
        questions.Add(new Questions
        {
          Id = item.Id,
          Question = item.Question,
          Answer = item.Answer,
          Explanation = item.Explanation,
          TopicID = item.TopicId,
          OptionA = item.OptionA,
          OptionB = item.OptionB,
          OptionC = item.OptionC,
          OptionD = item.OptionD,
          TopicName = item.TopicName

        });

      }
    }

    const int pageSize = 1;
    if (pg < 1) pg = 1;
    int recsCount = questions.Count();

    var pager = new Pager(recsCount, pg, pageSize);

    int recSkip = (pg - 1) * pageSize;

    var data = questions.Skip(recSkip).Take(pager.PageSize).ToList();

    this.ViewBag.Pager = pager;

    return View(data);

    //return View(questions);
  }
  // GET: QuestionController/Details/5
  //public async Task<IActionResult> Index(int id)
  //{

  //  List<Questions> questions = new List<Questions>();

  //  var result = await _Data.GetQuestionsForATopic(id);
  //  if (result != null)
  //  {
  //    foreach (var item in result)
  //    {
  //      questions.Add(new Questions { Id = item.Id, 
  //        Question = item.Question, 
  //        Answer = item.Answer, 
  //        Explanation= item.Explanation,
  //        TopicID = item.TopicId,
  //        OptionA = item.OptionA,
  //        OptionB = item.OptionB,
  //        OptionC = item.OptionC,
  //        OptionD = item.OptionD
  //      });

  //    }
  //  }

  //  return View(questions);
  //}
}
