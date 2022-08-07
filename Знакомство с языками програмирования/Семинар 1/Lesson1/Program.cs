// Напишите программу, которая на вход принимает число и
// выдаёт его квадрат (число умноженное на само себя).

// Функция, на вход получает параметр, на выходе получает с консоли значение
int Prompt(string messege)
{
    System.Console.Write(messege);           //Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}

int value;                                   // Объявление переменной
value = Prompt("Введите число >");           // Вводим значение
int result = value * value;                  // (Переменную можно объявлять и сразу присваивать ей значение) Вычисляем квадрат
System.Console.WriteLine($"Квадрат числа {value} равен {result}");                // Вывод результата
System.Console.WriteLine("Квадрат числа" + value + "равен" + result);