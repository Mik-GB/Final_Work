// Задача: Написать программу, которая из имеющегося массива строк формирует массив из 
// строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами
// Пример:
// ["hello", "2", "world", ".-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// string[] arrayInit = new string[5] { "723", "1223", "hello", "world", "res" };
// string[] arrayFinite = new string[arrayInit.Length];
// void ResultArray(string[] arrayInit, string[] arrayFinite)
// {
//     int count = 0;
//     for (int i = 0; i < arrayInit.Length; i++)
//     {
//         if (arrayInit[i].Length <= 3)
//         {
//             arrayFinite[count] = arrayInit[i];
//             count++;
//         }
//     }
// }
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// Console.WriteLine("Исходный массив:");
// PrintArray(arrayInit);
// ResultArray(arrayInit, arrayFinite);
// Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам:");
// PrintArray(arrayFinite);


Console.Write("Введите количество элементов для ввода ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
int symbol = 3;
int posit = 0;

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= symbol)
    {
        arrayStrings[posit] = element;
        posit++;
    }
}

Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам:");
PrintArray(arrayStrings);