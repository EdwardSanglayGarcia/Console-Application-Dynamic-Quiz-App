using CodingExam.Interface;

namespace CodingExam.Classes
{
    public abstract class BaseExam
    {
        //If the client wants to have a new exam, just add a derived class (ex. ProgrammerCodingExam, DoctorHealingExam, CivilEngineerBuildingExam)
        public void InitializeExamination()
        {
            var shuffledData = ShuffleData(AddDummyData());
            DisplayInstructions();
            StartExamination(shuffledData);
            DisplayAnswers(shuffledData);
            DisplayOverallResults(shuffledData);
        }
        protected virtual void DisplayInstructions()
        {
            //Default instruction that can be overridden.
            Console.WriteLine("Welcome! Please Press any key to continue!");
            Console.ReadKey();
        }
        protected abstract List<IQuestionnaire> AddDummyData();
        protected abstract List<IQuestionnaire> ShuffleData(List<IQuestionnaire> rawData);
        protected abstract void StartExamination(List<IQuestionnaire> unansweredData);
        protected abstract void DisplayAnswers(List<IQuestionnaire> answeredData);
        protected abstract void DisplayOverallResults(List<IQuestionnaire> answeredData);
    }
}
