int[] array = { 1, 9, 4, 6, 4, 5, 7, 8, 4, 2, 7 };
int n = array.Length;
int find = 4;//найти позицию числа по  индаксу 
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;// при первом нахождении остоновит итерацию
    }
    index++;

}