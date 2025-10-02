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

List<String> listaClientes = new List<String>();

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 para cadastrar cliente");
    Console.WriteLine("Digite 2 para mostrar clientes registrados");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para encerrar\n");

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

void registrarCliente()
{
    Console.Clear();
    Console.WriteLine("*** Cadastro de cliente ***");
    Console.Write("Nome: ");
    String nomeCliente = Console.ReadLine()!;
    listaClientes.Add(nomeCliente);
    Console.Write($"Cadastro de  '{nomeCliente}' gerado com sucesso!");
    Thread.Sleep(2000);
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

    foreach (string clientes in listaClientes) Console.WriteLine(clientes);

    Console.Write("\nPressione qualquer tecla para voltar ao menu anterior.");
    Console.ReadKey();
    Console.Clear();

    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();