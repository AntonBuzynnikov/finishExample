Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] str = CreateArrayString(arrayLength);
System.Console.Write("Исходный массив: ");
PrintArray(str);
System.Console.WriteLine();
string[] newStr = NewArray(str);
System.Console.Write("Новый массив: ");
PrintArray(newStr);
Console.ReadKey();



void PrintArray(string[] array)
{
    for(int i = 0;i<array.Length;i++)
    {
        System.Console.Write($"\"{array[i]}\" ");
    }
    
}

string[] NewArray(string[] array)
{
    int arrLength = 0;
    for(int i  = 0;i<array.Length;i++)
    {
        int k = 0;
        foreach(char s in array[i])
            k++;
        if(k<=3)
            arrLength++;
    }
    string[] newArray = ArrayStringShort(arrLength,array);
    return newArray;
}

string[] ArrayStringShort(int x, string[] arr)
{
    string[] array = new string[x];
    int j = 0;
    for(int i = 0;i<arr.Length;i++)
    {
        int k = 0;
        foreach(char c in arr[i])
            k++;
        if(k<=3)
        {
            array[j] = arr[i];
            j++;
        }
    }
    return array;
}

string[] CreateArrayString(int x)
{
    string[] array = new string[x];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    Console.Clear();
    return array;
}