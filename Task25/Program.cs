Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
int newNumber = 1;
for (int index = 1; index <= degree; index++)
{
    newNumber = newNumber * number;
}
Console.WriteLine($"Ответ: {newNumber} -> это число {number} возведенное в степень {degree}");