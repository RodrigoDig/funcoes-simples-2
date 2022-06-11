//Libra (23/09 a 22/10)

public bool signo(string mes, int dia)
{
    bool verificar = mes == "setembro" && dia >= 23;
    bool verificar2 = mes == "outubro" && dia <=22;
    bool final = verificar || verificar2;
    return final; 
}

bool x = signo("setembro", 25);
Console.WriteLine(x);