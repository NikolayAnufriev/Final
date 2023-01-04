# Описание задачи и пути её решения
---

## **Задача:**  

Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Поставленную задачу можно решить 2 способами:
>Метод № 1 (Более массивный в плане строк кода программы)

1. Создать переменную ***n***.
2. Данной переменной присвоим число введенное пользователем при помощи команд "Console.Write" (для ввода значения) и "int.TryParse" ( для перевода типа ***string*** в ***int*** т.к. все что вводится через консоль имеет тип переменной ***string***)
3. Далее мы создаем массив с размером равным переменной ***n***.
4. Вводим через консоль все элементы массива.
5. Выводим полученный массив.
6. Отсортировываем массив.
7. Выводим отсортированный массив.

В виде кода программы все будет выглядеть вот таким образом:

![Код решения программы][Скрин]



[Скрин]: Способ1.PNG