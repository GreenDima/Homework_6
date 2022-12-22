// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и 
// k2 задаются пользователем.

// double [] IntersectionPoint(double k1, double b1, double k2, double b2)
// {
//     double [] arr = new double[2];
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k2 * x + b2;
//     arr[0] = x;
//     arr[1] = y;
//     return arr;
// }
// Console.WriteLine("Введите k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// if(k1 == k2) Console.WriteLine("Прямые не пересекаются");
// else
// {
// double [] array = IntersectionPoint(k1, b1, k2, b2);
// Console.WriteLine($"Ваша точка пересечения прямых: ({array[0]} ; {array[1]})");
// }



// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int CounterPositiveNumbers(int a)
// {
// int [] array = new int[a];
// int result = 0;
// for (int i = 0; i < a; i++)
// {
//     Console.WriteLine("Введите число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if(array[i] > 0) result++;
// }
// return result;
// }

// Console.WriteLine("Сколько чисел вы хотите ввести?");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число положительных чисел: {CounterPositiveNumbers(a)}");