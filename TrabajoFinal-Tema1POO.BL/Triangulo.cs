using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinal_Tema1POO.BL.Enums;

namespace TrabajoFinal_Tema1POO.BL
{
    public class Triangulo:ICloneable
    {
        public double Lado { get; set; }
        public Borde Borde { get; set; }
        public Triangulo()
        {

        }
        
        public double GetPerimetro()=>Lado* 3;
        public double GetSuperficie() => Math.Round((Math.Sqrt(3)/4)* Lado,2);
        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Triangulo))
            {
                return false;
            }
            return this.Lado == ((Triangulo)obj).Lado && this.Borde ==((Triangulo)obj).Borde;
        }
        public override int GetHashCode()
        {
            return this.Lado.GetHashCode() + this.Borde.GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
