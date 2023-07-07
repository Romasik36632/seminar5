/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.Clear();
Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
RandonNumbers(num);
Console.Write("В массиве: ");
PrintArray(num);
void RandonNumbers(int [] num)
{
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
int count = 0;
for(int a = 0; a < num.Length; a++)
{
    if(num[a] % 2 == 0)
    count++;
}
Console.Write($"Из {num.Length} чисел, чётных {count} ");
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for( int i = 0; i < num.Length; i++)
    {
         Console.Write(num[i] + " ");
    }
    Console.Write(" ]");
     Console.WriteLine();
}



