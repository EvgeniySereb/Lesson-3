//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int input()
{
Console.Write("ВВедите число : ");
int number = Convert.ToInt32 (Console.ReadLine());
return number;
}

void res(int Number)
{
int count = 1;
 int result;
while (count <= Number)
{
result = count * count * count;
Console.WriteLine( $"|{result}|{count}|" );
count++;


}
}
int Number =input();

 res(Number);
