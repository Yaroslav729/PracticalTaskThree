Console.Clear();
Console.Write("Введите число: ");
string a = Console.ReadLine()!;
char[] arr = new char[a.Length];
if(arr.Length > 5)
Console.Write("Введите не более 5 чисел");
else if (arr.Length < 5)
{Console.Write("Введите не менее 5 чисел");}
else
if (a[0] == a[4] && a[1] == a[3])
    Console.Write("Число является палиндромом");

else
{
    Console.Write("Число не является палиндромом");
}