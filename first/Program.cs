////Console.WriteLine("Введи, пожалуйста, свое имя:");
////string user = Console.ReadLine();
////Console.WriteLine("Hello, " + user + "!");
////Console.ReadLine();


//// Задача 1

//Console.Write("Введите, пожалуйста, первое число: ");
//double operand1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите, пожалуйста, второе число: ");
//double operand2 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите, пожалуйста, знак арифметической операции: ");
//char sign = Convert.ToChar(Console.ReadLine());


//switch (sign)
//{
//    case '+':
//        double result = operand1 + operand2;
//        Console.Write($"Результат сложения: {result}");
//        break;
//    case '-':
//        result = operand1 - operand2;
//        Console.Write($"Результат вычитания: {result}");
//        break;
//    case '*':
//        result = operand1 * operand2;
//        Console.Write($"Результат умножения: {result}");
//        break;
//    case '/':
//        if (operand2 == 0)
//        {
//            Console.Write("Ошибка! Деление на ноль.");
//        }
//        else
//        {
//            result = operand1 / operand2;
//            Console.Write($"Результат деления: {result}");
//        }
//        break;
//    case '%':
//        result = operand1 % operand2;
//        Console.Write($"Остаток от деления: {result}");
//        break;
//    default:
//        Console.Write("Некорректный ввод данных!");
//        break;
//}

//// Задача 2

//Console.Write("Введите, пожалуйста, целое число от 0 до 100: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number >= 0 && number <= 14)
//{
//    Console.WriteLine("Ваше число находится в промежутке от 0 до 14");
//}
//else if (number >= 15 && number <= 35)
//{
//    Console.WriteLine("Ваше число находится в промежутке от 15 до 35");
//}
//else if (number >= 36 && number <= 50)
//{
//    Console.WriteLine("Ваше число находится в промежутке от 36 до 50");
//}
//else if (number >= 50 && number <= 100)
//{
//    Console.WriteLine("Ваше число находится в промежутке от 50 до 100");
//}
//else
//{
//    Console.WriteLine("Ошибка! Ваше число не входит в промежуток от 0 до 100");
//}

//// Задача 3


//Console.Write("Введите, пожалуйста, слово о погоде на русском языке: ");
//string pogoda = Console.ReadLine();

//switch (pogoda)
//{
//    case "холодно":
//    case "Холодно":
//        Console.Write("В переводе на английский язык, это будет: cold");
//        break;
//    case "тепло":
//    case "Тепло":
//        Console.Write("В переводе на английский язык, это будет: warm");
//        break;
//    case "ветрено":
//    case "Ветрено":
//        Console.Write("В переводе на английский язык, это будет: windy");
//        break;
//    case "дождливо":
//    case "Дождливо":
//        Console.Write("В переводе на английский язык, это будет: rainy");
//        break;
//    case "солнечно":
//    case "Солнечно":
//        Console.Write("В переводе на английский язык, это будет: sunny");
//        break;
//    case "пасмурно":
//    case "Пасмурно":
//        Console.Write("В переводе на английский язык, это будет: cloudy");
//        break;
//    case "гроза":
//    case "Гроза":
//        Console.Write("В переводе на английский язык, это будет: storm");
//        break;
//    case "ураган":
//    case "Ураган":
//        Console.Write("В переводе на английский язык, это будет: hurricane");
//        break;
//    case "жара":
//    case "Жара":
//        Console.Write("В переводе на английский язык, это будет: heat");
//        break;
//    case "снежно":
//    case "Снежно":
//        Console.Write("В переводе на английский язык, это будет: snowy");
//        break;
//    default:
//        Console.Write("Извините, такого слова нет");
//        break;
//}

//// Второй вариант

//Console.Write("Введите, пожалуйста, слово о погоде на русском языке: ");
//string pogoda = Console.ReadLine().ToLower();

//switch (pogoda)
//{
//    case "холодно":
//        Console.Write("В переводе на английский язык, это будет: cold");
//        break;
//    case "тепло":
//        Console.Write("В переводе на английский язык, это будет: warm");
//        break;
//    case "ветрено":
//        Console.Write("В переводе на английский язык, это будет: windy");
//        break;
//    case "дождливо":
//        Console.Write("В переводе на английский язык, это будет: rainy");
//        break;
//    case "солнечно":
//        Console.Write("В переводе на английский язык, это будет: sunny");
//        break;
//    case "пасмурно":
//        Console.Write("В переводе на английский язык, это будет: cloudy");
//        break;
//    case "гроза":
//        Console.Write("В переводе на английский язык, это будет: storm");
//        break;
//    case "ураган":
//        Console.Write("В переводе на английский язык, это будет: hurricane");
//        break;
//    case "жара":
//        Console.Write("В переводе на английский язык, это будет: heat");
//        break;
//    case "снежно":
//        Console.Write("В переводе на английский язык, это будет: snowy");
//        break;
//    default:
//        Console.Write("Извините, такого слова нет");
//        break;
//}


//// Задача 4

//Console.Write("Введите, пожалуйста, целое число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number % 2 == 0)
//{
//    Console.WriteLine("Ваше число четное");
//}
//else
//{
//    Console.WriteLine("Ваше число нечетное");
//}

