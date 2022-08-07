// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

int Prompt(string messege)
{
    System.Console.Write(messege);           //Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}

int numberOne = Prompt("Введите первое число: ");
int numberTwo = Prompt("Введите второе число: ");

int result = numberOne * numberOne;
if(result == numberTwo)
{
    System.Console.WriteLine($"Число {numberTwo} является квадратом числа {numberOne}");
}

else
{
    System.Console.WriteLine($"Число {numberTwo} не является квадраточ числа {numberOne}");
}

