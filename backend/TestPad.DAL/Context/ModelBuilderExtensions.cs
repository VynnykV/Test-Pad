using Microsoft.EntityFrameworkCore;
using TestPad.Common.Extensions;
using TestPad.DAL.Entities;

namespace TestPad.DAL.Context;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var users = GenerateUsers();
        var tests = GenerateTests(users);
        var questions = GenerateQuestions(tests);
        var answers = GenerateAnswers(questions);

        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Test>().HasData(tests);
        modelBuilder.Entity<Question>().HasData(questions);
        modelBuilder.Entity<Answer>().HasData(answers);
    }

    private static IList<User> GenerateUsers()
    {
        return new List<User>()
        {
            new User()
            {
                Id = 1,
                Email = "tarreau@live.com",
                UserName = "vulcanswimsuit"
            },
            new User()
            {
                Id = 2,
                Email = "yumpy@att.net",
                UserName = "investsort"
            }
        };
    }

    private static IList<Test> GenerateTests(IList<User> users)
    {
        return new List<Test>()
        {
            new Test()
            {
                Id = 1,
                Title = "Present Simple",
                AuthorId = users.RandomElement().Id
            },
            new Test()
            {
                Id = 2,
                Title = "Past Simple",
                AuthorId = users.RandomElement().Id
            },
            new Test()
            {
                Id = 3,
                Title = "Future Simple",
                AuthorId = users.RandomElement().Id
            }
        };
    }
    
    private static IList<Question> GenerateQuestions(IList<Test> tests)
    {
        return new List<Question>()
        {
            new Question()
            {
                Id = 1,
                Content = "Mark ... English.",
                TestId = tests[0].Id
            },
            new Question()
            {
                Id = 2,
                Content = "They ... orange juice.",
                TestId = tests[0].Id
            },
            new Question()
            {
                Id = 3,
                Content = "A pianist ... the piano.",
                TestId = tests[0].Id
            },
            new Question()
            {
                Id = 4,
                Content = "Mark ... cakes.",
                TestId = tests[0].Id
            },
            new Question()
            {
                Id = 5,
                Content = "We ... near the school.",
                TestId = tests[0].Id
            },
            new Question()
            {
                Id = 6,
                Content = "They got home very late ... .",
                TestId = tests[1].Id
            },
            new Question()
            {
                Id = 7,
                Content = "My father lived there when he ... .",
                TestId = tests[1].Id
            },
            new Question()
            {
                Id = 8,
                Content = "He ... to me when he was younger.",
                TestId = tests[1].Id
            },
            new Question()
            {
                Id = 9,
                Content = "All of a sudden, he ... the ball.",
                TestId = tests[1].Id
            },
            new Question()
            {
                Id = 10,
                Content = "She never ... alone.",
                TestId = tests[1].Id
            },
            new Question()
            {
                Id = 11,
                Content = "I can’t come over today. - Okay, then ... you tomorrow.",
                TestId = tests[2].Id
            },
            new Question()
            {
                Id = 12,
                Content = "My car needs to be repaired. ... do you think ... cost?",
                TestId = tests[2].Id
            },
            new Question()
            {
                Id = 13,
                Content = "I’ve got some incredible news. You ... what’s happened.",
                TestId = tests[2].Id
            },
            new Question()
            {
                Id = 14,
                Content = "I think, it ... very hot tomorrow.",
                TestId = tests[2].Id
            },
            new Question()
            {
                Id = 15,
                Content = "I’m afraid the car ... start.",
                TestId = tests[2].Id
            }
        };
    }
    
    private static IList<Answer> GenerateAnswers(IList<Question> questions)
    {
        return new List<Answer>()
        {
            new Answer()
            {
                Id = 1,
                Content = "speaks",
                IsCorrect = true,
                QuestionId = questions[0].Id
            },
            new Answer()
            {
                Id = 2,
                Content = "don't speak",
                QuestionId = questions[0].Id
            },
            new Answer()
            {
                Id = 3,
                Content = "speak",
                QuestionId = questions[0].Id
            },
            new Answer()
            {
                Id = 4,
                Content = "drinks",
                QuestionId = questions[1].Id
            },
            new Answer()
            {
                Id = 5,
                Content = "doesn't drink",
                QuestionId = questions[1].Id
            },
            new Answer()
            {
                Id = 6,
                Content = "drink",
                IsCorrect = true,
                QuestionId = questions[1].Id
            },
            new Answer()
            {
                Id = 7,
                Content = "play",
                QuestionId = questions[2].Id
            },
            new Answer()
            {
                Id = 8,
                Content = "plays",
                IsCorrect = true,
                QuestionId = questions[2].Id
            },
            new Answer()
            {
                Id = 9,
                Content = "don't play",
                QuestionId = questions[2].Id
            },
            new Answer()
            {
                Id = 10,
                Content = "don't love",
                QuestionId = questions[3].Id
            },
            new Answer()
            {
                Id = 11,
                Content = "doesn't love",
                IsCorrect = true,
                QuestionId = questions[3].Id
            },
            new Answer()
            {
                Id = 12,
                Content = "love",
                QuestionId = questions[3].Id
            },
            new Answer()
            {
                Id = 13,
                Content = "live",
                IsCorrect = true,
                QuestionId = questions[4].Id
            },
            new Answer()
            {
                Id = 14,
                Content = "lives",
                QuestionId = questions[4].Id
            },
            new Answer()
            {
                Id = 15,
                Content = "doesn't live",
                QuestionId = questions[4].Id
            },
            new Answer()
            {
                Id = 16,
                Content = "last night",
                IsCorrect = true,
                QuestionId = questions[5].Id
            },
            new Answer()
            {
                Id = 17,
                Content = "long ago",
                QuestionId = questions[5].Id
            },
            new Answer()
            {
                Id = 18,
                Content = "next Tuesday",
                QuestionId = questions[5].Id
            },
            new Answer()
            {
                Id = 19,
                Content = "was a kid",
                IsCorrect = true,
                QuestionId = questions[6].Id
            },
            new Answer()
            {
                Id = 20,
                Content = "meets my mother",
                QuestionId = questions[6].Id
            },
            new Answer()
            {
                Id = 21,
                Content = "going to school",
                QuestionId = questions[6].Id
            },
            new Answer()
            {
                Id = 22,
                Content = "didn't lie",
                IsCorrect = true,
                QuestionId = questions[7].Id
            },
            new Answer()
            {
                Id = 23,
                Content = "didn't never lie",
                QuestionId = questions[7].Id
            },
            new Answer()
            {
                Id = 24,
                Content = "never lie",
                QuestionId = questions[7].Id
            },
            new Answer()
            {
                Id = 25,
                Content = "dropped",
                IsCorrect = true,
                QuestionId = questions[8].Id
            },
            new Answer()
            {
                Id = 26,
                Content = "droped",
                QuestionId = questions[8].Id
            },
            new Answer()
            {
                Id = 27,
                Content = "drop",
                QuestionId = questions[8].Id
            },
            new Answer()
            {
                Id = 28,
                Content = "stayed",
                IsCorrect = true,
                QuestionId = questions[9].Id
            },
            new Answer()
            {
                Id = 29,
                Content = "didn't stay",
                QuestionId = questions[9].Id
            },
            new Answer()
            {
                Id = 30,
                Content = "not stayed",
                QuestionId = questions[9].Id
            },
            new Answer()
            {
                Id = 31,
                Content = "I'll see",
                IsCorrect = true,
                QuestionId = questions[10].Id
            },
            new Answer()
            {
                Id = 32,
                Content = "I'm see",
                QuestionId = questions[10].Id
            },
            new Answer()
            {
                Id = 33,
                Content = "I've seen",
                QuestionId = questions[10].Id
            },
            new Answer()
            {
                Id = 34,
                Content = "How much, it will",
                IsCorrect = true,
                QuestionId = questions[11].Id
            },
            new Answer()
            {
                Id = 35,
                Content = "How many, it will",
                QuestionId = questions[11].Id
            },
            new Answer()
            {
                Id = 36,
                Content = "How much, will it",
                QuestionId = questions[11].Id
            },
            new Answer()
            {
                Id = 37,
                Content = "will never believe",
                IsCorrect = true,
                QuestionId = questions[12].Id
            },
            new Answer()
            {
                Id = 38,
                Content = "will never believe",
                QuestionId = questions[12].Id
            },
            new Answer()
            {
                Id = 39,
                Content = "won’t never believe",
                QuestionId = questions[12].Id
            },
            new Answer()
            {
                Id = 40,
                Content = "will be",
                IsCorrect = true,
                QuestionId = questions[13].Id
            },
            new Answer()
            {
                Id = 41,
                Content = "shall be",
                QuestionId = questions[13].Id
            },
            new Answer()
            {
                Id = 42,
                Content = "will been",
                QuestionId = questions[13].Id
            },
            new Answer()
            {
                Id = 43,
                Content = "will not",
                IsCorrect = true,
                QuestionId = questions[14].Id
            },
            new Answer()
            {
                Id = 44,
                Content = "shan't",
                QuestionId = questions[14].Id
            },
            new Answer()
            {
                Id = 45,
                Content = "won't not",
                QuestionId = questions[14].Id
            }
        };
    }
}