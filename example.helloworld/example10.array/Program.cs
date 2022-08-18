int[] array = { 1, 9, 6, 5, 7, 8, 4, 2, 7 };
int n = array.Length;
int find = 4;//найти позицию числа по  индаксу 
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;

}