namespace CodingExam.Interface
{
    public interface IQuestionnaire
    {
        int Id { get; set; } 
        string Question { get; set; } 
        IDictionary<string,string> Options { get; set; }
        string Answer { get; set; }
    }
}
