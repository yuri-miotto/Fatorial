internal class Program
{
    private static void Main(string[] args)
    {
        int numero, fatorial, temp;
        Console.WriteLine("Informe um número...");
        numero = int.Parse(Console.ReadLine());
        fatorial = 1;

        if (numero == 0)
        {
            fatorial = 1;
        }

        else
        {
            for (int i = 1; i < numero; i++)
            {
                temp = numero - i;
                fatorial *= temp;

            }

            fatorial = fatorial * numero;
        }

        

        

        Console.WriteLine("o fatorial de " + numero + " é " + fatorial);

        Console.ReadKey();



    }
}