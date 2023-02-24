// Напишите метод, который задаёт массив из N элементов и выводит их на экран.

// функция заполнения массива рандомными числами 
void GoArray(int[] numbers1)
{
    
    //int N = int.Parse(Console.ReadLine());
    int Length = numbers1.Length;
    int index = 0;
    while (index < Length)
    {
        numbers1[index] = new Random().Next(0, 100);
        index++;
    }
}

// функция вывода на печать полученных рандомных чисел
void PrintArray(int[] numbers2)
{
    int count = numbers2.Length;
    int index2 = 0;
    while (index2 < count)
    {
        Console.WriteLine(numbers2[index2]);
        index2++;
    }
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int [] array = new int[N]; // определили (ограничили) массив из N элементов
GoArray(array); // заполнили массив рандомными числами 
PrintArray(array); // вывели на печать полученные числа 