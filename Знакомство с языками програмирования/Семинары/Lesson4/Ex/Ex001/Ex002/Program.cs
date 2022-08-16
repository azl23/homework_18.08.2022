// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int number = Prompt("Введите число > ");
int count = 0;
while(number > 0){
    number = number / 10;
    count++;
}
System.Console.WriteLine(count);

