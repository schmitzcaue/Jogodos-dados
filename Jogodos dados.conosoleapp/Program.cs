namespace Jogodos_dados.ConosoleApp
{
    /*  Versão 4. Para tornar o jogo mais interessante, algumas posições na pista podem ter eventos especiais:
    ○ Avanço extra: 
    Se o competidor parar em uma posição específica (ex.: 5, 10, 15), ele avança +3 casas.
    ○ Recuo: Se o competidor parar em outra posição específica (ex.: 7, 13, 20), ele recua -2 casas.
    ○ Rodada extra: Se o competidor tirar 6 no dado, ele ganha uma rodada extra.
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
                int posicaoComputador = 0;
                bool jogoEstaEmAndamento = true;


                while (jogoEstaEmAndamento)
                {
                    // Turno do usuario
                    ExibirCabecalho("Usuario");

                    int resultadoDoUsuario = LancarDado();

                    ExibirResultadoDoSorteio(resultadoDoUsuario);

                    posicaoUsuario += resultadoDoUsuario;

                    Console.WriteLine($"O jogador esta na posicao: {posicaoUsuario} de {limiteLinhaChegada}");
                    if (posicaoUsuario == 5 || posicaoUsuario == 10 || posicaoUsuario == 15)
                    {
                        Console.WriteLine("O usuario avaçou 3 casas");
                        posicaoUsuario += 3;
                    }
                    if (posicaoUsuario == 7 || posicaoUsuario == 13 || posicaoUsuario == 20 )
                    {
                        Console.WriteLine("O usuario recuou 2 casas");
                        posicaoUsuario -= 2;
                    }
                    if (resultadoDoUsuario == 6)
                    {
                        Console.WriteLine("O jogador ganhou uma rodada extra");
                        Console.WriteLine("--------------------");
                        Console.Write("Pressione  ENTER para continuar");
                        Console.ReadLine();
                        continue;
                    }


                    if (posicaoUsuario >= limiteLinhaChegada)
                    { 
                        Console.WriteLine("Parabens voce alcancou a linha de chegada!");
                        Console.ReadLine();

                        jogoEstaEmAndamento = false;
                        continue;
                    }
                   

                    Console.Write("Pressione  ENTER para continuar");
                    Console.ReadLine();


                    // Turno do computador
                    ExibirCabecalho("Computador");

                    int resultadoComputador = LancarDado();

                    ExibirResultadoDoSorteio(resultadoComputador);

                    posicaoComputador += resultadoComputador;
                    

                    Console.WriteLine($"O computador esta na posicao: {posicaoComputador} de {limiteLinhaChegada}");

                    if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15)
                    {
                        Console.WriteLine("O computador avaçou 3 casas");
                        posicaoComputador += 3;
                    }
                    if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                    {
                        Console.WriteLine("O computador recuou 2 casas");
                        posicaoComputador -= 2;
                    
                    }
                    if (resultadoComputador == 6)
                    {
                        Console.WriteLine("O computador ganhou uma rodada extra");
                        Console.WriteLine("--------------------");
                        Console.Write("Pressione  ENTER para continuar");
                        Console.ReadLine();
                        continue;
                    }



                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("Que pena o computador alcancou a linha de chegada!");
                        Console.ReadLine() ;

                        jogoEstaEmAndamento = false;
                        continue;

                    }
                    
                    Console.Write("Pressione  ENTER para continuar");
                    Console.ReadLine();
                }

                string opcaoContinuar = ExibirMenuContinuar();

                if (opcaoContinuar != "S")
                    break;
            }

        }

        static void ExibirCabecalho(string nomeJogador)
        {
            //cabecalho
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Jogo de dados");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Turno do: { nomeJogador}");

            if (nomeJogador!= "Computador")
            {
                Console.Write("Pressione ENTER para lançar o dado...");
                Console.ReadLine();
            }

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

