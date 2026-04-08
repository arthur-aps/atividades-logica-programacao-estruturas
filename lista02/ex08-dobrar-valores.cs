public class Ex08_DobrarValores
{
    public static void Executar()
    {
        int[] numeros = new int[6];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            int.TryParse(Console.ReadLine(), out numeros[i]);
        }

        Console.WriteLine("Números dobrados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] *= 2;
            Console.Write($"{numeros[i]}, ");
        }
        Console.WriteLine("\b\b.");
    }
}