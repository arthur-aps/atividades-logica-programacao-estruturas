while (true)
{
    Console.Clear();
    Console.WriteLine("=== Lista 2 ===");
    Console.WriteLine("1. Leitura e Exibição");
    Console.WriteLine("2. Soma dos Elementos");
    Console.WriteLine("3. Média dos Valores");
    Console.WriteLine("4. Maior e Menor Valor");
    Console.WriteLine("5. Contar Números Pares");
    Console.WriteLine("6. Inversão de Ordem");
    Console.WriteLine("7. Busca de Valor");
    Console.WriteLine("8. Dobrar Valores");
    Console.WriteLine("9. Soma de Dois Vetores");
    Console.WriteLine("10. Notas de Alunos");
    Console.WriteLine("0. Sair");
    Console.Write("\nEscolha: ");

    switch (Console.ReadLine())
    {
        case "1": Ex01_LeituraEExibicao.Executar(); break;
        case "2": Ex02_SomaDosElementos.Executar(); break;
        case "3": Ex03_MediaDosValores.Executar(); break;
        case "4": Ex04_MaiorEMenorValor.Executar(); break;
        case "5": Ex05_ContarNumerosPares.Executar(); break;
        case "6": Ex06_InversaoDeOrdem.Executar(); break;
        case "7": Ex07_BuscaDeValor.Executar(); break;
        case "8": Ex08_DobrarValores.Executar(); break;
        case "9": Ex09_SomaDeDoisVetores.Executar(); break;
        case "10": Ex10_NotasDeAlunos.Executar(); break;
        case "0": return;
        default: Console.WriteLine("Opção inválida. Tente novamente."); break;
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar...");
    Console.ReadKey();
}
