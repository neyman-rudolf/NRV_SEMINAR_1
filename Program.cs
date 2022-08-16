// Задача №1
// Console.Write("Введите число №1: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число №2: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());

// if (firstnumber <= secondnumber)
// {
//      Console.WriteLine(firstnumber + " min " );
//      Console.WriteLine(secondnumber + " max ");
// }

// else
// {
//       Console.WriteLine(firstnumber + " max " );
//       Console.WriteLine(secondnumber + " min " );
// }


// Задача №2
// Console.Write("Введите число №1: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число №2: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число №3: ");
// int thirtnumber = Convert.ToInt32(Console.ReadLine());

// if (firstnumber <= secondnumber)
// {
//     if (secondnumber <= thirtnumber)
//         {
//             Console.WriteLine(thirtnumber + " max ");
//         }
//         else
//         {
//             Console.WriteLine(secondnumber + " max ");
//         }
// }

// else
// {
//     Console.WriteLine(firstnumber + " max ");
// }

// Задача №3
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 2;

while (N >= number)
{
    Console.WriteLine(number);
    number = number + 2;
}