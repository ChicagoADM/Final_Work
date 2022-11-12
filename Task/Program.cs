// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Exit()
{
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
Console.Clear();

void Zadacha()
{
int size = Convert.ToInt32(InpMess("Введите длину строчного массива: "));
string[] arrOne = new string[size];
string[] arrTwo = new string[arrOne.Length];
FillArray(arrOne);
Console.WriteLine("Массив:");
PrintArray(arrOne);
SortLenghtElement(arrOne, arrTwo);
Console.WriteLine("Массив меньше либо равный 3 символам:");
PrintArray(arrTwo);
}

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InpMess($"Введите символы в {i+1}-ю строку, нажмите Enter: ");
    }
    Console.WriteLine();
}

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("]");
}

string InpMess(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

void SortLenghtElement(string[] arrOne, string[] arrTwo)
{
    int count = 0;
    for (int i = 0; i < arrOne.Length; i++)
    {
        if (arrOne[i].Length <= 3)
        {
            arrTwo[count] = arrOne[i];
            count++;
        }
    }
}
Zadacha();
Exit();