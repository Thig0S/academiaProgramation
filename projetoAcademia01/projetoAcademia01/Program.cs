using System;

namespace projetoAcademia01
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int contadorJogador = 0;
            int contadorComputador = 0;

            Console.WriteLine("Bem-vindo ao joguinho de tabuleiro!\n");
            Console.WriteLine("O jogador que fizer 30 primeiro GANHA!\n");
            Enter();

            while (true)
            {
                int qntdJogador = GerarNumero();
                Console.WriteLine($"Você gerou o número {qntdJogador}");
                contadorJogador += qntdJogador;

                contadorJogador += CasasEspeciais(contadorJogador);

                Console.WriteLine($"Você está na casa {contadorJogador}\n");
                Enter();

                if (contadorJogador >= 30)
                {
                    Console.WriteLine("Você ganhou!");
                    Console.WriteLine($"\nPlacar\nVocê: {contadorJogador}\nAdversário: {contadorComputador}");
                    break;
                }
                Enter();
                int qntdComputador = GerarNumero();
                Console.WriteLine($"Seu adversário gerou o número {qntdComputador}");
                contadorComputador += qntdComputador;
                
                contadorComputador += CasasEspeciais(contadorComputador);

                Console.WriteLine($"Seu adversário está na casa {contadorComputador}");
                Enter();

                // Verificar vitória do computador
                if (contadorComputador >= 30)
                {
                    Console.WriteLine("Seu adversário ganhou!");
                    Console.WriteLine($"\nPlacar\nVocê: {contadorJogador}\nAdversário: {contadorComputador}");
                    break;
                }
            }
        }

        static int GerarNumero()
        {
            return random.Next(1, 7);
        }
        static void Enter()
        {
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static int CasasEspeciais(int contador)
        {
            if (contador == 13)
            {
                Console.WriteLine("fez o L e agora voltou para a casa 0!");
                return -13;
            }
            else if (contador == 2)
            {
                Console.WriteLine("na casa 2, avance 2 casas!");
                return 2;
            }
            else if (contador == 19)
            {
                Console.WriteLine("caiu na casa 19, avance 3 casas!");
                return 3; 
            }
            else if (contador == 29)
            {
                Console.WriteLine("Quase ein, pena que vai voltar 5 casas!");
                return -5; 
            }
            else
            {
                return 0;
            }
        }
    }
}