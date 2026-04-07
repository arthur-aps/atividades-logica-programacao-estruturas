public class Ex10_CalculoComEscolhaDeOperacao
{
    public static void Executar()
    {
        double num1, num2;
        Console.Write("Digite o primeiro número: ");
        double.TryParse(Console.ReadLine(), out num1);

        Console.Write("Digite o segundo número: ");
        double.TryParse(Console.ReadLine(), out num2);

        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");
        Console.Write("Opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        double resultado;

        switch (opcao)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {resultado:F3}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}