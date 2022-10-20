// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int sizeArray = UserInput("Введите количество элементов массива: ", "Ошибка ввода!");
int[] array = new int[sizeArray];


static int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int result);
        if (isCorrect)
        {
            return result;
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    if (array[i]>0)
    {
        sum++;
    }   
}
Console.Write($"-> {sum}");