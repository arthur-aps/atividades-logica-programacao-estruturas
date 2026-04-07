public class Ex05_MenuDeOpcoes
{
    public static void Fatorial()
    {
        Console.Write("Digite um número menor que 16: ");
        int numero;

        if (int.TryParse(Console.ReadLine(), out numero) && numero >= 0 && numero < 16) {
            long fatorial = 1;

            for (int i = 2; i <= numero; i++) {
                fatorial *= i;
            }

            Console.WriteLine("O fatorial de {0} é: {1}", numero, fatorial);        
        } else {
            Console.WriteLine("Número inválido. Por favor, digite um número entre 0 e 15.");
        }
    }
    
    public static void Executar()
    {
        while (true) {
            Console.Clear();
            Console.WriteLine("-------- Menu --------");
            Console.WriteLine("1. Saudação");
            Console.WriteLine("2. Data atual");
            Console.WriteLine("3. Hora atual");
            Console.WriteLine("4. Fatorial de um número (menor que 16)");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    Console.WriteLine("----------------------------\n");
                    Console.WriteLine("Olá! Bem-vindo ao menu de opções.");
                    break;
                case "2":
                    Console.WriteLine("----------------------------\n");
                    Console.WriteLine("A data atual é: {0}", DateTime.Now.Date.ToShortDateString());
                    break;
                case "3":
                    Console.WriteLine("----------------------------\n");
                    Console.WriteLine("A hora atual é: {0}", DateTime.Now.TimeOfDay.ToString().Substring(0, 8));
                    break;
                case "4":
                    Console.WriteLine("----------------------------\n");
                    Fatorial();
                    break;
                case "0":
                    Console.WriteLine("----------------------------\n");
                    Console.WriteLine("Saindo do menu...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}