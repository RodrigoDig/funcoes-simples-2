public string Msg(string nome)
{
    string texto = "Seja bem-vindo " + nome;
    return texto; 
}

string x = Msg("Rodrigo!");
Console.WriteLine(x);