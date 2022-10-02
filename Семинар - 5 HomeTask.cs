// Задача 34
// Задайте массив заполненный случайными положительными трехназными
// числами. Напишите программу, которая покажет количество четных 
// чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот ваш массив: ");
PrintArray(numbers);
int count = 0;
for (int Z = 0; Z < numbers.Length; Z++)
if(numbers[z] % 2 == 0)
count++;
Console.WriteLine($"всего (numbers.Length") чисел, (count) из них четные");
void FillArrayRandomNumbers(int[]numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
    }
    void PrintArray(int[] numbers)
    {
        Console.Write("[ ");
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
}


        
// Задача 36
// Задайте одномерный массив, заполненные случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
FillArrayRandomeNumbers(numbers);
Console.WriteLine("Вот ваш массив: ");
PrintArray(numbers);
int sum = 0;
for (int z = 0; z < numbers.Length; z+=2)
sum = sum + numbers[z];
Console.WriteLine($"всего (numbers.Length) чисел, сумма элементов на нечетных позициях = (sum)");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i=0; i<numbers.Length; i++)
    {
        numbers[i] = newRandom().Next(1,10);
    }
    }
    void PrintArray(int[] numbers)
    {
        Console.Write("[ ");
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "");
        }
        Console.Write("]");
        Console.WriteLine();
}


// Задача 38
// Задайте массив вещественых чисел. Найдите разницу между максимальным
// и минимальны элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[]numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот ваш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for(int z=0; z<numbers.Length; z++)
{
    if(numbers[z] > max)
    {
        max = numbers{z};
    }
    if (numbers[z] < min)
    {
        min = numbers[z];
    }
    }
    Console.WriteLine($"Всего (numbers.Length) чисел. Максимальное значение = (max), минимальное значение = (min)");
    Console.WriteLine($"Разница между максимальным и минимаьным значением = (max - min)");
    void FillArrayRandomNumbers(double[]numbers)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
        }
        void PrintArray(double[]numbers)
        {
            Console.Write("[ ");
            for(int i = 0; i < numbers.Length; (++)
            {
                Console.Write(numbers[i] + "");
            }
            Console.Write("]");
            Console.WriteLine();
}





