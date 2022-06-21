/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */


/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");

    }
    Console.WriteLine();
}

void CheckDigit(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count ++;
        }
    }
    System.Console.WriteLine(count);
}


int[] mass = new int[6];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
}

Print(mass);
CheckDigit(mass);
 */

/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");

    }
    Console.WriteLine();
}

void TotalSumm(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        summ += arr[i];
    }
    System.Console.WriteLine(summ);
}


int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 10);
}

Print(mass);
TotalSumm(mass); */

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */

int GetMax(int[] array)
{
    int maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement)
            maxElement = array[i];
    }
    return maxElement;
} 

int GetMin(int[] array)
{
    int minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement)
            minElement = array[i];
    }
    return minElement;
} 

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");

    }
    Console.WriteLine();
}

int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 100);
}

Print(mass);
Console.WriteLine();
Console.WriteLine(GetMax(mass) - GetMin(mass));


// Самым разумным решением считаю это: 
// Console.WriteLine(mass.Max() - mass.Min()); 
// Но можно и зморочиться ;))