void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"


██████╗░███████╗░█████╗░████████╗██╗░░░██╗    ██╗░░██╗░█████╗░██╗░░░██╗░██████╗███████╗
██╔══██╗██╔════╝██╔══██╗╚══██╔══╝╚██╗░██╔╝    ██║░░██║██╔══██╗██║░░░██║██╔════╝██╔════╝
██████╦╝█████╗░░███████║░░░██║░░░░╚████╔╝░    ███████║██║░░██║██║░░░██║╚█████╗░█████╗░░
██╔══██╗██╔══╝░░██╔══██║░░░██║░░░░░╚██╔╝░░    ██╔══██║██║░░██║██║░░░██║░╚═══██╗██╔══╝░░
██████╦╝███████╗██║░░██║░░░██║░░░░░░██║░░░    ██║░░██║╚█████╔╝╚██████╔╝██████╔╝███████╗
╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░░░╚═╝░░░    ╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═════╝░╚══════╝");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para encerrar\n");

    String opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    switch (opcaoNumerica)
    {
        case 1:
            Console.WriteLine("Registrar banda");
            break;
        case 2:
            Console.WriteLine("Mostrar todas os serviços");
            break;
        case 3:
            Console.WriteLine("Avaliar salão");
            break;
        case 4:
            Console.WriteLine("Exibir fotos de atendimentos");
            break;
        default:
            Console.WriteLine("Encerrando programa");
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();