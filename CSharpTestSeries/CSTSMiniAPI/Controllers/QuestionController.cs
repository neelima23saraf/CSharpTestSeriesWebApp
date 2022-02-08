using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSTSMiniAPI.Controllers;
public class QuestionController : Controller
{


  //// GET: QuestionController
  //public ActionResult Index()
  //{
  //  return View();
  //}

  [HttpGet("/question/{id}")]
  // GET: QuestionController/Details/5
  public async Task<IResult> GetQuestionsForATopic(IQuestionData data, int id)
  {
    var result = await data.GetQuestionsForATopic(id);
    if (result == null) return Results.NotFound();
    return Results.Ok(result);
  }

  // GET: QuestionController/Create
  //public ActionResult Create()
  //{
  //  return View();
  //}

  //// POST: QuestionController/Create
  //[HttpPost]
  //[ValidateAntiForgeryToken]
  //public ActionResult Create(IFormCollection collection)
  //{
  //  try
  //  {
  //    return RedirectToAction(nameof(Index));
  //  }
  //  catch
  //  {
  //    return View();
  //  }
  //}

  //// GET: QuestionController/Edit/5
  //public ActionResult Edit(int id)
  //{
  //  return View();
  //}

  //// POST: QuestionController/Edit/5
  //[HttpPost]
  //[ValidateAntiForgeryToken]
  //public ActionResult Edit(int id, IFormCollection collection)
  //{
  //  try
  //  {
  //    return RedirectToAction(nameof(Index));
  //  }
  //  catch
  //  {
  //    return View();
  //  }
  //}

  //// GET: QuestionController/Delete/5
  //public ActionResult Delete(int id)
  //{
  //  return View();
  //}

  //// POST: QuestionController/Delete/5
  //[HttpPost]
  //[ValidateAntiForgeryToken]
  //public ActionResult Delete(int id, IFormCollection collection)
  //{
  //  try
  //  {
  //    return RedirectToAction(nameof(Index));
  //  }
  //  catch
  //  {
  //    return View();
  //  }
  //}
}
