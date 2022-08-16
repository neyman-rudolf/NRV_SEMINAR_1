// Задача №1
Console.Write("Введите число №1: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber <= secondnumber)
{
     Console.WriteLine(firstnumber + " min " );
     Console.WriteLine(secondnumber + " max ");
}

else
{
      Console.WriteLine(firstnumber + " max " );
      Console.WriteLine(secondnumber + " min " );
}
