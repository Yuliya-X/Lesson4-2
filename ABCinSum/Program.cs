// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int Main() 
{
  Console.Write("Введите число: ");  
  int num = int.Parse(Console.ReadLine());
  
  int sum = 0;
  while (num != 0)
  {
    sum += num % 10;
    num /= 10;
    }
  Console.WriteLine("Сумма цифр в числе составляет: " + sum);
  // или Console.Write(sum);
  return sum;
 }

Main();
