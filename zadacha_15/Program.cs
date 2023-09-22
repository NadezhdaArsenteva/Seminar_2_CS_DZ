// Задача 15: Напишите программу на C#  которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int dayOfWeek = int.Parse(Console.ReadLine());
//проверка на выходной день 
bool isWeekend = (dayOfWeek == 6) || (dayOfWeek == 7);
if (isWeekend)
    Console.WriteLine("Да, это выходной день");
else
    Console.WriteLine("Нет, это не выходной день");

