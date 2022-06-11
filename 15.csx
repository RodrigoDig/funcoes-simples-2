public bool filme (double idade, double idade2, double classsificacao)
{
    bool assistir = idade >= classsificacao && idade2 >= classsificacao;
    return assistir;
}

bool x = filme(18, 10, 18);
Console.WriteLine(x);