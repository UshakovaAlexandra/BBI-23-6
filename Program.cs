using System;

namespace NoteEncryption
{
    public class Encryptor
    {
        public virtual string Encrypt(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return new string(messageArray);
        }
    }
public class Decryptor : Encryptor
    {
        public override string Encrypt(string message)
        {
            return base.Encrypt(message);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Encryptor encryptor = new Encryptor();
            Decryptor decryptor = new Decryptor();

            // Зашифровать сообщение
            string encryptedMessage = encryptor.Encrypt("Hello, world!");
            Console.WriteLine("Encrypted message: " + encryptedMessage);

            // Расшифровать сообщение
            string decryptedMessage = decryptor.Encrypt(encryptedMessage);
            Console.WriteLine("Decrypted message: " + decryptedMessage);
        }
    }
}
// 4
using System;
using System.Collections.Generic;

namespace SentenceComplexity
{
    public interface ISentenceComplexityCalculator
    {
        int CalculateComplexity(string sentence);
    }

    public class DefaultSentenceComplexityCalculator : ISentenceComplexityCalculator
    {
        public int CalculateComplexity(string sentence)
        {
            // Разбить предложение на слова и знаки препинания
            string[] words = sentence.Split(' ', ',', '.', '!', '?', ';', ':');

            // Сосчитать количество слов и знаков препинания
            int wordCount = words.Length;
            int punctuationCount = sentence.Length - sentence.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace(";", "").Replace(":", "").Length;

            // Вернуть сумму количества слов и знаков препинания
            return wordCount + punctuationCount;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создать калькулятор сложности предложения
            ISentenceComplexityCalculator calculator = new DefaultSentenceComplexityCalculator();

            // Получить предложение от пользователя
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Рассчитать сложность предложения
            int complexity = calculator.CalculateComplexity(sentence);

            // Вывести сложность предложения
            Console.WriteLine($"The complexity of the sentence is {complexity}.");
        }
    }
}
// 6
using System;
using System.Collections.Generic;

namespace WordSyllableCounter
{
    public interface IWordSyllableCounter
    {
        Dictionary<int, int> CountSyllables(string text);
    }

    public class DefaultWordSyllableCounter : IWordSyllableCounter
    {
        public Dictionary<int, int> CountSyllables(string text)
        {
            // Разбить текст на слова
            string[] words = text.Split(' ', ',', '.', '!', '?', ';', ':');

            // Создать словарь для хранения количества слогов в словах
            Dictionary<int, int> syllableCounts = new Dictionary<int, int>();

            // Перебрать слова и посчитать количество слогов в каждом слове
            foreach (string word in words)
            {
                int syllableCount = CountSyllablesInWord(word);

                // Если количество слогов еще не встречалось в словаре, добавить его
                if (!syllableCounts.ContainsKey(syllableCount))
                {
                    syllableCounts.Add(syllableCount, 0);
                }

                // Увеличить количество слов с данным количеством слогов
                syllableCounts[syllableCount]++;
            }

            // Вернуть словарь
            return syllableCounts;
        }

        private static int CountSyllablesInWord(string word)
        {
            // Удалить все знаки препинания из слова
            word = word.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace(";", "").Replace(":", "");

            // Разделить слово на слоги
            string[] syllables = word.Split(new[] { 'a', 'e', 'i', 'o', 'u', 'y' }, StringSplitOptions.RemoveEmptyEntries);

            // Вернуть количество слогов
            return syllables.Length;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создать счетчик слогов в словах
            IWordSyllableCounter counter = new DefaultWordSyllableCounter();

            // Получить текст от пользователя
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();

            // Посчитать количество слогов в словах
            Dictionary<int, int> syllableCounts = counter.CountSyllables(text);

            // Вывести количество слов с разным количеством слогов
            foreach (KeyValuePair<int, int> syllableCount in syllableCounts)
            {
                Console.WriteLine($"Words with {syllableCount.Key} syllables: {syllableCount.Value}");
            }
        }
    }
}
// 8
using System;

namespace TextFormatter
{
    public class TextFormatter
    {
        public string FormatText(string text)
        {
            // Удалить все лишние пробелы из текста
            text = text.Replace("  ", " ");

            // Разбить текст на строки с длиной не более 50 символов
            string[] lines = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Добавить пробелы в каждую строку, чтобы она содержала ровно 50 символов
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].PadRight(50);
            }

            // Объединить строки в отформатированный текст
            string formattedText = string.Join("\n", lines);

