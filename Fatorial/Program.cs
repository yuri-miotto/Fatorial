internal class Program
{
    private static void Main(string[] args)
    {
        int num, resposta;

        Console.WriteLine("Informe um valor: ");
        num = int.Parse(Console.ReadLine());

        resposta = fat(num);
        Console.WriteLine("O fatorial de " + num + " é: " + resposta);

        int fat(int valor)
        {
            if (valor == 0)
            {
                return 1;
            }
            else
            {
                return (valor * fat(valor-1));
            }
        }



    }
}