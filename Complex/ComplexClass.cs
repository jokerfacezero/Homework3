class Complex
{
    double re;
    double im;

    public Complex(double re, double im)
    {
        this.re = re;
        this.im = im;
    }

    public Complex Plus(Complex x2)
    {
        return new Complex(this.re + x2.re, this.im + x2.im);
    }
    public string ToString()
    {
        return re + " + " + im + "i";
    }
    public Complex MultiCation(Complex x2)
    {
        return new Complex(this.re * x2.re + this.im * -x2.im, this.re * x2.im + this.im * x2.re);

    }
    public Complex Minus(Complex x2)
    {
        return new Complex(this.im - x2.im, this.re - x2.re);
    }
}