/* Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.  */

int n;
Console.Write($"Введите количество элементов массива:  ");
int.TryParse(Console.ReadLine()!, out n);

string[] array = new string[n];
string h;


for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент № {i + 1} ");
    h = Console.ReadLine()!;
    array[i] = h;
}

Console.WriteLine($"Заданный массив ->  ");

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

