// Доделаю попозже

    static void Main (string[] args)
    {
        Fraction fract1 = new Fraction();
        fract1.numerator = 1;
        fract1.denominator = 2;
        Fraction fract2 = new Fraction();
        fract2.numerator = 1;
        fract2.denominator = 3;

        Fraction resultSum = fract1.Plus(fract2);
        Console.WriteLine (resultSum.ToString());
        Console.WriteLine();

        Fraction ResultMinus = fract1.Minus(fract2);
        Console.WriteLine(ResultMinus.ToString());
        Console.WriteLine();

        Fraction ResultMulti = fract1.MultiCation(fract2);
        Console.WriteLine(ResultMulti.ToString());
        Console.WriteLine();

        Fraction ResultDivis = fract1.Division(fract2);
        Console.WriteLine(ResultDivis.ToString());
        Console.WriteLine ();

        Console.ReadKey ();
    }
}
