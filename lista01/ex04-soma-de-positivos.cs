public class Ex04_SomaDePositivos
{
    // Retorna um array onde o primeiro elemento 
    // é a soma dos números positivos e o segundo elemento é a quantidade 
    // de números positivos digitados
    public static int[] Soma() {
        int numero;
        int soma = 0;
        int contador = 0;
        int[] numeros = new int[2];

        do {
            Console.Write("Digite um número (negativo para sair):");
            int.TryParse(Console.ReadLine(), out numero);

            if (numero >= 0) {
                soma += numero;
                contador++;
            }
        } while (numero >= 0);

        numeros[0] = soma;
        numeros[1] = contador;
        return numeros;
    }

    public static void Executar()
    {
        int[] numeros = Soma();

        Console.WriteLine("A soma dos números positivos é: {0}", numeros[0]);
    }
}