string[] array1 = new string [4] {"hello", "2", "world", "^_^"};
string[] array2 = new string [array1.Length];

void CountElementsLess3 (string [] array1, string [] array2)
{
    int count = 0;
    for (int i=0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        array2[count] = array1 [i];
        count++;
    }
} 

void ShowArray(string[] array)
{
    for (int i=0; i < array1.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
CountElementsLess3(array1, array2);
ShowArray(array1);
ShowArray(array2);
