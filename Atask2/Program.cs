// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Secdig(int number)
{
    int mid = number %100/10;
    return mid; 
}
Console.WriteLine("Введите, пожалуйста,целое трёхзначное число и я покажу Вам его вторую цифру: ");
int result = Convert.ToInt32(Console.ReadLine());
if (result < 100||result > 999 )
  {
 Console.WriteLine("К сожалению, вы ввели не то число.");
  }
  else
  {
      result=Secdig(result);
    Console.WriteLine($"вторая цифра {result} ");
  }
*/
//Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
/*
  int Threechar(int number)
{
      while (number > 999)
      {
        number = number / 10;
      }
      number = number % 10; 
      return number;
}

Console.WriteLine($" Введите, пожалуйста,целое не отрицательное число до 2 147 483 648 {":)."}: " );
int result = Convert.ToInt32(Console.ReadLine());
   if (result < 100)
 {
        Console.WriteLine("третьей цифры нет");
 }
   else
   { 
    result = Threechar (result);
    Console.WriteLine($"третья цифра числа {result}");
   }
   */

   //Задача 15: Напишите программу, которая принимает на вход цифру, 
   //обозначающую день недели, и проверяет, является ли этот день выходным.
   
bool Dayoff (int number) 
 {
  if(number == 6 || number == 7)
      return true;
  else 
      return false;   
 }
 Console.WriteLine("Please enter the number of the day of the week: " );
 int result = Convert.ToInt32(Console.ReadLine());
 bool res = Dayoff (result);
 Console.WriteLine($" It's {res} that it's a day off.");



 

