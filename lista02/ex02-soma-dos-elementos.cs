public class Ex02_SomaDosElementos 
{
    public static int SomarElementos(int[] numeros) {
        int soma = 0;

        for (int i = 0; i < numeros.Length; i++) {
            Console.Write($"Digite o {i + 1}º número: ");
            int.TryParse(Console.ReadLine(), out numeros[i]);
            soma += numeros[i];
        }
        return soma;
    }

    public static void Executar() {
        int[] numeros = new int[6];
        int soma = SomarElementos(numeros);
        Console.WriteLine($"A soma dos números digitados é: {soma}");
    }
}