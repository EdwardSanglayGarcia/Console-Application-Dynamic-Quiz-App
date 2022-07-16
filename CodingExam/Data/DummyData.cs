using CodingExam.Classes;
using CodingExam.Interface;

namespace CodingExam.Data
{
    public class DummyData
    {
        public static List<IQuestionnaire> GenerateDummyData()
        {

            List<IQuestionnaire> questionnaires = new List<IQuestionnaire>();

            questionnaires.AddRange
                (
                new List<Questionnaire>
                {
                    new Questionnaire()
                    {
                        Id = 1,
                        Question = "You went to a party last night and when you arrived to school the next day, everybody is talking about something you didn’t do. What will you do?",
                        Options =
                        {
                            { "a", "Avoid everything and go with your friends" },
                            { "b", "Go and talk with the person that started the rumors" },
                            { "c", "Go and talk with the teacher" }
                        }
                    },

                    new Questionnaire()
                    {
                        Id = 2,
                        Question = "What quality do you excel the most?",
                        Options =
                        {
                            { "a", "Empathy" },
                            { "b", "Curiosity" },
                            { "c", "Perseverance" }
                        }
                    },

                    new Questionnaire()
                    {
                        Id = 3,
                        Question = "You are walking down the street when you see an old lady trying to cross, what will you do?",
                        Options =
                        {
                            { "a", "Go and help her" },
                            { "b", "Go for a policeman and ask him to help" },
                            { "c", "Keep walking ahead" }
                        }
                    },

                    new Questionnaire()
                    {
                        Id = 4,
                        Question = "You had a very difficult day at school, you will maintain a ____ attitude",
                        Options =
                        {
                            { "a", "Depends on the situation" },
                            { "b", "Positive" },
                            { "c", "Negative" }
                        }
                    },

                    new Questionnaire()
                    {
                        Id = 5,
                        Question = "You are at a party and a friend of yours comes over and offers you a drink, what do you do?",
                        Options =
                        {
                            { "a", "Say no thanks" },
                            { "b", "Drink it until it is finished" },
                            { "c", "Ignore him and get angry at him" }
                        }
                    },

                    new Questionnaire()
                    {
                        Id = 6,
                        Question = "You just started in a new school, you will...",
                        Options =
                        {
                            { "a", "Go and talk with the person next to you" },
                            { "b", "Wait until someone comes over you" },
                            { "c", "Not talk to anyone" }
                        }
                    },

                    new Questionnaire()
                    {
                        Id = 7,
                        Question = "In a typical Friday, you would like to..",
                        Options =
                        {
                            { "a", "Go out with your close friends to eat" },
                            { "b", "Go to a social club and meet more people" },
                            { "c", "Invite one of your friends to your house" }
                        }
                    },

                    new Questionnaire()
                    {
                        Id = 8,
                        Question = "Your relationship with your parents is..",
                        Options =
                        {
                            { "a", "I like both equally" },
                            { "b", "I like both equally" },
                            { "c", "I like my Mom the most" }
                        }
                    },
                }
                );

            return questionnaires.ToList();
        }
        public static Dictionary<int, string> DisplayResults()
        {
            var displayResults = new Dictionary<int, string>();

            displayResults.Add(1, "Self-Management - You manage yourself well; You take responsibility for your own behavior and well-being.");
            displayResults.Add(2, "Empathy - You are emphatic. You see yourself in someone else’s situation before doing decisions. You tend to listen to other’s voices.");
            displayResults.Add(3, "Self-Awareness - You are conscious of your own character, feelings, motives, and desires. The process can be painful but it leads to greater self-awareness.");
            return displayResults;
        }
    }
}
