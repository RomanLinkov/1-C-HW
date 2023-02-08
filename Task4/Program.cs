Console.Clear();
Console.WriteLine("Салам алейкум, брат!");
Console.WriteLine("Введи вервое целое число, брат:");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе целое число, брат:");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье целое число, брат:");
int NumberC = Convert.ToInt32(Console.ReadLine());

int max = NumberA;

if (max < NumberB) 
{
    max = NumberB;
}
if (max < NumberC) 
{
    max = NumberC;
}

Console.Write("Наибольшее из трёх чисел: ");
    Console.WriteLine(max);