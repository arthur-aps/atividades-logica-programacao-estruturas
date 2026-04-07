while (true)
{
    Console.Clear();
    Console.WriteLine("=== Lista 1 ===");
    Console.WriteLine("1. Par ou Ímpar");
    Console.WriteLine("2. Maior de Três Números");
    Console.WriteLine("3. Contagem de 1 a 100");
    Console.WriteLine("4. Soma de Positivos");
    Console.WriteLine("5. Menu de Opções");
    Console.WriteLine("6. Tabuada de um Número");
    Console.WriteLine("7. Contagem Regressiva");
    Console.WriteLine("8. Média de Notas");
    Console.WriteLine("9. Verificação de Login");
    Console.WriteLine("10. Cálculo com escolha de operação");
    Console.WriteLine("0. Sair");
    Console.Write("\nEscolha: ");

    switch (Console.ReadLine())
    {
        case "1": Ex01_ParOuImpar.Executar(); break;
        case "2": Ex02_MaiorDeTresNumeros.Executar(); break;
        case "3": Ex03_ContagemDe1a100.Executar(); break;
        case "4": Ex04_SomaDePositivos.Executar(); break;
        case "5": Ex05_MenuDeOpcoes.Executar(); break;
        case "6": Ex06_TabuadaDeUmNumero.Executar(); break;
        case "7": Ex07_ContagemRegressiva.Executar(); break;
        case "8": Ex08_MediaDeNotas.Executar(); break;
        case "9": Ex09_VerificacaoDeLogin.Executar(); break;
        case "10": Ex10_CalculoComEscolhaDeOperacao.Executar(); break;
        case "0": return;
        default: Console.WriteLine("Opção inválida. Tente novamente."); break;
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar...");
    Console.ReadKey();
}