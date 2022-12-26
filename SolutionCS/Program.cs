// написать программу,  которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма



void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++) 
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
string[] SortElement(string[] array)
{
    int count = 0;
    string[] newArr = new string[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            Array.Resize(ref newArr, count + 1);
            newArr[count] = array[i];
            count++;
        }
    if (count == 0) Console.WriteLine("Нет элементов с 3 и менее символами");
    return newArr;
}
string[] FillArray()
{
    Console.WriteLine("Введите количество элементов создаваемого строкового массива: ");
    int size = int.Parse(Console.ReadLine()!);
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine()!;
        if (array[i] == string.Empty)
        {
            Console.WriteLine("Введите не нулевое значение");
            i--;
        }
    }
    return array;
}

string[] incomingArr = FillArray();
Console.Clear();
Console.WriteLine("Заданный массив: ");
PrintArray(incomingArr);
Console.WriteLine("Получивщийся массив c элементами в 3 и менее символов: ");
PrintArray(SortElement(incomingArr));