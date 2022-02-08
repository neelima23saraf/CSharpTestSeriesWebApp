using CSTSDataAccess.Models;

namespace CSTSDataAccess.Data;

public interface IQuestionData
{
  Task<IEnumerable<QuestionModel>> GetQuestionsForATopic(int id);
}
