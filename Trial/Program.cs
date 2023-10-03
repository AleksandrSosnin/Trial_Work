
class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива через запятую: ");
        string input = (Console.ReadLine()!);
        string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine($"Конечный массив: [{string.Join(", ", FilterStrings(inputArray))}]");
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int resultIndex = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[resultIndex] = inputArray[i];
                resultIndex++;
            }
        }
        return resultArray;
    }
}