////// пыталась по разному вычислить, в соответствии с комментарием, не получается у меня



//Console.Write("Введите, пожалуйста, целое число: ");
//double number1 = Convert.ToDouble(Console.ReadLine());
//int result1 = (int)(number1 / 2);

//if (result1 != 0)
//{
//    Console.WriteLine("Ваше число нечетное");
//}
//else
//{
//    Console.WriteLine("Ваше число четное");

//}

//Console.Write("Введите, пожалуйста, целое число: ");
//double number2 = Convert.ToDouble(Console.ReadLine());
//double result2 = number2 / 2;

//if (Convert.ToInt32(result2) != 0)
//{
//    Console.WriteLine("Ваше число нечетное");
//}
//else
//{
//    Console.WriteLine("Ваше число четное");

//}

//Console.Write("Введите, пожалуйста, целое число: ");
//double number3 = Convert.ToDouble(Console.ReadLine());
//double number4 = number3 - Math.Truncate(number3);

//if ((Convert.ToInt32(number4 * 10)) % 2 == 0)
//{
//    Console.WriteLine("Ваше число четное");
//}
//else
//{
//    Console.WriteLine("Ваше число нечетное");

//}

//Массивы и циклы

// Задание 1


int[] array = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

bool found = false;

foreach (int n in array)
{
    if (n == number)
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine("Число найдено в массиве.");
}
else
{
    Console.WriteLine("Число не найдено в массиве.");
}


//Задание 2

int[] array = new int[] { 1, 2, 2, 4, 5 };
Console.WriteLine("Массив: " + string.Join(",", array));

Console.WriteLine("Введите число для удаления:");
int numberToDelete = int.Parse(Console.ReadLine());

int result = 0;
foreach (int n in array)
{
    if (n == numberToDelete)
    {
        result++;
    }
}

if (result == 0)
{
    Console.WriteLine("Такого числа нет в массиве");
}
else
{
    int[] array2 = new int[array.Length - result];
    int index = 0;
    foreach (int n in array)
    {
        if (n != numberToDelete)
        {
            array2[index] = n;
            index++;
        }
    }

    Console.Write("Новый массив: ");
    foreach (int n in array2)
    {
        Console.Write(n + " ");
    }
}

//Задание 3

using System.Drawing;

Console.WriteLine("Введите длину массива:");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];

for (int i = 0; i < length; i++)
{
    array[i] = Random.Shared.Next(1, 11);
}

Console.WriteLine("Получившийся массив: " + string.Join(",", array));

int max = array[0];

for (int i = 1; i < length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
}

int min = array[0];

for (int i = 1; i < length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}

double sum = 0;
foreach (int n in array)
{
    if (n > max)
        max = n;

    if (n < min)
        min = n;

    sum += n;
}

double average = sum / length;

Console.WriteLine("Максимальное значение в массиве: " + max);
Console.WriteLine("Минимальное значение в массиве: " + min);
Console.WriteLine("Среднее значение в массиве: " + average);


//Задание 4

int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = { 1, 2, 3, 4, 5 };

Console.WriteLine("Первый массив: " + string.Join(",", array1));
Console.WriteLine("Второй массив: " + string.Join(",", array2));

double sum1 = 0;
double sum2 = 0;

foreach (int i in array1)
{
    sum1 += i;
}
foreach (int i in array2)
{
    sum2 += i;
}

double average1 = sum1 / array1.Length;
double average2 = sum2 / array2.Length;

if (average1 > average2)
{
    Console.WriteLine("В первом массиве среднее арифетическое больше чем во втором массиве");
}
else if (average1 < average2)
{
    Console.WriteLine("Во втором массиве среднее арифетическое больше чем в первом массиве");
}
else
{
    Console.WriteLine("Среднее арифметическое двух массивов равны");
}

//Строки

// 1 задание

using System.Text;

var phrase = "testtest123";
phrase = phrase.Replace("test", "testing");

StringBuilder sb = new StringBuilder();

foreach (char c in phrase)
{
    if (!Char.IsDigit(c))
    {
        sb.Append(c);
    }
}
string resultPhrase = sb.ToString();
Console.WriteLine(resultPhrase);


//2 задание

Console.WriteLine(String.Concat("\"Welcome\" \"to\" \"the\" \"TMS\" \"lessons.\""));


//3 задание

using static System.Net.Mime.MediaTypeNames;

var text = "teamwithsomeofexcersicesabcwanttomakeitbetter";

string beforeAbc = text.Split(new string[] { "abc" }, StringSplitOptions.RemoveEmptyEntries)[0];
string afterAbc = text.Split(new string[] { "abc" }, StringSplitOptions.RemoveEmptyEntries)[1];
Console.WriteLine("Перед abc: " + beforeAbc);
Console.WriteLine("После abc: " + afterAbc);



//задание 4

string text = "Плохой день";
text = text.Substring(7);

string subString = "Хороший ";
text = text.Insert(0, subString);
text = text.Insert(text.Length, "!!!!!!!!!");

text = text.Substring(0, text.Length - 1);
text = text.Insert(text.Length, "?");
Console.WriteLine(text);

//5 задание очень большое, если успею сделаю его позже

