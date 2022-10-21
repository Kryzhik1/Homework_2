// Программа проверяет пятизначное число на палиндром.
Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());
int A = N%100;
int B = N/1000;
if (A/10 == B%10)
{
   Console.WriteLine("Число является палиндромом"); 
}
else
{
Console.WriteLine("Число не является палиндромом");
}
