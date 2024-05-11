using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
abstract class Task
{
    public Task(string text) { }
    public abstract void ParseText(string text); // все разные

}

class Task_2 : Task
{
    private string _text;
    public Task_2(string text) : base(text)
    {
        _text = text;
    }
    public override void ParseText(string text)
    {
        _text = ReverseWordsAndKeepPunctuation(text);
    }
    public override string ToString()
    {
        return _text;
    }
    private string ReverseWordsAndKeepPunctuation(string text)
    {
        var Punctuation = new HashSet<char> { '.', ',', '!', '?', ':', ';', ' ' };
        var Words = new List<string>();
        var CurrentWord = new StringBuilder(); // построение текущего слова
        foreach (var word in text)
        {
            if (Punctuation.Contains(word))
            {
                Words.Add(ReverseWord(CurrentWord.ToString()));
                Words.Add(word.ToString());
                CurrentWord.Clear();
            }
            else
            {
                CurrentWord.Append(word);
            }
        }
        if (CurrentWord.Length > 0)
        {
            Words.Add(ReverseWord(CurrentWord.ToString()));
        }
        return string.Join("", Words);
    }
    private string ReverseWord(string word)
    {
        var chars = word.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}


class Task_4 : Task
{
    private string _text;
    private int _difficulty;
    public Task_4(string text) : base(text)
    {
        _text = text;
    }
    public override void ParseText(string text)
    {
        _difficulty = 0;
        char[] chartext = text.ToCharArray();
        foreach (char c in chartext)
        {
            if (Char.IsPunctuation(c))
            {
                _difficulty++;
            }
            else if (Char.IsWhiteSpace(c))
            {
                _difficulty++;
            }
        }
    }
    public override string ToString()
    {
        return $"Сложность этого предложения: {_difficulty}";
    }
}

class Task_6 : Task
{
    private string _text;
    private int[] _syllablesCount;

    public Task_6(string text) : base(text)
    {
        _text = text;
    }

    public override void ParseText(string text)
    {
        _syllablesCount = new int[10]; // Ограничение сложности до 10 слогов

        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            int Syllables = 0;
            bool isvowel = false;
            foreach (char Letter in word)
            {
                if (IsVowel(Letter))
                {
                    if (!isvowel)
                    {
                        Syllables++;
                        isvowel = true;
                    }
                }
                else
                {
                    isvowel = false;
                }
            }

            if (Syllables < _syllablesCount.Length) // Проверка на ограничение сложности
            {
                _syllablesCount[Syllables]++;
            }
        }
    }

    private bool IsVowel(char Letter)
    {
        return "аеёиоуыэюя".Contains(Letter.ToString().ToLower());
    }

    public override string ToString()
    {
        string Result = "";
        for (int i = 0; i < _syllablesCount.Length; i++)
        {
            Result += $"{i + 1}-сложных слов: {_syllablesCount[i]} \n";
        }

        return Result;
    }
}



class Task_8 : Task
{
    private string _text;
    public Task_8(string text) : base(text) { }
    public override string ToString()
    {
        return _text;
    }
    public override void ParseText(string text)
    {
        string[] Words = text.Split();
        List<string> List_lines = new List<string>();
        string CurrentLine = "";
        foreach (string word in Words)
        {
            if (CurrentLine.Length + word.Length > 50)
            {
                List_lines.Add(CurrentLine);
                CurrentLine = "";
            }
            CurrentLine += word + " ";
        }
        List_lines.Add(CurrentLine);
        for (int i = 0; i < List_lines.Count; i++)
        {
            if (List_lines[i].Length > 0)
            {
                List_lines[i] = List_lines[i].Remove(List_lines[i].Length - 1);
                List_lines[i] = ParseLine(List_lines[i]);
                List_lines[i] += "\n";
            }
        }
        foreach (string line in List_lines)
        {
            _text += line;
        }
    }
    public string ParseLine(string line)
    {
        string[] All_words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int spaces_fill = 50 - line.Length; // Количество пробелов, которые нужно добавить
        if (All_words.Length > 1)
        {
            int Add_spaces = spaces_fill / (All_words.Length - 1); // Количество пробелов между каждым словом для добавления
            int ExtraSpaces = spaces_fill % (All_words.Length - 1); //  Количество дополнительных пробелов (аналог по ширине)
            for (int i = 0; i < All_words.Length - 1; i++)
            {
                All_words[i] += new string(' ', Add_spaces);
                if (ExtraSpaces > 0)
                {
                    All_words[i] += ' ';
                    ExtraSpaces--;
                }
            }
        }
        return string.Join(" ", All_words);
    }
}

