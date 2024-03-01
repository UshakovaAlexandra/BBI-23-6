// 7 лаба.
// 6.3
using System;
using System.Collections.Generic;
using System.Linq;

class Country
{
    public string CountryName { get; set; }
    public Dictionary<string, int> Answers { get; set; }

    public Country(string countryName, Dictionary<string, int> answers)
    {
        CountryName = countryName;
        Answers = answers;
    }

    public virtual string GetCountryName()
    {
        return "Страна";
    }

    public void PrintSurveyResults(Dictionary<string, double> topAnswers)
    {
        Console.WriteLine($"Ответы для {GetCountryName()}:");
        if (topAnswers.Count == 0)
        {
            Console.WriteLine("Нет ответов на данный вопрос.");
        }
        else
        {
            Console.WriteLine("Ответ\t\tДоля (%)");
            foreach (KeyValuePair<string, double> answer in topAnswers)
            {
                Console.WriteLine($"{answer.Key}\t\t{answer.Value:F2}");
            }
        }
        Console.WriteLine();
    }
}

class Russia : Country
{
    public Russia(Dictionary<string, int> answers) : base("Россия", answers) { }

    public override string GetCountryName()
    {
        return "Россия";
    }
}

class Japan : Country
{
    public Japan(Dictionary<string, int> answers) : base("Япония", answers) { }

    public override string GetCountryName()
    {
        return "Япония";
    }
}

class Survey
{
    public Dictionary<string, List<string>> Questions { get; set; }

    public Survey(Dictionary<string, List<string>> questions)
    {
        Questions = questions;
    }

    public Dictionary<string, double> GetTopAnswers(Dictionary<string, int> answers)
    {
        Dictionary<string, double> topAnswers = new Dictionary<string, double>();
        int totalAnswers = answers.Values.Sum();
        foreach (var answer in answers)
        {
            topAnswers[answer.Key] = (double)answer.Value / totalAnswers * 100;
        }
        return topAnswers;
    }
}

class Program
{
    static void Main()
    {
        // Получение ответов на вопросы
        var surveyQuestions = new Dictionary<string, List<string>>
        {
            { "Животные", new List<string> { "Кошка", "Собака", "Рыба", "Рыба", "Кошка", "Кролик", "Кошка" } },
            { "Черты характера", new List<string> { "Самообладание", "Вежливость", "Трудолюбие", "Трудолюбие", "Трудолюбие" } },
            { "Понятия", new List<string> { "Чайная церемония", "Сакура", "Сакура", "Суши", "Самурай", "Суши", "Сакура" } }
        };
        var survey = new Survey(surveyQuestions);

        // Создание объектов для стран
        var russiaAnswers = new Dictionary<string, int> { { "Кошка", 3 }, { "Рыба", 2 }, { "Кролик", 1 } };
        var russia = new Russia(russiaAnswers);

        var japanAnswers = new Dictionary<string, int> { { "Сакура", 4 }, { "Суши", 2 }, { "Самурай", 1 } };
        var japan = new Japan(japanAnswers);

        // Получение ответов для каждой страны
        var topRussiaAnswers = survey.GetTopAnswers(russia.Answers);
        var topJapanAnswers = survey.GetTopAnswers(japan.Answers);

        // Вывод результатов для каждой страны
        russia.PrintSurveyResults(topRussiaAnswers);
        japan.PrintSurveyResults(topJapanAnswers);

        // Объединенные ответы
        var combinedAnswers = new Dictionary<string, int>();
        foreach (var question in surveyQuestions)
        {
            foreach (var answer in question.Value)
            {
                if (combinedAnswers.ContainsKey(answer))
                {
                    combinedAnswers[answer]++;
                }
                else
                {
                    combinedAnswers[answer] = 1;
                }
            }
        }
        var topCombinedAnswers = survey.GetTopAnswers(combinedAnswers);

        // Вывод общих результатов
        Console.WriteLine("Общие ответы для обеих стран:");
        foreach (var answer in topCombinedAnswers)
        {
            Console.WriteLine($"{answer.Key}\t\t{answer.Value:F2}");
        }
    }
}
