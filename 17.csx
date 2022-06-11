public bool numero(double par)
{
    bool verificar = par % 2 == 0;
    return verificar;
}

bool x = numero(3);
Console.WriteLine(x);