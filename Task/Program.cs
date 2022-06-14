Console.Clear();
Console.WriteLine("Введите массив строк, отделяя элементы массива между собой знаком 'пробела' (' '): ");
var inputStr = Convert.ToString(Console.ReadLine());
string[] mass = inputStr.Split(' ');
Console.Clear();
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] CreateResultArray(string[] array)
{
    int volumeArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            volumeArray++;
        }
    }
    return new string[volumeArray];
}
void FillResultArray(string[] array, string[] resultArray)
{
    int indexOfResultArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[indexOfResultArray] = array[i];
            indexOfResultArray++;
        }
    }
}
string[] resultMass = CreateResultArray(mass);
FillResultArray(mass, resultMass);
PrintArray(resultMass);