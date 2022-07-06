// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// мой вариант решения
Console.Clear();
System.Console.WriteLine("Введите пятизначное число"); // ввод числа пользователем
string number = Console.ReadLine()!; // считывает то, что ввел пользователь и присваевает в строку number
int length = number.Length;
if (length == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
  System.Console.WriteLine("Введенное число является палиндромом."); 
else 
  System.Console.WriteLine("Введенное число не является палиндромом");
}
else System.Console.WriteLine($"Error. Введите пятизначное число!");

// интересный вариант одногруппников с новыми командами
// System.Console.WriteLine("Введите пятизначное число");
// string number = Console.ReadLine()!;
// int length = number.Length;
// int validatingNumber;
// bool validating = int.TryParse(number, out validatingNumber);
// if (validating && length == 5)
// {
//       if (number.Reverse().SequenceEqual(number)) Console.WriteLine($"Число {number} является палиндромом"); 
//       // реверс переворачивает число,секьенсеквал сравнивает
//       else System.Console.WriteLine($"Число {number} не является палиндромом ");
// }
// else System.Console.WriteLine($"Error. Введите пятизначное число!\n");
