int Input()
{
    Console.Write("Введите пятизначное число : ");
    int number =  Convert.ToInt32(Console.ReadLine());
    return number;
}    
 void Check(int number)
{
    var massiv = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
    if (massiv!.Length == 5 )
    {
    
      if (massiv[0] == massiv[4] && massiv[1] == massiv[3])
{
    Console.WriteLine($"{number} является палиандромом");
}
   else 
{
    Console.WriteLine($"{number} не является палиндромом");
}
     
     } 
        else 
     {
        Console.WriteLine("Введено неверное число");

     }
     

}
 int number =Input();
 Check(number);
