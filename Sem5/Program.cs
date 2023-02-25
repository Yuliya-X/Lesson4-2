// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// функция заполнения массива рандомными числами 
void GoArray(double[] numbers1)
{
    
    //int N = int.Parse(Console.ReadLine());
    int Length = numbers1.Length;
    int index = 0;
    while (index < Length)
    {
        numbers1[index] = new Random().Next(-9, 9);
        index++;
    }
}

// функция вывода на печать полученных рандомных чисел
void PrintArray(double[] numbers2)
{
    int count = numbers2.Length;
    int index2 = 0;
    while (index2 < count)
    {
        Console.WriteLine(numbers2[index2]);
        index2++;
    }
}
// вычисление сумм
double sum():
{
    sum1 = 0;
    sum2 = 0;
    for (numbers2 < 0)
    {
        sum1 = 
    }
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
double [] array = new double[N]; // определили (ограничили) массив из N элементов
GoArray(array); // заполнили массив рандомными числами 
PrintArray(array); // вывели на печать полученные числа 
