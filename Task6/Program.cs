Console.Clear();
Console.WriteLine("Салам алейкум, брат!");
Console.WriteLine("Введи целое число, брат:");
int NumberA = Convert.ToInt32(Console.ReadLine());

if(NumberA % 2 == 0)
{
    Console.WriteLine("Твоё число чётное, брат!");
}
else
{
    Console.WriteLine("Твоё число нечётное, брат!");
}