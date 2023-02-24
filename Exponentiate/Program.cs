// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Main() // возведение числа А в степеь числа В
{
  // число, которое возвожу в степень
  Console.Write("Введите число A: ");
  int num = int.Parse(Console.ReadLine());
  // степень в которую возвожу число 
  Console.Write("Введите степень B: ");
  int n = int.Parse(Console.ReadLine());
  // считаем с помомщью *= (пристоение значения после умножения) 
  // число, возведенное в степень, в цикле равном длине n 
  // Exponentiate задаю 1 
  int Exponentiate = 1;
  for(int i = 0; i < n; i++) 
  {
   Exponentiate *= num;
  }
  Console.WriteLine("{0} ^ {1} = {2}", num, n, Exponentiate);
  return Exponentiate;
 }

Main();