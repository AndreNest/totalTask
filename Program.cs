// программа из имеющегося массива строк делает массив формирует массив из строк с тремя и менее символами
Console.WriteLine("сколько значений будет в массиве?");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
string[] newArray = new string[array.Length];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите значение №{i + 1}: ");
    array[i] = Console.ReadLine();
}
void SelectArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Исходный массив: ");
PrintArray(array);
SelectArray(array, newArray);
Console.WriteLine("Полученный массив: ");
PrintArray(newArray);


