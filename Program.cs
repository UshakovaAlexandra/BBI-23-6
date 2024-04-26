using System.Collections.Generic;
using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

abstract class Task
{
    protected string text = "";
    public string Text
    {
        get => text;
        protected set => text = value;
    }

    public virtual void Solution() { }
    public Task(string text)
    {
        this.text = text;
    }
}
class Task1 : Task
{
    private int answer;
    public int Answer
    {
        get => answer;
        protected set => answer = value;
    }
    [JsonConstructor]
    public Task1(string text) : base(text)
    {
        answer = 0;

    }
    public override void Solution()
    {
        string input = "Мне нравится путешествовать, поэтому текст о моей самой любимой стране.Испания просто поразительная страна, так красиво, тепло и атмосферно. Мы с родителями побывали почти во всех городах этой прекрасной страны, но город Салоу навсегда занимает первое место в моем сердце.";
        char mostCommonLetter = FindMostCommonLetter(input);

        Console.WriteLine($"Most common letter: {mostCommonLetter}");
    }

    static char FindMostCommonLetter(string text)
    {
        var letterFrequency = text
            .Where(char.IsLetter)
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        char mostCommonLetter = letterFrequency
            .OrderByDescending(kv => kv.Value)
            .Select(kv => kv.Key)
            .FirstOrDefault();

        return mostCommonLetter;
        
    }

}

class Task2 : Task
{
    private List<string> answer;
    public List<string> Answer
    {
        get => answer;
    }
    [JsonConstructor]
    public Task2(string text) : base(text)
    {
        answer = new List<string>();

    }
    public override void Solution()
    {
        string inputText = "Мне нравится путешествовать, поэтому текст о моей самой любимой стране.Испания просто поразительная страна, так красиво, тепло и атмосферно. Мы с родителями побывали почти во всех городах этой прекрасной страны, но город Салоу навсегда занимает первое место в моем сердце.";

        string[] sentences = inputText.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> centralWords = new List<string>();

        foreach (var sentence in sentences)
        {
            string[] words = Regex.Split(sentence, @"\s+");
            int middleIndex = words.Length / 2;

            if (words.Length % 2 == 0)
            {
                centralWords.Add(words[middleIndex - 1]);
                centralWords.Add(words[middleIndex]);
            }
            else
            {
                centralWords.Add(words[middleIndex]);
            }
        }

        foreach (var word in centralWords)
        {
            Console.WriteLine(word);
        }
    }
}

class JsonIO
{
    public static void Write<T>(T obj, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, obj);
        }
    }
    public static T Read<T>(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<T>(fs);
        }
        return default(T);
    }
}
class Program
{
    static void Main()
    {
        string text = "Мне нравится путешествовать, поэтому текст о моей самой любимой стране.Испания просто поразительная страна, так красиво, тепло и атмосферно. Мы с родителями побывали почти во всех городах этой прекрасной страны, но город Салоу навсегда занимает первое место в моем сердце. ";
        Task[] tasks = {
            new Task1(text),
            new Task2(text)
        };
        Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);

        string path = @"C:\Users\m2309537\Discord";
        string folderName = "Control work";
        path = Path.Combine(path, folderName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string fileName1 = "cw2_1.json";
        string fileName2 = "cw2_2.json";

        fileName1 = Path.Combine(path, fileName1);
        fileName2 = Path.Combine(path, fileName2);
        if (!File.Exists(fileName1))
        {
            JsonIO.Write<Task1>(tasks[0] as Task1, fileName1);
        }
        else
        {
            var t1 = JsonIO.Read<Task2>(fileName1);
            Console.WriteLine(t1);
        }
        if (!File.Exists(fileName2))
        {
            JsonIO.Write<Task2>(tasks[1] as Task2, fileName2);
        }
        else
        {
            var t2 = JsonIO.Read<Task2>(fileName2);
            Console.WriteLine(t2);
        }

    }
}