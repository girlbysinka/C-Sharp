// Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда 5 -> Пятница
int a = new Random().Next(1,8); // 1,2,3,4,5,6,7
Console.WriteLine(a);

if (a==1)  Console.WriteLine("Понедельник");
if (a==2)  Console.WriteLine("Вторник");
if (a==3)  Console.WriteLine("Среда");
if (a==4)  Console.WriteLine("Четверг");
if (a==5)  Console.WriteLine("Пятница");
if (a==6)  Console.WriteLine("Суббота");
if (a==7)  Console.WriteLine("Воскресенье");