/* Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.  */

int n;
Console.Write($"Введите общее количество элементов (где 1 элемент = одной цифре, числу, слову или набору разнообразных символов) массива:  ");
int.TryParse(Console.ReadLine()!, out n);

string[] array = new string[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент № {i + 1} ");
    array[i] = Console.ReadLine()!;
}
Console.WriteLine();
Console.WriteLine($"Заданный массив ->  ");

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine("\n");

