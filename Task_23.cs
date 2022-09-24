//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int input(string name)
{
Console.WriteLine("Введите координату "+ name);
return Convert.ToInt32 (Console.ReadLine());
}

double result(int x1, int y1, int z1, int x2, int y2, int z2 )
{
int a = x2-x1 ;
int b = y2 - y1;
int c = z2 -z1;
double length = Math.Sqrt(a *a + b * b + c *c);
length = Math.Round(length , 2);
Console.WriteLine($"Длина {length}");
return length;
}


 int x1 = input("x1");
int y1 = input("y1");
int z1 = input("z1");
int x2 = input("x2");
int y2 = input("y2");
int z2 = input("z2");
Console.WriteLine("длина : "+ result(x1, y1, z1 , x2 , y2, z2 ));