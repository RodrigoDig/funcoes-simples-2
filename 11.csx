public double venda (double pqn, double mdo, double gg )
{
    double calcular = pqn * 13.50 + mdo * 15 + gg * 17.50;
    return calcular;
}

double x = venda(2, 2, 1);
Console.WriteLine(x);