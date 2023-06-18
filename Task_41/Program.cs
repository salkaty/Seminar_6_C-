// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.WriteLine("Введите число");
        array[i]=Convert.ToInt32(Console.ReadLine());
        
        if (array[i]>0)
        {
           count++;
        }

    }
System.Console.WriteLine($"Вы ввели {count} чисел больше 0");
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}



Console.Clear();
System.Console.WriteLine("Введите количество чисел, которые хотите ввести");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);

