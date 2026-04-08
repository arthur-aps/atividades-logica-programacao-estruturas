public class Ex07_BuscaDeValor
{
    public static void Executar()
    {
        int[] numeros = new int[10];
        int valorBuscado;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            int.TryParse(Console.ReadLine(), out numeros[i]);
        }

        Console.Write("Digite um número para buscar: ");
        int.TryParse(Console.ReadLine(), out valorBuscado);

        bool encontrado = false;

        // me recuso a usar IndexOf() pra isso, quero mostrar o processo de busca
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == valorBuscado)
            {
                Console.WriteLine($"Número encontrado na posição {i}.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Número não encontrado no vetor.");
        }
    }
}