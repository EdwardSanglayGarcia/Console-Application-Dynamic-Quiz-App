using CodingExam.Data;
using CodingExam.Interface;

namespace CodingExam.Classes.DerivedClasses
{
    public class ProgrammerCodingExam : BaseExam
    {
        protected override List<IQuestionnaire> AddDummyData()
        {
            return DummyData.GenerateDummyData();
        }
        protected override List<IQuestionnaire> ShuffleData(List<IQuestionnaire> rawData)
        {
            return rawData.OrderBy(shuffle => Guid.NewGuid()).ToList();
        }
        protected override void DisplayInstructions()
        {
            Console.WriteLine("Welcome to Programming Exam! Press any key to continue!");
            Console.ReadKey();
            Console.Clear();

        }
        protected override void StartExamination(List<IQuestionnaire> unansweredData)
        {
            int counter = 0;
            while (counter <= unansweredData.Count()-1)
            {
                var unansweredDataObject = unansweredData[counter];
                Console.WriteLine($"{unansweredDataObject.Id} - {unansweredDataObject.Question}");
                foreach (var choices in unansweredDataObject.Options)
                {
                    Console.WriteLine($"{choices.Key} - {choices.Value}");
                }
                Console.Write("CHOICE: ");
                unansweredDataObject.Answer = Console.ReadLine();
                if (VerifyAnswer(unansweredDataObject.Answer))
                {
                    Console.Clear();
                    counter++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"<<INPUT {unansweredDataObject.Answer} IS NOT A VALID INPUT! PLEASE ENTER A VALID INPUT! I'LL REPEAT THE QUESTION AGAIN>>");
                }
            }
        }
        protected override void DisplayAnswers(List<IQuestionnaire> answeredData)
        {
            Console.WriteLine("Question #\tAnswer");
            answeredData.ForEach(data => Console.WriteLine($"    {data.Id}\t\t  {data.Answer}\n"));
        }
        protected override void DisplayOverallResults(List<IQuestionnaire> answeredData)
        {
            int countResult_A = answeredData.Where(answer => answer.Answer.ToLower() == "a").Count();
            int countResult_B = answeredData.Where(answer => answer.Answer.ToLower() == "b").Count();
            int countResult_C = answeredData.Where(answer => answer.Answer.ToLower() == "c").Count();

            Dictionary<string, int[]> resultingPairs = new Dictionary<string, int[]>();
            resultingPairs.Add("c", new int[] { countResult_C, 1 });
            resultingPairs.Add("a", new int[] { countResult_A, 2 });
            resultingPairs.Add("b", new int[] { countResult_B, 3 });

            var finalData = resultingPairs.OrderByDescending(x => x.Value[0]).Take(2);

            Console.WriteLine($"The results from the {nameof(DisplayOverallResults)} are the following:");
            Console.WriteLine($"count(a): {countResult_A}");
            Console.WriteLine($"count(b): {countResult_B}");
            Console.WriteLine($"count(c): {countResult_C}");

            var outputCharacter =
                finalData.Select(data => data.Value[0]).Distinct().Count() == 1 ?
                finalData.OrderByDescending(x => x.Value[1]).Select(x => x.Key).FirstOrDefault() :
                finalData.Select(x => x.Key).FirstOrDefault();

            var outputResult =
                outputCharacter == "a" ? DummyData.DisplayResults().Where(condition => condition.Key == 2).Select(result => result.Value).FirstOrDefault() :
                outputCharacter == "b" ? DummyData.DisplayResults().Where(condition => condition.Key == 3).Select(result => result.Value).FirstOrDefault() :
                outputCharacter == "c" ? DummyData.DisplayResults().Where(condition => condition.Key == 1).Select(result => result.Value).FirstOrDefault() :
                "UNEXPECTED CHARACTER WAS ADDED";
            Console.WriteLine();
            Console.WriteLine($"Output Result: {outputResult}");

        }
        private bool VerifyAnswer(string answerToQuestionnaire)
        {
            return
                answerToQuestionnaire == "a" ||
                answerToQuestionnaire == "b" ||
                answerToQuestionnaire == "c" ?
                true : false;
        }

    }
}
