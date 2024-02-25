// 7 лаба.
// 1.1
using System;
using System.Collections.Generic;
using System.Linq;

class Participant
{
    private string lastName;
    private string society;
    private double firstAttempt;
    private double secondAttempt;
    private bool disqualified;

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

    public bool Disqualified
    {
        get { return disqualified; }
        set { disqualified = value; }
    }

    public double GetTotalDistance()
    {
        return FirstAttempt + SecondAttempt;
    }

    public void Disqualify()
    {
        disqualified = true;
    }

    public void PrintParticipantInfo()
    {
        Console.WriteLine($"{LastName}\t{Society}\t{GetTotalDistance()}");
    }
}

class Program
{
    static void Main()
    {
        List<Participant> participants = new List<Participant>();

        // Добавление участников в список
        participants.Add(new Participant { LastName = "Иванов", Society = "Общество 1", FirstAttempt = 7.2, SecondAttempt = 7.5 });
        participants.Add(new Participant { LastName = "Петров", Society = "Общество 2", FirstAttempt = 7.8, SecondAttempt = 8.0 });
        participants.Add(new Participant { LastName = "Сидоров", Society = "Общество 1", FirstAttempt = 6.0, SecondAttempt = 6.2 });

        // Дисквалификация участника
        DisqualifyParticipant(participants, "Сидоров");

        // Сортировка результатов по сумме двух попыток и исключение дисквалифицированных участников
        participants = participants.Where(p => !p.Disqualified).OrderByDescending(p => p.GetTotalDistance()).ToList();

        // Вывод протокола
        Console.WriteLine("Место\tФамилия\tОбщество\tРезультат");
        for (int i = 0; i < participants.Count; i++)
        {
            Participant participant = participants[i];
            participant.PrintParticipantInfo();
        }
    }

    static void DisqualifyParticipant(List<Participant> participants, string lastName)
    {
        Participant participantToDisqualify = participants.Find(p => p.LastName == lastName);
        if (participantToDisqualify != null)
        {
            participantToDisqualify.Disqualify();
        }
    }
}
// 1.2
using System;
using System.Collections.Generic;

class Person
{
    private string fullName;

    public string FullName
    {
        get { return fullName; }
    }

    public Person(string fullName)
    {
        this.fullName = fullName;
    }
}

class Student : Person
{
    public string StudentID { get; set; }
    public List<double> ExamScores { get; set; }

    public double GetAverageScore()
    {
        double sum = 0;
        foreach (double score in ExamScores)
        {
            sum += score;
        }
        return sum / ExamScores.Count;
    }

    public Student(string fullName, string studentID, List<double> examScores) : base(fullName)
    {
        StudentID = studentID;
        ExamScores = examScores;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        // Добавление студентов в список
        students.Add(new Student("Иванов Михаил Романович", "12345", new List<double> { 4.5, 3.8, 3.2, 3.7 }));
        students.Add(new Student("Сидоров Валерий Иванович", "54321", new List<double> { 4.2, 4.0, 4.5, 3.9 }));
        students.Add(new Student("Смирнов Александр Сергеевич", "98765", new List<double> { 3.9, 4.1, 4.3, 4.4 }));
        students.Add(new Student("Николаева Зинаида Петровна", "13579", new List<double> { 3.9, 4.1, 4.3, 4.2 }));

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
        Console.WriteLine("ФИО\t\t\t\tНомер студ. билета\tСредний балл");
        foreach (Student student in filteredStudents)
        {
            Console.WriteLine($"{student.FullName}\t\t{student.StudentID}\t\t\t{student.GetAverageScore()}");
        }
    }
}
// 6.3
using System;
using System.Collections.Generic;
using System.Linq;

class Country
{
    public string CountryName { get; set; }
    public List<string> Answers { get; set; }

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
    public override string GetCountryName()
    {
        return "Россия";
    }
}

class Japan : Country
{
    public override string GetCountryName()
    {
        return "Япония";
    }
}

class Survey
{
    public List<string> AnimalAnswers { get; set; }
    public List<string> CharacterTraitAnswers { get; set; }
    public List<string> ConceptAnswers { get; set; }

    public Dictionary<string, double> GetTopAnswers(List<string> answers)
    {
        Dictionary<string, double> topAnswers = new Dictionary<string, double>();

        foreach (var answer in answers)
        {
            if (topAnswers.ContainsKey(answer))
            {
                topAnswers[answer]++;
            }
            else
            {
                topAnswers[answer] = 1;
            }
        }

        foreach (var answer in topAnswers.Keys.ToList())
        {
            topAnswers[answer] = (topAnswers[answer] / answers.Count) * 100;
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

        // Создание объектов для стран
        Country russia = new Russia { CountryName = "Россия", Answers = survey.AnimalAnswers };
        Country japan = new Japan { CountryName = "Япония", Answers = survey.ConceptAnswers };

        // Получение ответов для каждой страны
        Dictionary<string, double> topRussiaAnswers = survey.GetTopAnswers(russia.Answers);
        Dictionary<string, double> topJapanAnswers = survey.GetTopAnswers(japan.Answers);

        // Вывод результатов для каждой страны
        russia.PrintSurveyResults(topRussiaAnswers);
        japan.PrintSurveyResults(topJapanAnswers);

        // Объединенные ответы
        List<string> combinedAnswers = new List<string>();
        combinedAnswers.AddRange(russia.Answers);
        combinedAnswers.AddRange(japan.Answers);

        Dictionary<string, double> topCombinedAnswers = survey.GetTopAnswers(combinedAnswers);

        // Вывод общих результатов
        Console.WriteLine("Общие ответы для обеих стран:");
        foreach (var answer in topCombinedAnswers)
        {
            Console.WriteLine($"{answer.Key}\t\t{answer.Value:F2}");
        }
    }
}
