using System.Runtime.InteropServices;


void ExibirLogo()
{
    Console.WriteLine(@"
██████╗░███████╗░█████╗░████████╗██╗░░░██╗    ██╗░░██╗░█████╗░██╗░░░██╗░██████╗███████╗
██╔══██╗██╔════╝██╔══██╗╚══██╔══╝╚██╗░██╔╝    ██║░░██║██╔══██╗██║░░░██║██╔════╝██╔════╝
██████╦╝█████╗░░███████║░░░██║░░░░╚████╔╝░    ███████║██║░░██║██║░░░██║╚█████╗░█████╗░░
██╔══██╗██╔══╝░░██╔══██║░░░██║░░░░░╚██╔╝░░    ██╔══██║██║░░██║██║░░░██║░╚═══██╗██╔══╝░░
██████╦╝███████╗██║░░██║░░░██║░░░░░░██║░░░    ██║░░██║╚█████╔╝╚██████╔╝██████╔╝███████╗
╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░░░╚═╝░░░    ╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═════╝░╚══════╝");
}

List<String> listaBandas = new List<String>();

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 para cadastrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para encerrar");

    String opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    switch (opcaoNumerica)
    {
        case 1:
            registrarCliente();     
            break;
        case 2:
            listaCadastroClientes();
            break;
        case 3:
            Console.WriteLine("Avaliar banda");
            break;
        case 4:
            Console.WriteLine("Exibir fotos de atendimentos");
            break;
        default:
            Console.WriteLine("Encerrando programa");
            break;
    }
}

void registrarCliente()
{
    Console.Clear();
    Console.WriteLine("*** Cadastro de banda ***");
    Console.Write("Nome: ");
    String nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.Write($"Cadastro de  '{nomeBanda}' gerado com sucesso!");
    Console.WriteLine(" Novo cadastro? (s/n): ");
    String opcao = Console.ReadLine()!;
    if (opcao == "s") registrarCliente();
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void listaCadastroClientes()
{
    Console.Clear();
    Console.WriteLine("*** Clientes registrados ***");
    //for (int i = 0; i < listaBandas.Count; i++)
    //{
        //Console.Write($"\nNome: {listaBandas[i]}");
    //}

    foreach (string clientes in listaBandas) Console.WriteLine(clientes);

    Console.Write("\nPressione qualquer tecla para voltar ao menu anterior.");
    Console.ReadKey();
    Console.Clear();

    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();