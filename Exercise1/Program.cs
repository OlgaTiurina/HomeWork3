// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 10000)
{
    int a1 = number / 10000;
    int b1 = number % 10;

        if(a1 == b1)
        {
            number = number / 10;
            int a2 = (number / 100) % 10;
            int b2 = number % 10;
            if(a2 == b2)
                Console.WriteLine("Это число является палиндором");
        }
        else
        {
            Console.WriteLine("Это число не является палиндором");
        }
}
