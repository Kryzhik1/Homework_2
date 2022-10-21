// По двум заданным числам проверять является ли одно квадратом другого.
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
if ( A == B*B )
{
Console.WriteLine("Число A является квадратом числа B");
}
else
{
Console.WriteLine("Число A НЕ является квадратом числа B");    
}
