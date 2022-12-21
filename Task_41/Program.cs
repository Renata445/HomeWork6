Console.Clear();
Console.WriteLine("Введите числа: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int k = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        k++;
    }
}
Console.WriteLine(k);