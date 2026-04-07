public class Ex07_ContagemRegressiva
{
    public static void Executar()
    {
        Console.WriteLine("Contagem regressiva:");
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); // Pausa de 1 segundo
        }
        Console.WriteLine("Lançar Foguete!");
    }
}