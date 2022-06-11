public bool filme(int idade1, int idade2, int cls1, int cls2)
{
    bool pode = idade1 >= cls1 && idade2 >= cls1 && idade1 >= cls2 && idade2 >= cls2;
    return pode;
}

bool x = filme(18, 18, 14, 20);
Console.WriteLine(x);