            // Вернуть отформатированный текст
            return formattedText;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создать форматировщик текста
            TextFormatter formatter = new TextFormatter();

            // Получить текст от пользователя
            Console.WriteLine("Enter a text (up to 1000 characters): ");
            string text = Console.ReadLine();

            // Отформатировать текст
            string formattedText = formatter.FormatText(text);

            // Вывести отформатированный текст
            Console.WriteLine("Formatted text:");
            Console.WriteLine(formattedText);
        }
    }
}
// 9
using System;
using System.Collections.Generic;

namespace TextCompressor
{
    public class TextCompressor
    {
        private readonly Dictionary<string, string> _codeTable = new Dictionary<string, string>();
        private readonly string _unusedCharacters = "!@#$%^&*()-_+";
        private int _nextCodeIndex = 0;

        public string Compress(string text)
        {
            // Построить таблицу кодов
            BuildCodeTable(text);

            // Заменить повторяющиеся последовательности кодами
            string compressedText = ReplaceSequencesWithCodes(text);

            // Вернуть сжатый текст
            return compressedText;
        }

        public string Decompress(string compressedText)
        {
            // Заменить коды повторяющимися последовательностями
            string decompressedText = ReplaceCodesWithSequences(compressedText);

            // Вернуть декомпрессованный текст
            return decompressedText;
        }

        private void BuildCodeTable(string text)
        {
            // Найти все уникальные последовательности из двух букв в тексте
            HashSet<string> uniqueSequences = new HashSet<string>();
            for (int i = 0; i < text.Length - 1; i++)
            {
                string sequence = text.Substring(i, 2);
                if (!_codeTable.ContainsKey(sequence))
                {
                    uniqueSequences.Add(sequence);
                }
            }

            // Присвоить каждой уникальной последовательности код
            foreach (string sequence in uniqueSequences)
            {
                string code = GetUnusedCharacter();
                _codeTable.Add(sequence, code);
            }
        }

        private string ReplaceSequencesWithCodes(string text)
        {
            // Заменить все вхождения каждой уникальной последовательности ее кодом
            string compressedText = text;
            foreach (KeyValuePair<string, string> codePair in _codeTable)
            {
                compressedText = compressedText.Replace(codePair.Key, codePair.Value);
            }

            // Вернуть сжатый текст
            return compressedText;
        }

        private string ReplaceCodesWithSequences(string compressedText)
        {
            // Заменить все вхождения каждого кода соответствующей уникальной последовательностью
            string decompressedText = compressedText;
            foreach (KeyValuePair<string, string> codePair in _codeTable)
            {
                decompressedText = decompressedText.Replace(codePair.Value, codePair.Key);
            }

            // Вернуть декомпрессованный текст
            return decompressedText;
        }

        private string GetUnusedCharacter()
        {
            // Вернуть следующий неиспользованный символ из списка неиспользуемых символов
            string unusedCharacter = _unusedCharacters[_nextCodeIndex];
            _nextCodeIndex++;

            // Вернуть неиспользованный символ
            return unusedCharacter;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создать компрессор текста
            TextCompressor compressor = new TextCompressor();

            // Получить текст от пользователя
            Console.WriteLine("Enter a text (up to 1000 characters): ");
            string text = Console.ReadLine();

            // Сжать текст
            string compressedText = compressor.Compress(text);

            // Вывести сжатый текст
            Console.WriteLine("Compressed text:");
            Console.WriteLine(compressedText);

            // Декомпрессировать текст
            string decompressedText = compressor.Decompress(compressedText);

            // Вывести декомпрессированный текст
            Console.WriteLine("Decompressed text:");
            Console.WriteLine(decompressedText);
        }
    }
}
// 10
using System;
using System.Collections.Generic;

namespace TextCompressor
{
    public class TextCompressor
    {
        private readonly Dictionary<string, string> _codeTable = new Dictionary<string, string>();
        private readonly string _unusedCharacters = "!@#$%^&*()-_+";
        private int _nextCodeIndex = 0;

        public string Compress(string text)
        {
            // Построить таблицу кодов
            BuildCodeTable(text);

            // Заменить повторяющиеся последовательности кодами
            string compressedText = ReplaceSequencesWithCodes(text);

            // Вернуть сжатый текст
            return compressedText;
        }

        public string Decompress(string compressedText)
        {
            // Заменить коды повторяющимися последовательностями
            string decompressedText = ReplaceCodesWithSequences(compressedText);

            // Вернуть декомпрессованный текст
            return decompressedText;
        }

