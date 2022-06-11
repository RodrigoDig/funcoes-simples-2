public bool mes(string semestre)
{
    bool sem = semestre == "janeiro" || semestre == "fevereiro" || semestre == "março" || semestre == "abril" || semestre == "maio" || semestre == "junho";
    return sem;
}

bool x = mes("março");
Console.WriteLine(x);