public class Ex09_SomaDeDoisVetores
{
    public static void Executar()
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorSoma = new int[5];

        Console.WriteLine("Digite os elementos do Vetor A:");
        for (int i = 0; i < vetorA.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            int.TryParse(Console.ReadLine(), out vetorA[i]);
        }

        Console.WriteLine("\nDigite os elementos do Vetor B:");
        for (int i = 0; i < vetorB.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            int.TryParse(Console.ReadLine(), out vetorB[i]);

            // soma direto aqui pra evitar outro loop depois (já tá meio ruim, melhor não piorar)
            vetorSoma[i] = vetorA[i] + vetorB[i];
        }

        Console.WriteLine("\nVetor Soma (A + B):");
        for (int i = 0; i < vetorSoma.Length; i++)
        {
            Console.Write($"{vetorSoma[i]}, ");
        }
        Console.WriteLine("\b\b.");
    }
}