// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//Ограничения:
//- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
//- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода

Console.Clear();

int count = 8;
int[] array = new int[count]; 

AddArray(array);
PrintArray(array);

void AddArray(int[] array)
{
    Random rand = new Random();
    for(int i = 0; i < count; i++)
    {
        array[i] = rand.Next(-10,10);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");

        if(i == count - 1)

            Console.WriteLine("]");

        else Console.Write(", ");
    }
    Console.WriteLine();
}
