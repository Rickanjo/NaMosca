Console.WriteLine("=-= Na Mosca =-=");

const double distanciaNaMosca = 1;
const double distanciaBons = 3;
const double distanciaRuins  = 1;

static double CalcularDistancia(double x, double y) 
{
    double distancia = Math.Sqrt(x * x + y * y);
    return distancia;
}

static string ClassificarAcerto(double distancia)
{
    if (distancia <=distanciaNaMosca)
    {
        return "Na mosca";

    } else if (distancia <= distanciaBons)
    {
        return "bons";

    } else if (distancia <= distanciaRuins)
    {
        return "ruiins";
    }else
    {
        return "erros";
    }
}

Console.Write("Digite a coordenada X: ");
double x = double.Parse(Console.ReadLine()!);

Console.Write("Digite a coordenada Y: ");
double y = double.Parse(Console.ReadLine()!);

double distancia = CalcularDistancia(x, y);
string classificacao = ClassificarAcerto(distancia);  

Console.WriteLine($"\nDistância do centro: {distancia:N2}");

Console.WriteLine($"\nO arremesso foi classificado como: {classificacao}"); 



