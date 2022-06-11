public double venda( double quantidade)
{
    double calculo = quantidade * 13.50;
    return calculo;
}

double x = venda(5);
Console.WriteLine(x);