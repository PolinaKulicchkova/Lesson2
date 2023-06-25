// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

    while (number >= 100 && number <= 999) {
        number = number / 10;
    }
    int i = number % 10;
    Console.WriteLine("Вторая цифра трехзначного числа: " + i);
    