// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int randomNumber = new Random().Next(10, 100); // Число от 10 до 99 включительно
// int firstDigit = randomNumber / 10; // Первая цифра от 78: 78 / 10 = 7
// int secondDigit = randomNumber % 10; // Вторая цифра от 78: 78 % = 8
// int max = firstDigit; // Пусть (можем ошибаться ) первая цифра в числе - максимальная
// if (secondDigit > max) // Если вторая цифра больше мах
// {
//     max = secondDigit; // то мах = второй цифре

// }
// // //Console.WriteLine("Максимальная цифра в числе " + randomNumber + " - Это" + max); // Конкатенация
// Console.WriteLine($"Максимальная цифра в числе: {randomNumber} - Это {max}"); // Интерполяция
// // // "Текст: {переменная} текст {переменная}"

// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int randomNumber = new Random().Next(100, 1000); //100-1000 включительно


// int result = (randomNumber / 100) * 10 + randomNumber % 10;
// Console.WriteLine($"в числе {randomNumber} -> {result}");

// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Получаем первое число: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());
// Console.Write("Получаем второе число: ");
// int secondDigit = Convert.ToInt32(Console.ReadLine());
// if( firstDigit / secondDigit == 0)
// {
//     Console.WriteLine($"Число {firstDigit} делиться без остатка на {secondDigit}");
// }
// else
// {
//     Console.WriteLine($"Остаток от деления числа {firstDigit} на {secondDigit} : {firstDigit % secondDigit}");
// }

// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Получаем число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 7 ==0 && number % 23 ==0) // Число делиться без остатка на 7 и 23
{
    Console.WriteLine($"Число {number} делиться без остатка на 7 и 23");

}
else
{
    Console.WriteLine($"Число {number} делиться на 7 с остатком: {number % 7}");
    Console.WriteLine($"Число {number} делиться на 23 с остатком: {number % 23}");
}