        private void BuildCodeTable(string text)
        {
            // Найти все уникальные последовательности из двух букв в тексте
            HashSet<string> uniqueSequences = new HashSet<string>();
            for (int i = 0; i < text.Length - 1; i++)
            {
                string sequence = text.Substring(i, 2);
                if (!_codeTable.ContainsKey(sequence))
                {
                    uniqueSequences.Add(sequence);
                }
            }

            // Присвоить каждой уникальной последовательности код
            foreach (string sequence in uniqueSequences)
            {
                string code = GetUnusedCharacter();
                _codeTable.Add(sequence, code);
            }
        }

        private string ReplaceSequencesWithCodes(string text)
        {
            // Заменить все вхождения каждой уникальной последовательности ее кодом
            string compressedText = text;
            foreach (KeyValuePair<string, string> codePair in _codeTable)
            {
                compressedText = compressedText.Replace(codePair.Key, codePair.Value);
            }

            // Вернуть сжатый текст
            return compressedText;
        }

        private string ReplaceCodesWithSequences(string compressedText)
        {
            // Заменить все вхождения каждого кода соответствующей уникальной последовательностью
            string decompressedText = compressedText;
            foreach (KeyValuePair<string, string> codePair in _codeTable)
            {
                decompressedText = decompressedText.Replace(codePair.Value, codePair.Key);
            }

            // Вернуть декомпрессованный текст
            return decompressedText;
        }

        private string GetUnusedCharacter()
        {
            // Вернуть следующий неиспользованный символ из списка неиспользуемых символов
            string unusedCharacter = _unusedCharacters[_nextCodeIndex];
            _nextCodeIndex++;

            // Вернуть неиспользованный символ
            return unusedCharacter;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создать компрессор текста
            TextCompressor compressor = new TextCompressor();

            // Получить текст от пользователя
            Console.WriteLine("Enter a text (up to 1000 characters): ");
            string text = Console.ReadLine();

            // Сжать текст
            string compressedText = compressor.Compress(text);

            // Вывести сжатый текст
            Console.WriteLine("Compressed text:");
            Console.WriteLine(compressedText);

            // Декодировать текст
            string decompressedText = compressor.Decompress(compressedText);

            // Вывести декодированный текст
            Console.WriteLine("Decompressed text:");
            Console.WriteLine(decompressedText);
        }
    }
}
//1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen =0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.ReadLine();
        }
    }
}
//2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen =0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.ReadLine();
        }
    }
}
//3
using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Windows.Forms; 
namespace Laba5
{ public partial class Form1 : Form { public Form1() 
{ InitializeComponent(); 
} 
private void text_pole_TextChanged(object sender, EventArgs e)
{ try { string stroka = text_pole.Text; vsego.Text = "Всего символов: " + Convert.ToString(stroka.Length); 
string[] mas_elem = stroka.Split(new Char[] { ' ','.',',','?','!',';',':','-','"' ,'(' ,')' }, StringSplitOptions.RemoveEmptyEntries); 
int tx = mas_elem[0].Length; min_dl.Text = "Самое короткое слово содержит символов: " + tx; 
kor_sl.Text = ""; for (int i = 0; i < mas_elem.Length - 1; i++) 
{ if (tx < mas_elem[i + 1].Length) 
{ min_dl.Text = "Самое короткое слово содержит символов: " + tx; } 
else { tx = mas_elem[i + 1].Length; min_dl.Text = "Самое короткое слово содержит символов: " + tx; 
} 
} 
int el=0; 
for (int j = 0; j < mas_elem.Length; j++) 
{
     if (tx == mas_elem[j].Length) 
     {
     if (el == 1) { kor_sl.Text = kor_sl.Text + ", " + mas_elem[j]; } 
     else { kor_sl.Text = Convert.ToString(mas_elem[j]); el =1; } } } } 
     catch (System.IndexOutOfRangeException) { min_dl.Text = "Самое короткое слово содержит символов: 0"; kor_sl.Text = ""; } } } }
//4Есть некоторая строка. Сделать заглавной каждую букву каждого слова,
// начинающегося с заглавной буквы. Понимаю, что необходимо разбить строку на массив. 
//Но как написать if который будет искать слово с заглавной буквы
public string capSentences(string str)
{
    string[] array = str.Split(' ');
    return str;
}
 
Не используй foreach, используй for. Вот код, который вы хотели:

