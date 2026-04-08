public class Ex01_LeituraEExibicao
{
    public static void Executar() {
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++) {
            Console.Write($"Digite o {i + 1}º número: ");
            int.TryParse(Console.ReadLine(), out numeros[i]);
        }

        Console.WriteLine("Você digitou os seguintes números:");
        foreach (int numero in numeros) {
            Console.Write($"{numero}, ");
        }

        Console.WriteLine("\b\b.");
    }
}