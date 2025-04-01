namespace Jogodos_dados.ConosoleApp
{
    /* Versão 2 - Controle da posição do jogador 
    Requisitos:
    Armazenar a posição do jogador na pista e atualizar o valor após o lançamento do dado
    Exibir a posição atual do jogador na pista
    Definir a linha de chegada em 30 verificar se o jogador alcançou ou ultrapassou a linha de chegada
    Permitir o jogador realizar várias jogadas
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            //const valor fixo, identificador so leitura,numeros magicos
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoUsuario = 0;
                bool jogoEstaEmAndamento = true;

                while (jogoEstaEmAndamento)
                {
                    ExibirCabecalho();

                    int resultado = LancarDado();

                    ExibirResultadoDoSorteio(resultado);

                    posicaoUsuario += resultado;

                    Console.WriteLine($"O jogador esta na posicao: {posicaoUsuario} de {limiteLinhaChegada}");

                    if (posicaoUsuario >= limiteLinhaChegada)
                    { 
                        Console.WriteLine("Parabens voce alcancou a linha de chegada!");

                        jogoEstaEmAndamento = false;
                    }
                    else

                        Console.WriteLine($"O jogador esta na posicao: {posicaoUsuario} de {limiteLinhaChegada}");

                    Console.Write("Pressione  ENTER para continuar");
                    Console.ReadLine();
                }

                string opcaoContinuar = ExibirMenuContinuar();

                if (opcaoContinuar != "S")
                    break;
            }

        }

        static void ExibirCabecalho()
        {
            //cabecalho
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Jogo de dados");
            Console.WriteLine("--------------------");

            Console.Write("Pressione ENTER para lançar o dado...");
            Console.ReadLine();
        }

        static int LancarDado()
        {
            //lancamento dado
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;
        }
        static void ExibirResultadoDoSorteio(int resultado)
        {
            //exibe o resultado
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine($" O valor sorteado foi: {resultado}");
            Console.WriteLine("--------------------");
        }
        static string ExibirMenuContinuar()
        {
            Console.WriteLine("--------------------");
            Console.Write("Deseja continuar? (s/N) ");
            Console.WriteLine("--------------------");
            string opcaContinuar = Console.ReadLine()!.ToUpper();

            return opcaContinuar;
        }
    }
}

