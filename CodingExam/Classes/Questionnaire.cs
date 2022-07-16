using CodingExam.Interface;

namespace CodingExam.Classes
{
    public class Questionnaire : IQuestionnaire
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public IDictionary<string, string> Options { get; set; } = new Dictionary<string, string>();  
        public string Answer { get; set; }
    }
}
