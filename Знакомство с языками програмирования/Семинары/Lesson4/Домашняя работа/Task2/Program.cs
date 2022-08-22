// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.WriteLine(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int SumOfDigitsOfNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}
int value = Prompt("Введите значение ->");
if (value >= 0)
{
    System.Console.WriteLine($"{value} -> {SumOfDigitsOfNumber(value)}");
}
else
{
    System.Console.WriteLine("Неккоректный ввод, введите положительное число ");
}