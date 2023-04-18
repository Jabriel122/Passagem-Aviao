// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).



// Entrada

// extern static string Lucas(string a, string b, string c, int d);
// {

// }

string[] nome = new string[5];
string[] Origem = new string[5];
string[] destino = new string[5];
int[] data = new int[5];
int[] mes = new int[5];
int[] ano = new int[5];
int posicao = 0;




Console.WriteLine($"Bem vindo ao Aplicátivo Vijagagens. Para acessar o menu de passagens preciso que você site sua senha.");
string senha = Console.ReadLine();

while (senha != "123456")
{
    Console.WriteLine($"Senha errada, digite novamente");
    senha = Console.ReadLine();
}
    byte opções;
do
{
    Console.WriteLine(@$"
                Menu
    Qual desses menus você gostária de ir

        1- Cadastrar passagem
        2- Listar Passagens
        0- Sair

    ");

    opções = byte.Parse(Console.ReadLine());

    switch (opções)
    {
        case 1:

            Console.WriteLine($"Para começarmos a registrar uma passagem, digite o nome do passageiro");
            nome[posicao] = Console.ReadLine();

            Console.WriteLine($"Agora escreva a origem, onde você está");
            Origem[posicao] = Console.ReadLine();

            Console.WriteLine($"Agora escreva o Destino, onde você está indo");
            destino[posicao] = Console.ReadLine();

            Console.WriteLine($"Agora escreva a data do voo");
            data[posicao] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Agora o mes");
            mes[posicao] = int.Parse(Console.ReadLine());

            Console.WriteLine($"o Ano");
            ano[posicao] = int.Parse(Console.ReadLine());

            while (data[posicao] > 31 || mes[posicao] > 12 || ano[posicao] < 2023)
            {
                Console.WriteLine($"Data ou mes inválida. Digite Novamente");

                Console.WriteLine($"Agora escreva a data do voo");
                data[posicao] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Agora o mes");
                mes[posicao] = int.Parse(Console.ReadLine());

                Console.WriteLine($"o Ano");
                ano[posicao] = int.Parse(Console.ReadLine());
            }

            // Console.WriteLine($"Seu nome é {nome}, Mora em {Origem} e vai para {destino} no dia {Data}/{mes}/{ano}");

            Console.WriteLine(@$"
        
            Gostária de cadastra outras passagem?
        
                    S - Sim
                    N - Não
            ");
            char answer = char.Parse(Console.ReadLine().ToLower());

            while (answer != 's' && answer != 'n')
            {
                Console.WriteLine(@$"
                Resposta errada. Responde entre sim ou não
                    S - Sim
                    N - Não
                ");
                answer = char.Parse(Console.ReadLine().ToLower());
            }

            do
            {

                posicao++;

                Console.WriteLine($"Para começarmos a registrar uma passagem, digite o nome do passageiro");
                nome[posicao] = Console.ReadLine();

                Console.WriteLine($"Agora escreva a origem, onde você está");
                Origem[posicao] = Console.ReadLine();

                Console.WriteLine($"Agora escreva o Destino, onde você está indo");
                destino[posicao] = Console.ReadLine();

                Console.WriteLine($"Agora escreva a data do voo");
                data[posicao] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Agora o mes");
                mes[posicao] = int.Parse(Console.ReadLine());

                Console.WriteLine($"o Ano");
                ano[posicao] = int.Parse(Console.ReadLine());

                while (data[posicao] > 31 || mes[posicao] > 12 || ano[posicao] < 2023)
                {
                    Console.WriteLine($"Data ou mes inválida. Digite Novamente");

                    Console.WriteLine($"Agora escreva a data do voo");
                    data[posicao] = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Agora o mes");
                    mes[posicao] = int.Parse(Console.ReadLine());

                    Console.WriteLine($"o Ano");
                    ano[posicao] = int.Parse(Console.ReadLine());
                }

                // Console.WriteLine($"Seu nome é {nome}, Mora em {Origem} e vai para {destino} no dia {Data}/{mes}/{ano}");

                Console.WriteLine(@$"
        
            Gostária de cadastra outras passagem?
        
                    S - Sim
                    N - Não
            ");
                answer = char.Parse(Console.ReadLine().ToLower());

                while (answer != 's' && answer != 'n')
                {
                    Console.WriteLine(@$"
                Resposta errada. Responde entre sim ou não
                    S - Sim
                    N - Não
                ");
                    answer = char.Parse(Console.ReadLine().ToLower());
                }
            }
            while (answer == 's');

            break;
        case 2:
            Console.WriteLine(@$"
            Lista de passageioros
           - Os Passageiros  registrados até então são:
            ");
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Seu nome é {nome[i]}, Mora em {Origem[i]} e vai para {destino[i]} no dia {data[i]}/{mes[i]}/{ano[i]}");
            }

            break;
        case 0:
            Console.WriteLine($"FIM!!! TCHAUUU");
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;


    }
} while (opções != 0);





// Console.WriteLine(@$"
//             Lista de passageioros
//            - Os Passageiros  registrados até então são:
//             ");
// for (var i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Seu nome é {nome[i]}, Mora em {Origem[i]} e vai para {destino[i]} no dia {data[i]}/{mes[i]}/{ano[i]}");
// }
