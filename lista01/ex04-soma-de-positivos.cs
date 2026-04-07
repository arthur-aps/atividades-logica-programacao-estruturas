public class Ex04_SomaDePositivos
{
    public static void Executar()
    {
        int soma = 0;
        int numero;

        do {
            Console.Write("Digite um número (ou um número negativo para sair): ");
            int.TryParse(Console.ReadLine(), out numero);

            if (numero > 0) {
                soma += numero;
            }
        } while (numero >= 0);

        Console.WriteLine("A soma dos números positivos é: {0}", soma);
    }
}