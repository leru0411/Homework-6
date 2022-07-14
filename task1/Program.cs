// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int[] GenerateArray(int length, string message)
{
    int[] userNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        userNumbers[i] = Prompt(message);
    }
    return userNumbers;
}

int CountNumbers(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}
int M = Prompt("Введите количество элементов: ");
int[] myArray = GenerateArray(M, "Введите число: ");
int counts = CountNumbers(myArray);
System.Console.WriteLine($"Количество введнных элементов больше нуля равно {counts}");