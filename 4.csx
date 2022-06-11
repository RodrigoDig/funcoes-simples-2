public bool reprovou(double nota1, double nota2, double nota3)
{
    double a = (nota1 + nota2 + nota3) /3;
    bool c = a >=5;
    return c;
}
bool x = reprovou(5, 5, 3);
Console.WriteLine(x);