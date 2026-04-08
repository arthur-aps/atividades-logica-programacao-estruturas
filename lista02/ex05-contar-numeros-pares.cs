public class Ex05_ContarNumerosPares
{
    public static void Executar()
    {
        int contadorPares = 0;
        int[] numeros = new int[10];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            int.TryParse(Console.ReadLine(), out numeros[i]);

            if (numeros[i] % 2 == 0)
            {
                contadorPares++;
            }
        }

        Console.WriteLine($"A quantidade de números pares digitados é: {contadorPares}");
    }
}