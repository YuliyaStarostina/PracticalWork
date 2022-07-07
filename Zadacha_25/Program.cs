// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите числа через запятую: ");
string[] numbers = Console.ReadLine()!.Split(',');
int num = int.Parse(numbers[0]);
int grade = int.Parse(numbers[1]);
if (grade > 0)
{
    Console.WriteLine($"Возведение числа {num} в натуральную степень {grade} равна {Math.Pow(num, grade)}");
}
else
{
    System.Console.WriteLine($"Error! Натуральная степень должна быть > 0 ");
}

