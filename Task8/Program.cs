Console.Clear();
Console.WriteLine("Салам алейкум, брат!");
Console.WriteLine("Введи натуральное число, брат:");
int N = Convert.ToInt32(Console.ReadLine());

int count = 2;
int N1 = N-1;
Console.Write("Все чётные натуральные числа, меньшие или равные твоему числу: ");

while (count <= N)
{
    Console.Write(count);
    if (count<N1) { Console.Write(", ");}
    count=count+2;
}
Console.WriteLine();
