namespace Jogodos_dados.ConosoleApp
{
    /* Versão 1 - Estrutura básica e simulação de dados 
    Requisitos:

    Exibir um banner para o jogo de dados
    Implementar a geração de números aleatórios para simular um dado (1-6)
    Exibir o resultado do lançamento do dado
    Permitir que o usuário pressione Enter para lançar o dado
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirCabecalho();

                int resultado = LancarDado();

                ExibirResultadoDoSorteio(resultado);

                string  opcaoContinuar = ExibirMenuContinuar();

                if (opcaoContinuar != "S")
                    break;
            }

            Console.WriteLine("Hello, World!");
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

            Console.Write("Deseja continuar? (s/N) ");
            string opcaContinuar = Console.ReadLine()!.ToUpper();

            return opcaContinuar;
        }
    }
}

