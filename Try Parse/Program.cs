int num = 0;
int sum = 0;
int amount = 0;
do
{
    Console.Write("Введите число: ");
    num = GetNumber();
    if (num%2 != 0 && num > 0)
    {
        sum+= num;
        amount++;
    }
    
}
while (num != 0);


Console.WriteLine($"Нечетные положительные числа: ") ;
Console.WriteLine("Сумма: " + sum);
Console.WriteLine("Колличество: " + amount);
Console.ReadKey();
    
int GetNumber ()
{
    if(int.TryParse(Console.ReadLine(), out int i))
    {
        return i;
    }
    else
    {
        return -1;
    }
}

