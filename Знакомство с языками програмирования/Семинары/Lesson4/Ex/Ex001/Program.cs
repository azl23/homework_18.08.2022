// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int SumSequence(int number)
{
    int answer = 0;
    for (int i = 0; i <= number; i++)
    {
        answer = answer + i;
    }
    return answer;
}

int SumGauss(int number)
{
    int answer = (int)((number + 1) * (number / 2));
    return answer;
}

int number = Prompt("Введите число для суммы > ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} составляет {SumSequence(number)}");
System.Console.WriteLine($"Сумма чисел по Гауссу от 1 до {number} составляет {SumGauss(number)}");

