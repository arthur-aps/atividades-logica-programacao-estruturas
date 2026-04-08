public class Ex10_NotasDeAlunos
{
    public static void Executar()
    {
        double[] notas = new double[5];
        double soma = 0;
        double media;
        int contaAcimaMedia = 0;

        Console.WriteLine("Digite as notas dos alunos:");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Nota do aluno {i + 1}: ");
            double.TryParse(Console.ReadLine(), out notas[i]);
            soma += notas[i];
        }

        media = soma / notas.Length;
        Console.WriteLine($"\nMédia da turma: {media:F1}");

        Console.WriteLine("Alunos com nota acima da média:");
        for (int i = 0; i < notas.Length; i++)        {
            if (notas[i] > media)
            {
                Console.WriteLine($"Aluno {i + 1} - Nota: {notas[i]:F1}");
                contaAcimaMedia++;
            }
        }
        Console.WriteLine($"\nTotal de alunos com nota acima da média: {contaAcimaMedia}");
    }
}