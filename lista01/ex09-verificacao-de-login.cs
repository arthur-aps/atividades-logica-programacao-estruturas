public class Ex09_VerificacaoDeLogin
{
    public static void Executar()
    {
        string usuario, senha;

        do {
            Console.Write("Digite o nome de usuário: ");
            usuario = Console.ReadLine();

            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();

            if (usuario != "admin" || senha != "1234")
            {
                Console.WriteLine("Login ou senha incorretos. Tente novamente.\n");
            }
        } while (usuario != "admin" || senha != "1234");

        Console.WriteLine("Login bem-sucedido!");
    }
}