string yourLine = "пайтон? Я тебя найду и Заставлю учить C#";
string[] words = yourLine.Split(' ');
for (int i = 0; i < words.Length; i += 1)
  if (char.IsUpper(words[i][0]))
     words[i] = words[i].ToUpper();
Console.WriteLine(string.Join(" ", words));
Вероятно, Regex будет самым оптимизированным, но честно, я до сих пор в нём не разбираюсь

 
Можно с помощью s[0].IsUpper(), где s — строка из массива:

foreach (string s in array) {
    if (s[0].IsUpper()) {
        // дальше выводим слово в заглавном регистре
    }
}
//5
static string CapitalizeAllWords(string s)
{
    var sb = new StringBuilder(s.Length);
    bool inWord = false;
    foreach(var c in s)
    {
        if (char.IsLetter(c))
        {
            sb.Append(inWord ? char.ToLower(c) : char.ToUpper(c));
            inWord = true;
        }
        else
        {
            sb.Append(c);
            inWord = false;
        }
    }
    return sb.ToString();
}
Пример использования:

Console.WriteLine(CapitalizeAllWords("пРиВеТ, мЕНя ЗОвут МАРИНА."));
 
Как вариант можно так попробовать

string TextBoxText = "hello world my name is hitler";

            var result = TextBoxText.Split(' ').ToList();
            var t = new List<string>();
            result.ForEach(g =>
            {

                t.Add(g.Replace(g[0].ToString(), g[0].ToString().ToUpper()));
            });
Надо пробовать:
var text = "привет тест. ВОТ так Получилось.забыли пробел. нет точки";
        text = text.ToLower();
        var firstQuery = Regex.Replace(text, @"(^\w)|(\.\s\w)|(\.\w)", m => m.Value.ToUpper());

        var secondQuery = Regex.Replace(text, @"(^\w)|(\.\s\w)|(\.\w)|(\s\w)", m => m.Value.ToUpper());

        //Вывод текста где первый символ в предложении с большой буквы. Даже если нет пробелов после точки.
        Console.WriteLine(firstQuery);

        //Вывод текста где все слова в предложении с большой буквы. Даже если нет пробелов после точки.
        Console.WriteLine(secondQuery);
//6
void funcWords(char str[], FILE* outPutFile) {
    char str_copy[SIZE], str_copy1[SIZE]; // строки которые заменяют str
    strcpy(str_copy, str);  // копирование str в str_copy
    strcpy(str_copy1, str); // копирование str в str_copy1
    
    char* littleWord = NULL; //указатель на короткое слово
    char* longWord = NULL; //указатель на длинное слово
 
    littleWord = funcLittleword(str_copy1); // нахождение самого короткого слова в строке
    longWord = funcLongword(str_copy); // нахождение самого длинного слова в строке
    char* strPtr[20] = {  }; //массив указателей(пока пустой) впоследствии будет указывать на каждое слово строки
    strPtr[0] = strtok(str, " ");
    for (int i = 1; i < SIZE_PTR; i++) 
        strPtr[i] = strtok(NULL, " ");
    
    for (int i = 0; strPtr[i] != NULL; i++) {// происходит обмен короткого и длинного слов
        if (!strncmp(longWord, strPtr[i], strlen(longWord))) {
            fprintf(outPutFile, "%s ", littleWord);
        }
        else if (!strncmp(littleWord, strPtr[i], strlen(littleWord))) {
            fprintf(outPutFile, "%s ", longWord);
        }
        else {
            fprintf(outPutFile, "%s ", strPtr[i]);
        }
    }
//7
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите слово");
            string str;
            str = Console.ReadLine();
            int[] counter = new int[256];
            for (int i = 0; i < str.Length; ++i)
                counter[Char.ToLower(str) - 'a']++;
                Console.Write("Результат:");
                Console.WriteLine(str.Length);
            }
            }
    }
 
А как написать, чтобы в результате выдавала количество для каждой буквы?
static void Main(string[] args)
        {
            string str;
            int size_counter = 256;//for english alphabet only
            Int32[] counter = new Int32[size_counter];
           
           
                Console.Write("Enter a string: ");
                str = Console.ReadLine();

                for (Int16 i = 0; i < str.Length; ++i)
//если в строке есть знаки пуктуации, то делаем проверку, что символ буква
                    if(Char.IsLetter(str))
                        ++counter[Char.ToLower(str) - 'a'];

                for (int i = 0; i < counter.Length; ++i)
                    if (counter > 0)
                        Console.WriteLine("{0} = {1}", ((char)('A' + i)), counter);
           
        }
