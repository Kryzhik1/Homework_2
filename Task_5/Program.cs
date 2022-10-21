// Найти расстояние между точками в пространстве 2D/3D.
Console.WriteLine("Введите координату xa: ");
int xa = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите координату ya: ");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату za: ");
int za = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату xb: ");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату yb: ");
int yb = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите координату zb: ");
int zb = int.Parse(Console.ReadLine());

int xd = xb - xa;
int yd = yb - ya;
int zd = zb - za;

if (za == 0 && zb == 0)
{
 Console.WriteLine( "Расстояние между точками в пространстве 2D: ");
  Console.WriteLine(Math.Sqrt((xd*xd) + (yd*yd)));   
}
else
{
 Console.WriteLine( "Расстояние между точками в пространстве 3D: ");
  Console.WriteLine(Math.Sqrt((xd*xd) + (yd*yd) + (zd*zd)));   
}