internal class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1 - Setembro");
            Console.WriteLine("2 - Outubro");
            Console.WriteLine("3 - Novembro");
            Console.WriteLine("4 - Dezembro");
            Console.WriteLine("5 - Janeiro");
            Console.WriteLine("6 - Fevereiro");
            Console.WriteLine("7 - Março");
            Console.Write("Qual mês: ");

            if (int.TryParse(Console.ReadLine(), out int mes) && mes >= 1 && mes <= 7)
            {
                Money money = new(mes);
                break;
            }
            else
            {
                Console.WriteLine("Houve um erro, tente novamente.");
                Console.ReadKey();
                continue;
            }
        }
    }
}
