using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAcademia02.Objetos
{
    internal class Triangulo
    {
         
        private double X { get; set; }
        private double Y { get; set; }
        private double Z { get; set; }


        public void AplicarVariaveis(double x, double y, double z)
        {

            this.X = x;
            this.Y = y;
            this.Z = z;

        }

        public void DefinirTriangulo() //Verifica qual triangulo é
        {

            if (this.X == this.Y && this.X == this.Z)
            {
                Console.WriteLine("\nTriangulo é Equilatero");
            }
            else if (this.X == this.Y || this.X == this.Y || this.Y == this.Z)
            {
                Console.WriteLine("\nTriangulo é Isosceles");
            }
            else
            {
                Console.WriteLine("\nTriangulo é Escaleno");
            }
        }
        public void Enter() // só para resetar o console e n ficar feio
        {
            string enter;
            Console.WriteLine("Pressione ENTRE para continuar...");
            enter = Console.ReadLine();
            Console.Clear();
        }
    }
}