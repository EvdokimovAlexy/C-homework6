// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество элементов в массиве");
int elementsArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elementsArray];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите элемент массива по индексом {i}:\t");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int FindNumber(int[] array) 
{
    int result = 0; 
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result; 
}
Console.WriteLine("Вывод массива");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();
Console.WriteLine(FindNumber(array));