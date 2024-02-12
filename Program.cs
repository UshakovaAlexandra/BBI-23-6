// лаба 6(первая лаба 2 семестра)
// задача 1
using System;
using System.Collections.Generic;

class Participant
{
    private string lastName;
    private string society;
    private double firstAttempt;
    private double secondAttempt;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Society
    {
        get { return society; }
        set { society = value; }
    }

    public double FirstAttempt
    {
        get { return firstAttempt; }
        set { firstAttempt = value; }
    }

    public double SecondAttempt
    {
        get { return secondAttempt; }
        set { secondAttempt = value; }
    }

    public double GetTotalDistance()
    {
        return FirstAttempt + SecondAttempt;
    }
}

class Program
{
    static void Main()
    {
        List<Participant> participants = new List<Participant>();

        // Добавление участников в список
        participants.Add(new Participant { LastName = "Вавилов", Society = "Общество 1", FirstAttempt = 7.2, SecondAttempt = 7.5 });
        participants.Add(new Participant { LastName = "Конюхов", Society = "Общество 2", FirstAttempt = 6.8, SecondAttempt = 7.0 });
        participants.Add(new Participant { LastName = "Смирнов", Society = "Общество 1", FirstAttempt = 7.0, SecondAttempt = 6.4 });

        // Сортировка результатов по сумме двух попыток
        participants.Sort((p1, p2) => p2.GetTotalDistance().CompareTo(p1.GetTotalDistance()));

        // Вывод протокола в виде таблицы
        Console.WriteLine("Место\tФамилия\tОбщество\tРезультат");
        for (int i = 0; i < participants.Count; i++)
        {
            Participant participant = participants[i];
            Console.WriteLine($"{i + 1}\t{participant.LastName}\t{participant.Society}\t{participant.GetTotalDistance()}");
        }
    }
}
// задача 1 2 уровень
using System;
using System.Collections.Generic;

class Student
{
    private string name;
    private List<double> examScores;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<double> ExamScores
    {
        get { return examScores; }
        set { examScores = value; }
    }

    public double GetAverageScore()
    {
        double sum = 0;
        foreach (double score in examScores)
        {
            sum += score;
        }
        return sum / examScores.Count;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        // Добавление студентов в список
        students.Add(new Student { Name = "Васечкин", ExamScores = new List<double> { 4.5, 4.8, 4.2, 4.7 } });
        students.Add(new Student { Name = "Филатова", ExamScores = new List<double> { 4.2, 4.0, 4.5, 3.9 } });
        students.Add(new Student { Name = "Черниговцев", ExamScores = new List<double> { 3.9, 4.1, 4.3, 4.4 } });
        students.Add(new Student { Name = "Назарова", ExamScores = new List<double> { 3.9, 3.1, 4.3, 4.2 } });

        // Фильтрация студентов по среднему баллу
        List<Student> filteredStudents = new List<Student>();
        foreach (Student student in students)
        {
            if (student.GetAverageScore() >= 4)
            {
                filteredStudents.Add(student);
            }
        }

        // Сортировка студентов по убыванию среднего балла
        filteredStudents.Sort((s1, s2) => s2.GetAverageScore().CompareTo(s1.GetAverageScore()));

        // Вывод результатов в виде таблицы
        Console.WriteLine("Студент\t\tСредний балл");
        foreach (Student student in filteredStudents)
        {
            Console.WriteLine($"{student.Name}\t\t{student.GetAverageScore()}");
        }
    }
}
// 6.3
using System;
using System.Collections.Generic;

class Survey
{
    private List<string> animalAnswers;
    private List<string> characterTraitAnswers;
    private List<string> conceptAnswers;

    public List<string> AnimalAnswers
    {
        get { return animalAnswers; }
        set { animalAnswers = value; }
    }

    public List<string> CharacterTraitAnswers
    {
        get { return characterTraitAnswers; }
        set { characterTraitAnswers = value; }
    }

    public List<string> ConceptAnswers
    {
        get { return conceptAnswers; }
        set { conceptAnswers = value; }
    }

    public Dictionary<string, double> GetTopAnswers(List<string> answers)
    {
        Dictionary<string, int> answerCounts = new Dictionary<string, int>();

        // Подсчет количества каждого ответа
        foreach (string answer in answers)
        {
            if (answerCounts.ContainsKey(answer))
            {
                answerCounts[answer]++;
            }
            else
            {
                answerCounts[answer] = 1;
            }
        }

        // Сортировка ответов по количеству по убыванию
        List<string> sortedAnswers = new List<string>(answerCounts.Keys);
        sortedAnswers.Sort((a1, a2) => answerCounts[a2].CompareTo(answerCounts[a1]));

        // Получение первых пяти наиболее часто встречающихся ответов
        Dictionary<string, double> topAnswers = new Dictionary<string, double>();
        int totalCount = answers.Count;
        int count = Math.Min(5, sortedAnswers.Count);
        for (int i = 0; i < count; i++)
        {
            string answer = sortedAnswers[i];
            double percentage = (double)answerCounts[answer] / totalCount * 100;
            topAnswers[answer] = percentage;
        }

        return topAnswers;
    }
}

class Program
{
    static void Main()
    {
        Survey survey = new Survey();

        // Получение ответов на вопросы
        survey.AnimalAnswers = new List<string> { "Кошка", "Собака", "Рыба", "Рыба", "Кошка", "Кролик", "Кошка" };
        survey.CharacterTraitAnswers = new List<string> { "Самообладание", "Вежливость", "Трудолюбие", "Трудолюбие", "Трудолюбие" };
        survey.ConceptAnswers = new List<string> { "Чайная церемония", "Сакура", "Сакура", "Суши", "Самурай", "Суши", "Сакура" };

        // Получение первых пяти наиболее часто встречающихся ответов и их доли в процентах
        Dictionary<string, double> topAnimalAnswers = survey.GetTopAnswers(survey.AnimalAnswers);
        Dictionary<string, double> topCharacterTraitAnswers = survey.GetTopAnswers(survey.CharacterTraitAnswers);
        Dictionary<string, double> topConceptAnswers = survey.GetTopAnswers(survey.ConceptAnswers);

        // Вывод результатов
        Console.WriteLine("Вопрос а): Какое животное Вы связываете с Японией и японцами?");
        PrintTopAnswers(topAnimalAnswers);

        Console.WriteLine("Вопрос б): Какая черта характера присуща японцам больше всего?");
        PrintTopAnswers(topCharacterTraitAnswers);

        Console.WriteLine("Вопрос в): Какай неодушевленный предмет или понятие Вы связываете с Японией?");
        PrintTopAnswers(topConceptAnswers);
    }

    static void PrintTopAnswers(Dictionary<string, double> topAnswers)
    {
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
