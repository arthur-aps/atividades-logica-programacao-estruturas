public class Ex08_MediaDeNotas
{
    public static void Executar()
    {
        int[] numeros = Ex04_SomaDePositivos.Soma();

        int media = numeros[0] / numeros[1];

        Console.WriteLine($"A média das notas é: {media}");
    }
}