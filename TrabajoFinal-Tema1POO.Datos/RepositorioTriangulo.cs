using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinal_Tema1POO.BL;
using TrabajoFinal_Tema1POO.BL.Enums;

namespace TrabajoFinal_Tema1POO.Datos
{
    public class RepositorioTriangulo
    {
        List<Triangulo> triangulos { get; set; } = new List<Triangulo>();
        private readonly string _Archivo = Environment.CurrentDirectory + "\\Triangulos.txt";
        private readonly string _ArchivoBak = Environment.CurrentDirectory + "\\Triangulos.Bak";

        public RepositorioTriangulo()
        {
            LeerDatosDeRegistro();
        }

        private void LeerDatosDeRegistro()
        {
            if (File.Exists(_Archivo))
            {
                StreamReader lector = new StreamReader(_Archivo);
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    Triangulo triangulo = ConstruirTriangulo(linea);
                    triangulos.Add(triangulo);

                }
                lector.Close();
            }
            else
            {
                throw new Exception("Archivo de registro no encontrado");
            }
        }

        private Triangulo ConstruirTriangulo(string linea)
        {
            var campos = linea.Split(';');
            return new Triangulo
            {
                Lado = double.Parse(campos[0]),
                Borde = (Borde)byte.Parse(campos[1])
            };
        }

        public void Agregar(Triangulo triangulo)
        {
            triangulos.Add(triangulo);
            GuardarRegistro(triangulo);
        }

        private void GuardarRegistro(Triangulo triangulo)
        {
            StreamWriter escritor = new StreamWriter(_Archivo, true);
            string linea = ConstruirLinea(triangulo);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Triangulo triangulo)
        {
            return $"{triangulo.Lado};{triangulo.Borde.GetHashCode()}";
        }

        public void Editar(Triangulo trianguloEditada, Triangulo trianguloABuscar)
        {
            StreamReader lector = new StreamReader(_Archivo);
            StreamWriter escritor = new StreamWriter(_ArchivoBak);
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                Triangulo trianguloArchivo = ConstruirTriangulo(linea);
                if (trianguloArchivo.Equals(trianguloABuscar))
                {
                    linea = ConstruirLinea(trianguloEditada);
                } 
                escritor.WriteLine(linea);
            }
            lector.Close();
            escritor.Close();
            File.Delete(_Archivo);
            File.Move(_ArchivoBak, _Archivo);
        }
        public void Borrar(Triangulo triangulo)
        {
            triangulos.Remove(triangulo);
            BorrarRegistroArchivo(triangulo);
        }

        private void BorrarRegistroArchivo(Triangulo triangulo)
        {
            StreamReader lector = new StreamReader(_Archivo);
            StreamWriter escritor = new StreamWriter(_ArchivoBak);
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                Triangulo trianguloArchivo = ConstruirTriangulo(linea);
                if (!trianguloArchivo.Equals(triangulo))
                {
                    escritor.WriteLine(linea);
                }
            }
            lector.Close();
            escritor.Close();
            File.Delete(_Archivo);
            File.Move(_ArchivoBak, _Archivo);
        }

        public List<Triangulo> GetLista()
        {
            return triangulos;
        }

        public List<Triangulo> OrdenarLado()
        {
            return triangulos.OrderBy(t => t.Lado).ThenBy(t => t.Borde).ToList();
        }

        public List<Triangulo> OrdenarBorde()
        {
            return triangulos.OrderBy(t => t.Borde).ThenBy(t => t.Lado).ToList();
        }
    }
}
