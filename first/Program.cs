//Console.WriteLine("Введи, пожалуйста, свое имя:");
//string user = Console.ReadLine();
//Console.WriteLine("Hello, " + user + "!");
//Console.ReadLine();


// Задача 1

Console.Write("Введите, пожалуйста, первое число: ");
double operand1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, пожалуйста, второе число: ");
double operand2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, пожалуйста, знак арифметической операции: ");
char sign = Convert.ToChar(Console.ReadLine());


switch (sign)
{
    case '+':
        double result = operand1 + operand2;
        Console.Write($"Результат сложения: {result}");
        break;
    case '-':
        result = operand1 - operand2;
        Console.Write($"Результат вычитания: {result}");
        break;
    case '*':
        result = operand1 * operand2;
        Console.Write($"Результат умножения: {result}");
        break;
    case '/':
        if (operand2 == 0)
        {
            Console.Write("Ошибка! Деление на ноль.");
        }
        else
        {
            result = operand1 / operand2;
            Console.Write($"Результат деления: {result}");
        }
        break;
    case '%':
        result = operand1 % operand2;
        Console.Write($"Остаток от деления: {result}");
        break;
    default:
        Console.Write("Некорректный ввод данных!");
        break;
}

// Задача 2

Console.Write("Введите, пожалуйста, целое число от 0 до 100: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0 && number <= 14)
{
    Console.WriteLine("Ваше число находится в промежутке от 0 до 14");
}
else if (number >= 15 && number <= 35)
{
    Console.WriteLine("Ваше число находится в промежутке от 15 до 35");
}
else if (number >= 36 && number <= 50)
{
    Console.WriteLine("Ваше число находится в промежутке от 36 до 50");
}
else if (number >= 50 && number <= 100)
{
    Console.WriteLine("Ваше число находится в промежутке от 50 до 100");
}
else
{
    Console.WriteLine("Ошибка! Ваше число не входит в промежуток от 0 до 100");
}

// Задача 3


Console.Write("Введите, пожалуйста, слово о погоде на русском языке: ");
string pogoda = Console.ReadLine();

switch (pogoda)
{
    case "холодно":
    case "Холодно":
        Console.Write("В переводе на английский язык, это будет: cold");
        break;
    case "тепло":
    case "Тепло":
        Console.Write("В переводе на английский язык, это будет: warm");
        break;
    case "ветрено":
    case "Ветрено":
        Console.Write("В переводе на английский язык, это будет: windy");
        break;
    case "дождливо":
    case "Дождливо":
        Console.Write("В переводе на английский язык, это будет: rainy");
        break;
    case "солнечно":
    case "Солнечно":
        Console.Write("В переводе на английский язык, это будет: sunny");
        break;
    case "пасмурно":
    case "Пасмурно":
        Console.Write("В переводе на английский язык, это будет: cloudy");
        break;
    case "гроза":
    case "Гроза":
        Console.Write("В переводе на английский язык, это будет: storm");
        break;
    case "ураган":
    case "Ураган":
        Console.Write("В переводе на английский язык, это будет: hurricane");
        break;
    case "жара":
    case "Жара":
        Console.Write("В переводе на английский язык, это будет: heat");
        break;
    case "снежно":
    case "Снежно":
        Console.Write("В переводе на английский язык, это будет: snowy");
        break;
    default:
        Console.Write("Извините, такого слова нет");
        break;
}

// Второй вариант

Console.Write("Введите, пожалуйста, слово о погоде на русском языке: ");
string pogoda = Console.ReadLine().ToLower();

switch (pogoda)
{
    case "холодно":
        Console.Write("В переводе на английский язык, это будет: cold");
        break;
    case "тепло":
        Console.Write("В переводе на английский язык, это будет: warm");
        break;
    case "ветрено":
        Console.Write("В переводе на английский язык, это будет: windy");
        break;
    case "дождливо":
        Console.Write("В переводе на английский язык, это будет: rainy");
        break;
    case "солнечно":
        Console.Write("В переводе на английский язык, это будет: sunny");
        break;
    case "пасмурно":
        Console.Write("В переводе на английский язык, это будет: cloudy");
        break;
    case "гроза":
        Console.Write("В переводе на английский язык, это будет: storm");
        break;
    case "ураган":
        Console.Write("В переводе на английский язык, это будет: hurricane");
        break;
    case "жара":
        Console.Write("В переводе на английский язык, это будет: heat");
        break;
    case "снежно":
        Console.Write("В переводе на английский язык, это будет: snowy");
        break;
    default:
        Console.Write("Извините, такого слова нет");
        break;
}


// Задача 4

Console.Write("Введите, пожалуйста, целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Ваше число четное");
}
else
{
    Console.WriteLine("Ваше число нечетное");
}

//// пыталась по разному вычислить, в соответствии с комментарием, не получается у меня



Console.Write("Введите, пожалуйста, целое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
int result1 = (int)(number1 / 2);

if (result1 != 0)
{
    Console.WriteLine("Ваше число нечетное");
}
else
{
    Console.WriteLine("Ваше число четное");

}

Console.Write("Введите, пожалуйста, целое число: ");
double number2 = Convert.ToDouble(Console.ReadLine());
double result2 = number2 / 2;

if (Convert.ToInt32(result2) != 0)
{
    Console.WriteLine("Ваше число нечетное");
}
else
{
    Console.WriteLine("Ваше число четное");

}

Console.Write("Введите, пожалуйста, целое число: ");
double number3 = Convert.ToDouble(Console.ReadLine());
double number4 = number3 - Math.Truncate(number3);

if ((Convert.ToInt32(number4 * 10)) % 2 == 0)
{
    Console.WriteLine("Ваше число четное");
}
else
{
    Console.WriteLine("Ваше число нечетное");

}