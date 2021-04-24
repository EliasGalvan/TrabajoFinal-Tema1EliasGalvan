using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinal_Tema1POO.BL;
using TrabajoFinal_Tema1POO.Datos;

namespace TrabajoFinal_Tema1POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            RepositorioTriangulo repositorio = new RepositorioTriangulo();
            Console.WriteLine("Ingrese un lado del triangulo equilatero:");
            if(double.TryParse(Console.ReadLine(),out double lado))
            {
                try
                {
                    if (lado > 0)
                    {

                        triangulo.Lado = lado;
                        repositorio.Agregar(triangulo);
                    }
                }
                catch (Exception )
                {
                    Console.WriteLine("Debe ingresar un valor valido");
                }
            }
        }
    }
}
