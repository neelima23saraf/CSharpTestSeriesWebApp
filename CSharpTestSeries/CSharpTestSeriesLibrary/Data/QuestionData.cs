using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSTSDataAccess.DBAccess;
using CSTSDataAccess.Models;

namespace CSTSDataAccess.Data;

public class QuestionData : IQuestionData
{
  private readonly ISQLDataAccess _db;

  public QuestionData(ISQLDataAccess db)
  {
    _db = db;
  }

  public async Task<IEnumerable<QuestionModel>> GetQuestionsForATopic( int id)
  {

    var result = await _db.LoadData<QuestionModel, dynamic>("dbo.GetATopicQuestion", new { Id = id });
    return result;

  }
}