//8
// Подсчет количество слов в переменной без слов определенной длинны в символах (в этом случае {1,3})
var inputstring = project.Variables["text"].Value;
string texttostring = (inputstring);
int c1 = texttostring.Split(' ').Length;
int c2 = Regex.Matches(inputstring, "\\b\\w{1,3}\\b").Count;
return c1 - c2;
//9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
 
namespace wordscount
{
    class Program
    {
        static void Main(string[] args)
        {       
            string s = "" ;
            string[] textMass;
            StreamReader sr = new StreamReader("C:\\qwerty\\textfile1.txt");
 
            while (sr.EndOfStream != true)
            {
                s = sr.ReadLine();                
            }
            textMass = s.Split(' ');
            Console.WriteLine("The number of words:");
            Console.WriteLine(textMass.Length);
 
            sr.Close();
            Console.ReadLine();
        }
    }
}
// 3/4
using System.Collections.Generic;
using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        string[] words = text.Split(" ,-!.:;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words)
        {
            if (word.Length == 1 && "вксВКС".Contains(word))
            {
                answer++;
            }
        }
    }

    public override string ToString()
    {
        Solution();
        return answer.ToString();
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
        int[] counter = new int[33];
        string checker = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        foreach (char i in text)
        {
            if (checker.Contains(i))
            {
                counter[i - 'А']++;
            }
        }
        char maxChar = ' ';
        int tmpMax = 0;
        for (int i = 0; i < 33; ++i)
        {
            if (counter[i] > tmpMax)
            {
                tmpMax = counter[i];
                maxChar = Convert.ToChar('А' + i);
            }
        }
        string[] words = text.Split(" ,-!.:;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words)
        {
            if (word[0] == maxChar)
            {
                answer.Add(word);
            }
        }
    }
    public override string ToString()
    {
        Solution();
        if (answer == null) return "";
        return string.Join(",", answer.ToArray()); ;
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
        string text = "Объектно ориентированное программиирование — методология на основе описания моделей и их взаимодействия. С джейсоном очень сложно разобраться. В принципе мне нравится программировать, но часто возникают трудности. С ними я пытаюсь справиться. Сегодня я очень старалась.";
        Task[] tasks = {
            new Task1(text),
            new Task2(text)
        };
        Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);

        string path = @"C:\Users\user\Desktop";
        string folderName = "Test";
        path = Path.Combine(path, folderName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string fileName1 = "task_1.json";
        string fileName2 = "task_2.json";

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
// 4/4
using System;
using System.Globalization;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string text1 = "Please, when you stop do homework, call me";
        string text2 = "Okey, I will call you later, sorry";

        var capWords = CapWords(text1);
        var swapSentences = SwapLongShort(text2);

        Console.WriteLine(string.Join(" ", capWords));
        Console.WriteLine(swapSentences);

        string downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\Solution";

        Directory.CreateDirectory(downloadPath);

        string filePath1 = Path.Combine(downloadPath, "task_1.json");
        string filePath2 = Path.Combine(downloadPath, "task_2.json");

        JsonIO.ProcessJson(filePath1, capWords);
        JsonIO.ProcessJson(filePath2, swapSentences);
    }

    static string[] CapWords(string text)
    {
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                char[] letters = words[i].ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                words[i] = new string(letters);
            }
        }
        return words;
    }

    static string SwapLongShort(string text)
    {
        string[] sentences  = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Trim().Split(new char[] { ' ', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length < 2) continue;

            int shortIndex = 0, longIndex = 0;
            int shortLength = words[0].Length, longLength = words[0].Length;

            for (int j = 1; j < words.Length; j++)
            {
                int length = words[j].Length;
                if (length < shortLength)
                {
                    shortLength = length;
                    shortIndex = j;
                }
                if (length > longLength)
                {
                    longLength = length;
                    longIndex = j;
                }
            }

            string temp = words[shortIndex];
            words[shortIndex] = words[longIndex];
            words[longIndex] = temp;
            sentences[i] = string.Join(" ", words);
        }
        return string.Join(". ", sentences) + ".";
    }
}

class JsonIO
{
    public static void ProcessJson<T>(string filePath, T data)
    {
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(data));
            Console.WriteLine($"Data написано в {filePath}");
        }
        else
        {
            string jsonData = File.ReadAllText(filePath);
            Console.WriteLine($"Data прочитана в {filePath}: {jsonData}");
        }
    }
}