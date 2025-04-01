﻿namespace Jogodos_dados.ConosoleApp
{
    /*  Versão 3 - Incluir o computador como oponente 
    Requisitos:

    Informar que o computador está jogando
    Armazenar a posição do computador na pista e atualizar o valor após o lançamento do dado
    Atualizar a posição do computador após seu lançamento de dado
    Exibir a nova posição
    Verificar se o computador alcançou ou ultrapassou a linha de chegada
    Informar quem venceu o jogo
    Implementar turnos alternados entre jogador e computador
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

                    int resultadoDoComputador = LancarDado();

                    ExibirResultadoDoSorteio(resultadoDoComputador);

                    posicaoUsuario += resultadoDoComputador;

                    Console.WriteLine($"O jogador esta na posicao: {posicaoUsuario} de {limiteLinhaChegada}");

                    if (posicaoUsuario >= limiteLinhaChegada)
                    { 
                        Console.WriteLine("Parabens voce alcancou a linha de chegada!");
                        Console.ReadLine();

                        jogoEstaEmAndamento = false;
                        continue;
                    }
                    else

                        Console.WriteLine($"O jogador esta na posicao: {posicaoUsuario} de {limiteLinhaChegada}");
                    Console.Write("Pressione  ENTER para continuar");
                    Console.ReadLine();


                    // Turno do computador
                    ExibirCabecalho("Computador");

                    int resultadoComputador = LancarDado();

                    ExibirResultadoDoSorteio(resultadoComputador);

                    posicaoComputador += resultadoComputador;

                    Console.WriteLine($"O jogador esta na posicao: {posicaoUsuario} de {limiteLinhaChegada}");

                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("Que pena o computador alcancou a linha de chegada!");
                        Console.ReadLine() ;

                        jogoEstaEmAndamento = false;
                        continue;

                    }
                    else

                        Console.WriteLine($"O computador esta na posicao: {posicaoComputador} de {limiteLinhaChegada}");
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

