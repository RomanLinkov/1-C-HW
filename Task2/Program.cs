Console.WriteLine("Салам алейкум, брат!");
Console.WriteLine("Введи вервое целое число, брат:");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе целое число, брат:");
int NumberB = Convert.ToInt32(Console.ReadLine());

if(NumberA > NumberB)
{
    Console.Write("Наибольшее число: ", NumberA);
    Console.WriteLine(NumberA);
}
else
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(NumberB);
}