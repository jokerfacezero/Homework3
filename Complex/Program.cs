
bool flag = false;
while (!flag)
{
    Complex complex1 = new Complex(1, 2);

    Complex complex2 = new Complex(3, 4) ;


    Console.WriteLine("Введите действие, которое хотите совершить \n" +
        "Введите 0 чтобы выйти из программы");
    string task = (Console.ReadLine());
    switch (task)
    {
        case "+":
            Complex resultSum = complex1.Plus(complex2);
            Console.WriteLine("Сложение " + resultSum.ToString());
            Console.ReadKey();
            break;
        case "-":
            Complex resultminus = complex1.Minus(complex2);
            Console.WriteLine("вычетание " + resultminus.ToString());
            Console.ReadKey();
            break;
        case "*":
            Complex resultMulti = complex1.MultiCation(complex2);
           Console.WriteLine("Умножение " + resultMulti.ToString());
            break;
        case "0":
            flag = true;
            break;
        default:
            Console.WriteLine("Такого задания нет...");
            break;

    }
}
Console.ReadKey();