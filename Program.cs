/* Написать прогрмамму, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 симвала. */

string SelectingValues(string[] array)
{
    int numberСharacters = 0;
    int length = array.Length;
    int i = 0;
    int j = 0;
    string[] arrNew = new string[length];
    while (i < length)
    {
        string text = array[i];
        numberСharacters = text.Length;
        if (numberСharacters <= 3)
        {
            arrNew[j] = array[i];
            Console.Write($"{arrNew[j]} ");
            j++;
        }
        i++;
    }
    return arrNew[j];
}

Console.Clear();
Console.WriteLine("***Программа вывода массив из строк, длина которых меньше либо равна 3 симвала***");
Console.WriteLine();
Console.WriteLine("Ведите массив любых значений через пробел:");
string[] arrayValues = Console.ReadLine()!.Split();
Console.Write(" -> ");
SelectingValues(arrayValues);
Console.WriteLine();