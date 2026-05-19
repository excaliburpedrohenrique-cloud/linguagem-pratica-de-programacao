Console.WriteLine("Selecione uma opção de 1 a 4: ");
Console.WriteLine("1 - CADASTRO, " + " 2 - LISTAR USUÁRIOS, " + " 3 - EXCLUIR USUÁRIO, " + " 4 - SAIR");

string Opções = (Console.ReadLine())!;

switch (Opções)
{
    case "1":
        Console.WriteLine("Você escolheu cadastro!");
        break;
    
    case "2":
        Console.WriteLine("Você escolheu listar usuários!");
        break;

    case "3":
        Console.WriteLine("Você escolheu excluir usuário!");
        break;

    case "4":
        Console.WriteLine("Você escolheu sair!");
        break;

    default:
        Console.WriteLine("ERRO");
        break;
}