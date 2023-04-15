// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Введите день недели");
int day = int.Parse(Console.ReadLine());
if (day <1 ) {Console.WriteLine("Это не день недели, повторите снова");}
else if (day >7 ) {Console.WriteLine("Это не день недели, повторите снова");}
else if (day > 5 && day < 8) {Console.WriteLine("Да это выходной день");}
else if (day > 0 && day < 6){Console.WriteLine("Нет это не выходной день");}