int[] array = {1,2,31,4,35,86,46,57,86};

int n = array.Length;
int find = 86;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}