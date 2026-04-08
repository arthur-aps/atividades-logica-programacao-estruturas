public class Ex04_MaiorEMenorValor
{
    public static void Executar()
    {
        int min = 0, max = 0;
        int[] numeros = new int[8];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            int.TryParse(Console.ReadLine(), out numeros[i]);

            if (i == 0)
            {
                min = max = numeros[i];
            }
            else
            {
                if (numeros[i] < min) min = numeros[i];
                if (numeros[i] > max) max = numeros[i];
            }
        }

        Console.WriteLine($"O menor valor digitado é: {min}");
        Console.WriteLine($"O maior valor digitado é: {max}");
    }
}