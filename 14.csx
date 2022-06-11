public bool filme(double idade, double classificacao)
{
    bool assistir = idade >= classificacao;
    return assistir; 
}

bool x = filme(18, 16);
Console.WriteLine(x);