class Fraction
{
    int numerator;
    int denominator;

    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public Fraction Plus(Fraction x2)
    {

        if (this.denominator == x2.denominator)
        {
            return new Fraction(x2.numerator + this.numerator, this.denominator);
        }
        else 
        {
            this.numerator = this.numerator * x2.denominator + x2.numerator * this.denominator;
            this.denominator = this.denominator * x2.numerator;

            return new Fraction(x2.numerator + this.numerator, this.denominator);
        }


    }

    //public Fraction Minus(Fraction x2)
    //{
    //    Fraction Minus = new Fraction();
    //    Minus.numerator = this.numerator - x2.numerator;
    //    Minus.denominator = this.denominator - x2.denominator;


    //    return Minus;
    //}
    //public Fraction MultiCation(Fraction x2)
    //{
    //    Fraction MultiCation = new Fraction();
    //    MultiCation.numerator = x2.numerator * this.numerator;
    //    MultiCation.denominator = x2.denominator * this.denominator;
    //    return MultiCation;
    //}
    //public Fraction Division(Fraction x2)
    //{
    //    Fraction Division = new Fraction();
    //    Division.numerator = this.numerator * x2.denominator;
    //    Division.denominator = this.denominator * x2.numerator;
    //    return Division;
    //}
    public string ToString()
    {
        int count = 0;
        for (int i = 0; numerator >= denominator; i++)
        {
            if (numerator == denominator)
            {
                count++;
                break;
            }
            else if (numerator > denominator)
            {
                numerator = numerator - denominator;
                count++;
            }
        }
        if (numerator == 0 || denominator == 0)
        {
            return "Неверное значение, попробуйте снова";
        }
        if (numerator == denominator)
        {
            return " " + count;
        }
        else if (count > 0)
        {
            return "  " + numerator + "\n " + count + "=" + "\n " + " " + denominator;
        }

        else
        {
            return " " + numerator + "\n " + "=" + "\n " + "" + denominator;
        }
    }
}