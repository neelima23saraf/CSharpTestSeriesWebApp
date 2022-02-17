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

   var model = new QuestionList();
    
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

    model.QuestionWithAnswers = questions;

    return View(model);

    //var model = new QuestionList {
    //QuestionWithAnswers = new[]
    //{ 
    // new Questions{
    // Id = 1,
    //  Question = "Question 1",
    //  Answer = "",
    //  Explanation = "Explanation 1",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"
    //  },
    // new Questions{
    //       Id = 2,
    //  Question = "Question 2",
    //  Answer = "",
    //  Explanation = "Explanation 2",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"
    //  },
    // new Questions{
    //       Id = 3,
    //  Question = "Question 3",
    //  Answer = "",
    //  Explanation = "Explanation 3",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"
    //  },
    // new Questions{
    //   Id = 4,
    //  Question = "Question 4",
    //  Answer = "",
    //  Explanation = "Explanation 4",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"
    //  },

    //}
    //};
    //return View(model);

    //List<Questions> questions = new List<Questions>();
    //questions.Add(new Questions
    //{
    //  Id = 1,
    //  Question = "Question 1",
    //  Answer = "",
    //  Explanation = "Explanation 1",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 2,
    //  Question = "Question 2",
    //  Answer = "",
    //  Explanation = "Explanation 2",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 3,
    //  Question = "Question 3",
    //  Answer = "",
    //  Explanation = "Explanation 3",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 4,
    //  Question = "Question 4",
    //  Answer = "",
    //  Explanation = "Explanation 4",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 5,
    //  Question = "Question 5",
    //  Answer = "",
    //  Explanation = "Explanation 5",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 6,
    //  Question = "Question 6",
    //  Answer = "",
    //  Explanation = "Explanation 6",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 7,
    //  Question = "Question 7",
    //  Answer = "",
    //  Explanation = "Explanation 7",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 8,
    //  Question = "Question 8",
    //  Answer = "",
    //  Explanation = "Explanation 8",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 9,
    //  Question = "Question 9",
    //  Answer = "",
    //  Explanation = "Explanation 9",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});
    //questions.Add(new Questions
    //{
    //  Id = 10,
    //  Question = "Question 10",
    //  Answer = "",
    //  Explanation = "Explanation 10",
    //  TopicID = 1,
    //  OptionA = "item.OptionA",
    //  OptionB = "item.OptionB",
    //  OptionC = "item.OptionC",
    //  OptionD = "item.OptionD",
    //  TopicName = "Topic 1"

    //});


    //List<Questions> questions = new List<Questions>();
    //var result = await _Data.GetQuestionsForATopic(id);
    //if (result != null)
    //{
    //  foreach (var item in result)
    //  {
    //    questions.Add(new Questions
    //    {
    //      Id = item.Id,
    //      Question = item.Question,
    //      Answer = item.Answer,
    //      Explanation = item.Explanation,
    //      TopicID = item.TopicId,
    //      OptionA = item.OptionA,
    //      OptionB = item.OptionB,
    //      OptionC = item.OptionC,
    //      OptionD = item.OptionD,
    //      TopicName = item.TopicName

    //    });

    //  }
    //}




    //******************paging begin
    //const int pageSize = 1;
    //if (pg < 1) pg = 1;
    //int recsCount = questions.Count();

    //var pager = new Pager(recsCount, pg, pageSize);

    //int recSkip = (pg - 1) * pageSize;

    //var data = questions.Skip(recSkip).Take(pager.PageSize).ToList();

    //this.ViewBag.Pager = pager;

    //return View(data);
    //******************paging ends


    // return View(questions);
  }
  [HttpPost]
  public ActionResult CheckResult(QuestionList model)
  {
    return View("");
    //return Content(
    //    string.Format(
    //        "Thank you for selecting the following values: {0}",
    //        string.Join(" ", model.Modules.Select(x => string.Format("model id: {0}, active: {1}", x.Id, x.IsActive)))
    //    )
    //);
  }

  //[HttpPost]
  //public ViewResult CheckResult(IEnumerable<Questions> model)
  //{

  //  return View("Done");

  //}
}
