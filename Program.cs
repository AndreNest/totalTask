// программа из имеющегося массива строк делает массив формирует массив из строк с тремя и менее символами
Console.WriteLine("Сколько будет элементов в исходном массиве?");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for(int i = 0; i < n; i++)
{
    array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
