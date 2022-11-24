string[] FirstArray = new string[6] { "hello", "2", "world", ":)", "555", "zadanie" };
string[] SecondArray = new string[FirstArray.Length];
void FillArray(string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            SecondArray[count] = FirstArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(FirstArray, SecondArray);
PrintArray(SecondArray);
