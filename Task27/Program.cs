Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");  //Первый способ
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();
int numberInt = 0;
int newNumber = 0;
int convertChar = 48;
for (int index = 0; index < number?.Length; index++)
{
    numberInt = Convert.ToInt32(number[index]) - convertChar;
    newNumber = numberInt + newNumber;
}

Console.WriteLine(newNumber);

/*
Console.Write("Напишите число: ");          //Второй способ
string stringNumber = Console.ReadLine();
int sum = 0;
for (int index = 0; index < stringNumber.Length; index++)
{
    sum += Convert.ToInt32(stringNumber[index].ToString());
}
Console.WriteLine("Сумма цифр: " + sum);
*/