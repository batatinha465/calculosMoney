class Money
{
    public enum Meses
    {
        Setembro = 1,
        Outubro = 2,
        Novembro = 3,
        Dezembro = 4,
        Janeiro = 5,
        Fevereiro = 6,
        Março = 7
    }

    private int qntdPessoas;
    private int qntdDias;
    private int valorPorDia;
    private int taxaPets;
    private int taxaLimpeza;
    private int totalPagar;

    public Money(int mes)
    {
        qntdPessoas = PegarQntdPessoas();
        qntdDias = PegarQntdDias();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Tem pet: ");

            if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 2)
            {
                VerificarPet(opcao);
                break;
            }
            else
            {
                Console.WriteLine("Houve um erro, tente novamente.");
                Console.ReadKey();
                continue;
            }
        }
        
        VerificarMes((Meses)mes);
    }

    private void VerificarMes(Meses mes)
    {
        switch (mes)
        {
            case Meses.Setembro: case Meses.Outubro: case Meses.Novembro:
                CalcularMesSetembroOutubroNovembro();
                break;
            case Meses.Dezembro: case Meses.Janeiro: case Meses.Fevereiro:
                CalcularMesDezembroJaneiroFevereiro();
                break;
            case Meses.Março:
                CalcularMesMarco();
                break;
            default:
                Console.WriteLine("O que caralhos tu fez?");
                Console.ReadKey();
                break;
        }
    }

    private void VerificarPet(int opcao)
    {
        switch (opcao)
        {
            case 1:
                taxaPets = 15 * qntdDias;
                break;
            case 2:
                break;
            default:
                Console.WriteLine("O que caralhos tu fez?");
                Console.ReadKey();
                break;
        }
    }

    private void CalcularMesSetembroOutubroNovembro()
    {
        taxaLimpeza = 100;
        
        switch (qntdPessoas)
        {
            case 1:
                valorPorDia = 150;
                break;
            case 2:
                valorPorDia = 180;
                break;
            case 3:
                valorPorDia = 210;
                break;
            case 4:
                valorPorDia = 275;
                break;
            case 5:
                valorPorDia = 340;
                break;
            default:
                Console.WriteLine("O que caralhos tu fez?");
                Console.ReadKey();
                break;
        }

        CalcularValorTotal();
    }

    private void CalcularMesDezembroJaneiroFevereiro()
    {
        taxaLimpeza = 150;
        
        switch (qntdPessoas)
        {
            case 1:
                valorPorDia = 200;
                break;
            case 2:
                valorPorDia = 250;
                break;
            case 3:
                valorPorDia = 330;
                break;
            case 4:
                valorPorDia = 380;
                break;
            case 5:
                valorPorDia = 420;
                break;
            default:
                Console.WriteLine("O que caralhos tu fez?");
                Console.ReadKey();
                break;
        }

        CalcularValorTotal();
    }

    private void CalcularMesMarco()
    {
        taxaLimpeza = 80;
        
        switch (qntdPessoas)
        {
            case 1:
                valorPorDia = 150;
                break;
            case 2:
                valorPorDia = 180;
                break;
            case 3:
                valorPorDia = 210;
                break;
            case 4:
                valorPorDia = 275;
                break;
            case 5:
                valorPorDia = 340;
                break;
            default:
                Console.WriteLine("O que caralhos tu fez?");
                Console.ReadKey();
                break;
        }

        CalcularValorTotal();
    }

    private static int PegarQntdPessoas()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Quantas pessoas: ");
            
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Houve um erro, tente novamente.");
                Console.ReadLine();
                continue;
            }

            if (num < 1)
            {
                Console.WriteLine("Ué...");
                Console.ReadLine();
                continue;
            }
            else if (num > 5)
            {
                Console.WriteLine("Virou suruba mano?");
                Console.ReadLine();
                continue;
            }

            return num;
        }
    }

    private static int PegarQntdDias()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Quantos dias: ");
        
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Houve um erro, tente novamente.");
                Console.ReadLine();
                continue;
            }

            if (num < 1)
            {
                Console.WriteLine("Vai alugar no passado fela da puta?");
                Console.ReadLine();
                continue;
            }

            return num;
        }
    }

    private void CalcularValorTotal()
    {
        Console.Clear();
        
        totalPagar = (valorPorDia * qntdDias) + taxaLimpeza + taxaPets;
        
        Console.WriteLine($"Terá que ser pago {totalPagar} reais no total.");
        Console.ReadKey();
    }
}