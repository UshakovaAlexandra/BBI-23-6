// 7 лаба защита
//1
using System;
using System.Collections.Generic;

namespace SortingParticipants
{
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
            private set { lastName = value; }
        }

        public string Society
        {
            get { return society; }
            private set { society = value; }
        }

        public double FirstAttempt
        {
            get { return firstAttempt; }
            private set { firstAttempt = value; }
        }

        public double SecondAttempt
        {
            get { return secondAttempt; }
            private set { secondAttempt = value; }
        }

        public bool Disqualified
        {
            get { return disqualified; }
            private set { disqualified = value; }
        }
        public Participant(string lastName, string society, double firstAttempt, double secondAttempt)
        {
            this.lastName = lastName;
            this.society = society;
            this.firstAttempt = firstAttempt;
            this.secondAttempt = secondAttempt;
            this.disqualified = false;
        }
        public double GetTotalDistance()
        {
            return FirstAttempt + SecondAttempt;
        }

        public void Disqualify()
        {
            disqualified = true;
        }

        public static void QuickSort(List<Participant> participants, int left, int right)
        {
            if (left < right)
            {
                int partitionIndex = Partition(participants, left, right);

                QuickSort(participants, left, partitionIndex - 1);
                QuickSort(participants, partitionIndex + 1, right);
            }
        }

        private static int Partition(List<Participant> participants, int left, int right)
        {
            Participant pivot = participants[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (participants[j].GetTotalDistance() > pivot.GetTotalDistance())
                {
                    i++;
                    Participant temp = participants[i];
                    participants[i] = participants[j];
                    participants[j] = temp;
                }
            }

            Participant temp2 = participants[i + 1];
            participants[i + 1] = participants[right];
            participants[right] = temp2;

            return i + 1;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Participant> participants = new List<Participant>();

            // Adding participants to the list
            participants.Add(new Participant("Иванов", "Общество 1", 7.2, 7.5));
            participants.Add(new Participant("Петров", "Общество 2", 6.8, 7.0));
            participants.Add(new Participant("Сидоров", "Общество 1", 7.0, 7.2));

            // Disqualifying a participant
            DisqualifyParticipant(participants, "Петров");

            // Sorting using QuickSort
            Participant.QuickSort(participants, 0, participants.Count - 1);

            // Displaying the protocol in table format
            Console.WriteLine("Место\tФамилия\tОбщество\tРезультат");
            for (int i = 0; i < participants.Count; i++)
            {
                Participant participant = participants[i];
                Console.WriteLine($"{i + 1}\t{participant.LastName}\t{participant.Society}\t{participant.GetTotalDistance()}");
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
}
//2
using System;
using System.Collections.Generic;

class Person
{
    public string FullName { get; private set; }

    public Person(string fullName)
    {
        this.FullName = fullName;
    }
}

class Student : Person
{
    public string StudentID { get; private set; }
    public List<double> ExamScores { get; set; }

    public Student(string fullName) : base(fullName)
    {
        this.StudentID = GenerateStudentID();
    }

    private string GenerateStudentID()
    {
        Random rand = new Random();
        return rand.Next(10000, 99999).ToString();
    }

    public double GetAverageScore()
    {
        double sum = 0;
        foreach (double score in ExamScores)
        {
            sum += score;
        }
        return sum / ExamScores.Count;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        // Добавление студентов в список
        students.Add(new Student("Иванов Михаил Романович") { ExamScores = new List<double> { 4.5, 3.8, 3.2, 3.7 } });
        students.Add(new Student("Сидоров Валерий Иванович") { ExamScores = new List<double> { 4.2, 4.0, 4.5, 3.9 } });
        students.Add(new Student("Смирнов Александр Сергеевич") { ExamScores = new List<double> { 3.9, 4.1, 4.3, 4.4 } });
        students.Add(new Student("Николаева Зинаида Петровна") { ExamScores = new List<double> { 3.9, 4.1, 4.3, 4.2 } });

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
//3
using System;
using System.Collections.Generic;
using System.Linq;

class Country
{
    public List<string> Answers { get; private set; }

    public virtual string GetCountryName()
    {
        return "Страна";
    }

    public Country(List<string> answers)
    {
        Answers = answers;
    }
}

class Russia : Country
{
    public override string GetCountryName()
    {
        return "Россия";
    }

    public Russia(List<string> answers) : base(answers)
    {
    }
}

class Japan : Country
{
    public override string GetCountryName()
    {
        return "Япония";
    }

    public Japan(List<string> answers) : base(answers)
    {
    }
}

class Survey
{
    public List<string> AnimalAnswers { get; private set; }
    public List<string> CharacterTraitAnswers { get; private set; }
    public List<string> ConceptAnswers { get; private set; }

    public Survey(List<string> animalAnswers, List<string> characterTraitAnswers, List<string> conceptAnswers)
    {
        AnimalAnswers = animalAnswers;
        CharacterTraitAnswers = characterTraitAnswers;
        ConceptAnswers = conceptAnswers;
    }

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
        // Создание объекта опроса
        Survey survey = new Survey(new List<string> { "Кошка", "Собака", "Рыба", "Рыба", "Кошка", "Кролик", "Кошка" },
                                   new List<string> { "Самообладание", "Вежливость", "Трудолюбие", "Трудолюбие", "Трудолюбие" },
                                   new List<string> { "Чайная церемония", "Сакура", "Сакура", "Суши", "Самурай", "Суши", "Сакура" });

        // Создание объектов для стран
        Russia russia = new Russia(survey.AnimalAnswers);
        Japan japan = new Japan(survey.ConceptAnswers);

        // Получение ответов для каждой страны
        Dictionary<string, double> topRussiaAnswers = survey.GetTopAnswers(russia.Answers);
        Dictionary<string, double> topJapanAnswers = survey.GetTopAnswers(japan.Answers);

        // Вывод результатов для каждой страны
        Console.WriteLine($"Ответы для {russia.GetCountryName()}:");
        PrintTopAnswers(topRussiaAnswers);

        Console.WriteLine($"Ответы для {japan.GetCountryName()}:");
        PrintTopAnswers(topJapanAnswers);

        // Объединенные ответы
        List<string> combinedAnswers = new List<string>();
        combinedAnswers.AddRange(russia.Answers);
        combinedAnswers.AddRange(japan.Answers);

        Dictionary<string, double> topCombinedAnswers = survey.GetTopAnswers(combinedAnswers);

        // Вывод общих результатов
        Console.WriteLine("Общие ответы для обеих стран:");
        PrintTopAnswers(topCombinedAnswers);
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
