public class Ex02_MaiorDeTresNumeros
{
    public static void Executar()
    {
        int a, b, c;

        Console.Write("Digite o primeiro número: ");
        int.TryParse(Console.ReadLine(), out a);
        Console.Write("Digite o segundo número: ");
        int.TryParse(Console.ReadLine(), out b);
        Console.Write("Digite o terceiro número: ");
        int.TryParse(Console.ReadLine(), out c);

        if (a == b && b == c) {
            Console.WriteLine("Os três números são iguais.");
        } else if (a >= b && a >= c) {
            Console.WriteLine($"O maior número é: {a}");
        } else if (b >= a && b >= c) {
            Console.WriteLine($"O maior número é: {b}");
        } else {
            Console.WriteLine($"O maior número é: {c}");
        }
    }
}