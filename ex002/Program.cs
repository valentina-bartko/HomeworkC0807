// 2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// Я понимаю задачу так:
// написать программу, которая принимает на вход три целых числа, сгенерированных автоматически
// из диапазона от 1 до 101, и выдает максимальное из этих чисел.

int x = new Random().Next(1, 101);
int y = new Random().Next(1, 101);
int z = new Random().Next(1, 101);

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
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.Write("Максимальное число = ");
Console.Write(max);