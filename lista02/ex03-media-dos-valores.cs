public class Ex03_MediaDosValores 
{
    public static void Executar() {
        int[] numeros = new int[6];
        int soma = Ex02_SomaDosElementos.SomarElementos(numeros);

        double media = (double)soma / numeros.Length;
        Console.WriteLine($"A média dos números digitados é: {media:F1}");
    }
}