public double calculo(double sal, double bonus, double desc)
{
    double bo = (bonus * 100) /10;
    double s = sal + bo;
    double d = s - desc;
    return d;

}

double x= calculo(1000, 10, 300);
Console.WriteLine(x);