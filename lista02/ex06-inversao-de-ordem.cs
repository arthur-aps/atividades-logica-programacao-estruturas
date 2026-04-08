public class Ex06_InversaoDeOrdem
{
    public static void Executar()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            int.TryParse(Console.ReadLine(), out numeros[i]);
        }

        Console.WriteLine("Números na ordem inversa:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write($"{numeros[i]}, ");
        }
        Console.WriteLine("\b\b.");
    }
}