class Task_9 : Task // сжатие текста 
{
    private string _text;
    public string crypted_text;
    private Dictionary<string, string> _codes;
    public Task_9(string text) : base(text)
    {
        _text = text;
        _codes = new Dictionary<string, string>();
    }
    public override string ToString()
    {
        return _text;
    }
    public override void ParseText(string text)
    {
        var Sequences = new Dictionary<string, int>(); //для счета 
        for (int i = 0; i < text.Length - 1; i++)
        {
            var Sequence = text.Substring(i, 2); // пара из двух символов 
            if (!Sequences.ContainsKey(Sequence)) // отсутствует ли пара в тексте 
            {
                Sequences[Sequence] = 0;
            }
            Sequences[Sequence]++;
        }
        char code = '!';
        foreach (var Sequence in Sequences)
        {
            if (!_codes.ContainsKey(Sequence.Key) && _codes.Count < 10) // отсутствует ли ключ Sequence.Key в словаре _codes + кол-во пар меньше 10
            {
                _codes[Sequence.Key] = code.ToString();
                code++;
            }
        }
    }
    public void EncodeText()
    {
        foreach (var codePair in _codes)
        {
            _text = _text.Replace(codePair.Key, codePair.Value);
        }
        crypted_text = _text;
    }
}



class Task_10 : Task
{
    private string _text;
    private Dictionary<string, string> _codes; //для соответствий
    public Task_10(string text) : base(text)
    {
        _text = text;
        _codes = new Dictionary<string, string>();
    }
    public override string ToString()
    {
        return _text;
    }
    public override void ParseText(string text)
    {
        var Sequences = new Dictionary<string, int>(); //для счета
        for (int i = 0; i < text.Length - 1; i++)
        {
            var Sequence = text.Substring(i, 2); // пара из двух символов
            if (!Sequences.ContainsKey(Sequence)) // отсутствует ли пара из в тексте
            {
                Sequences[Sequence] = 0;
            }
            Sequences[Sequence]++;
        }
        char code = '!';
        foreach (var Sequence in Sequences)
        {
            if (!_codes.ContainsKey(Sequence.Key)) // отсутствует ли ключ Sequence.Key в словаре _codes
            {
                _codes[Sequence.Key] = code.ToString();
                code++;
            }
        }
    }
    public void DecodeText()
    {
        foreach (var codePair in _codes)
        {
            _text = _text.Replace(codePair.Value, codePair.Value);
        }
    }
}
class Program
{
    public static void Main()
    {
        string text = "Первое слово, второе слово. первое слово::::";

        Task_2 task2 = new Task_2(text);
        task2.ParseText(text);
        Console.WriteLine(task2.ToString());

        Task_4 task4 = new Task_4(text);
        task4.ParseText(text);
        Console.WriteLine(task4.ToString());

        Task_6 task6 = new Task_6(text);
        task6.ParseText(text);
        Console.WriteLine(task6.ToString());

        Task_8 task8 = new Task_8(text);
        task8.ParseText(text);
        Console.WriteLine(task8.ToString());

        Task_9 task9 = new Task_9(text);
        task9.ParseText(text);
        task9.EncodeText();
        Console.WriteLine("Зашифрованный текст:");
        Console.WriteLine(task9.ToString());

        Console.WriteLine();

        Task_10 task10 = new Task_10(text);
        task10.ParseText(text);
        task10.DecodeText();
        Console.WriteLine("Расшифрованный текст:");
        Console.WriteLine(task10.ToString());
        Console.ReadKey();
    }
}