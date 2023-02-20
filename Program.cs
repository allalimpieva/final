// //// Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

 Console.Clear();

string[] array1(string[] arr, int num = 3)
{
    int len = arr.Length;
    string[] array2;
    int count = 0;

    for (int i = 0; i <= len; i++)
    {
        if (arr[i].Length <= num)
        {
            count++;
        }
    }

    array2 = new string[count];
    count = 0;
    for (int i = 0; i <= len; i++)
    {
        if (arr[i].Length <= num)
        {
            array2[count++] = arr[i];
        }
    }
    return array2;
}
