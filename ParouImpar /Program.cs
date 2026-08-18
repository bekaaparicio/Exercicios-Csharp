class program 
{
static bool Numeroprimo(int numero)
{
if (numero < 2)
{
return false;
}
for (int i = 2; i < numero; i++)
{
if (numero % i == 0)
{
return false;
}
}
return true;

}
static void Main()
{
Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

if (Numeroprimo(numero))
{
Console.WriteLine("{0} é primo", numero);
}
else
{
Console.WriteLine("o número não é primo");
            }
        }
    }


    class program
{
    static void Calcularconsumo(float km, float l, float resultado)
    {

        resultado = km / l;
        Console.WriteLine(resultado);
        if (resultado < 8)
        {
            Console.WriteLine("Alto consumo!");
        }
        else if (resultado > 12)
        {
            Console.WriteLine("Econômico");
        }
        else
        {
            Console.WriteLine("Consumo normal");
        }

    }


    static void Main()
    {
        float l, km, resultado;
        resultado = 0;
        Console.WriteLine("Digite a distancia percorida");
        km = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite quantos litros de combustivel foi utilizado");
        l = float.Parse(Console.ReadLine());
        Calcularconsumo(km, l, resultado);


    }
}

class program
{
    static string Extenso(int numero)
    {
        string[] valor =
        {
            "um" , "dois", "dois" , "tres" , "quatro", "cinco" , "seis", "sete", "oito", "nove", "dez"
        };
        return (valor[numero]);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número entre 1 e 10");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1 && numero <= 10)
        {
            Console.WriteLine(Extenso(numero));
        }
        else
        {
            Console.WriteLine("Numero invalido");
        }


    }



}































