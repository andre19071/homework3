//Задача 19
//Напишите программу, которая принимает на вход пятизначно
//число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да 

Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
string numberText = N.ToString();

if (N >=10000 && N <100000)
if (numberText[0] == numberText[4] && numberText[1] == numberText[3])
{
        Console.WriteLine($"число {N} является палиндромом: ");
}
else
{
    Console.WriteLine($"число {N} не является палиндромом: ");
}
else
{
    Console.WriteLine("Введите пятизначное число");
}

