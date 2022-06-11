public string Compra(double parcela, double valor)
{
    double compra = valor * parcela;
    string texto = "Sua compra de R$ " + compra + " em " + parcela + "X de R$ " + valor + " foi concluida!";
    return texto; 
}

string a = Compra(10, 120);
Console.WriteLine(a);