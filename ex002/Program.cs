// 2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// Я понимаю задачу так:
// написать программу, которая принимает на вход три целых числа, введенных пользователем
// и выдает максимальное из этих чисел.

Console.Write("Введите три целых числа: ");
string x, y, z = Console.ReadLine();

int[] numbers = {x, y, z};
int index = 0;
int max = numbers[0];

while(index < numbers.Length)
{
    if(numbers[index] > max)
    {
        max = numbers[index];
    }
    index++;
}
Console.WriteLine(max);