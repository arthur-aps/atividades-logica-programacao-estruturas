public class Ex01_ParOuImpar 
{
    public static void Executar() 
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0) {
            Console.WriteLine("O número é par.");
        } else {
            Console.WriteLine("O número é ímpar.");
        }
    }
}

