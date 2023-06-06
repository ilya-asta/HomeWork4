// ___________________Домашнее задание________________________
// ____________________Задание 3______________________________
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33




// void CreateArray()
// {
//     int[] arr = new int[8];
//     int count = 0;
//     while (count < arr.Length)
//     {
//         arr [count] = new Random().Next(0, 1000);
//         Console.WriteLine(arr[count]);
//         count++;
//     }

// }
// CreateArray();


// ______________________-Задание 2_________________________
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12




// Console.WriteLine("Введите число");
// string A = Console.ReadLine();

// int Length = A.Length;
// int count = 0;
// int result = 0;
// int num2 = 0;
// int num = Convert.ToInt32(A);
// while (count <= Length)
// {
//     num2 = num % 10;
//     result = num2 +result;
//     num = num / 10;
//     count++;
// }
// Console.WriteLine(result);




// _____________________Задание 1_________________________

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());



// int count = 1;
// int result = num1;
// while (count < num2)
// {
//     result = result * num1;
//     count++;
    
// }

// Console.WriteLine(result);


