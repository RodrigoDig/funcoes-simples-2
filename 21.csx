//Implementar uma função que calcule quantas paradas para abastecimento são necessárias para realizar uma viagem, a partir da capacidade do tanque de combústivel (em litros), do consumo do veículo (km por litros) e da distância da viagem (km).


public double viagem(double capacidade, double consumo, double distancia)
{
    double gasto = capacidade / consumo ;
    double paradas = gasto / distancia;

    return paradas;
}

double x = viagem(75, 2, 400);
Console.WriteLine(x);