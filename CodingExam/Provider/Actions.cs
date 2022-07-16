using CodingExam.Classes;

namespace CodingExam.Provider
{
    public class Actions
    {
        public static void ExecuteTemplateMethod(BaseExam baseExam)
        {
            baseExam.InitializeExamination();
        }
    }
}
