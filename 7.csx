public bool parque(double temperatura)
{
    bool sair = temperatura >=23 && temperatura <=30;
    return sair;
}

bool x = parque(31);
Console.WriteLine(x);