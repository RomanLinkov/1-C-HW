Console.WriteLine("Салам алейкум, брат!");
Console.WriteLine("Введи вервое целое число, брат:");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе целое число, брат:");
int NumberB = Convert.ToInt32(Console.ReadLine());

if(NumberA > NumberB)
{
    Console.Write("Большее число: ", NumberA);
    Console.WriteLine(NumberA);
    Console.Write("Меньшее число: ", NumberB);
    Console.WriteLine(NumberB);
}
else
{
    Console.Write("Большее число: ");
    Console.WriteLine(NumberB);
    Console.Write("Меньшее число: ", NumberA);
    Console.WriteLine(NumberA);
}