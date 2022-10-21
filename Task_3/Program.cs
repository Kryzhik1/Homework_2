// Задать номер четверти, показать диапазоны для возможных координат.
Console.WriteLine("Введите номер четверти (1, 2, 3 или 4): ");
int N = int.Parse(Console.ReadLine());
if ( N == 1 )
{
Console.WriteLine("X>0, Y>0");
}
if ( N == 2 )
{
Console.WriteLine("X<0, Y>0");
}
if ( N == 3 )
{
Console.WriteLine("X<0, Y<0");
}
if ( N == 4 )
{
Console.WriteLine("X>0, Y<0");
}