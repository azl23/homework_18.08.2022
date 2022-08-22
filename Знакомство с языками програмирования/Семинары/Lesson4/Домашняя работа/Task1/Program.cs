// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Prompt(string message)
{
    Console.WriteLine(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int ExponentiationOfNumber(int value1, int value2)
{
    int result = 1;
    for (int i = 0; i < value2; i++)
    {
        result = result * value1;
    }
    return result;
}

int numberOne = Prompt("Введите первое значение -> ");
int numberTwo = Prompt("Введите второе значение -> ");
if (numberTwo < 0)
{
    Console.WriteLine($"Неккоректный ввод");
}
else
{
    Console.WriteLine($"{numberOne}, {numberTwo} -> {ExponentiationOfNumber(numberOne, numberTwo)}");
}