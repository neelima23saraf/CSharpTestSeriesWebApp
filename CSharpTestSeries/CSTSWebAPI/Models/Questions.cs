namespace CSTSWebAPI.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int TopicID { get; set; }
        public string Explanation { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
    public string TopicName { get; set; }
  }
}
