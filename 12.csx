public double venda (double pqn, double mdo, double gg, double cupom )
{
    double calcular = pqn * 13.50 + mdo * 15 + gg * 17.50;
    double total = calcular * cupom / 100; 

    double final = calcular - total;
    return final;
}

double x = venda(2, 2, 1, 10);
Console.WriteLine(x);