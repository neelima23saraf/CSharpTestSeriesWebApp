namespace CSTSDataAccess.Models;

public class QuestionModel
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public int TopicId { get; set; }
    public string Explanation { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }
  public string TopicName { get; set; }


}
