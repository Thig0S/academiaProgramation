using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoAcademia02.Objetos;

namespace projetoAcademia02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Triangulo triangulo = new Triangulo();

                Console.WriteLine("Olá bem-vindo ao verificador de triangulos!\n");
                Console.WriteLine("Escolha uma opção:\n 1 - Verificar triangulo\n 2 - Sair do Programa\n");

                double escolha;

                while (true) // verifica se a escolha e valida
                {
                    try
                    {
                        escolha = double.Parse(Console.ReadLine());
                        if (escolha == 1 || escolha == 2)
                        {
                            break;
                        }
                        else
                        {
                            throw new ArgumentException("Digite apenas 1 ou 2:\n");
                        }
                    }
                    catch (Exception)
                    {
                        Console.Write("\nDigite 1 ou 2!\n");
                    }
                }
                if (escolha == 2) //encerra o programa
                {
                    Console.WriteLine("\nObrigado meu fera, até mais!");
                    break;
                }
                Console.Clear();

                while (true) //verificar se o triangulo e valido
                {
                    try
                    {
                        Console.WriteLine("\nDigite o valor do lado X: ");
                        double x = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nDigite o valor do lado Y");
                        double y = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nDigite o valor do lado Z");
                        double z = double.Parse(Console.ReadLine());

                        if (z < 0 || y < 0 || x < 0) //verifica se todos os numeros sao positivos
                        {
                            throw new ArgumentException("Digite apenas valores POSITIVOS");
                        }

                        if (x + y > z && y + z > x && z + x > z) //verifica se o triangulo existe msm
                        {
                            //triangulo valido
                            triangulo.AplicarVariaveis(x, y, z);
                            break;
                        }
                        else
                        {
                            throw new ArgumentException("Digite um triangulo Valido");

                        }
                    }
                    catch
                    {
                        Console.WriteLine("Digite apenas números POSITIVOS e VALIDOS");
                        triangulo.Enter();
                    }
                }
                triangulo.DefinirTriangulo();
                triangulo.Enter();
            }
        }
    } 
}
