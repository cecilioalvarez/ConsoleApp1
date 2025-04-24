using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Caja
    {
        private CajaFlyWeight _flyWeight;

        public string Color { get; }
        public int  Lado1  { get; }
        public int Lado2 { get;}
        public double Precio { get; set; }

        public Caja(string color, int lado, double precio)
        {
            DiccionarioCajaFlyWeight diccionario =DiccionarioCajaFlyWeight.GetInstance();
           
            
            _flyWeight = diccionario.CajaFlyWeight[color];
            this.Color = _flyWeight.Color;
            this.Lado1 = _flyWeight.Lado;
            this.Lado2 = _flyWeight.Lado;
            this.Precio = precio;

        } 

        public double Area()
        {

            return this.Lado1*this.Lado2;
        }

        public override string ToString()
        {
            return this.Lado1+ " " +this.Lado2 + " " +this.Color + " " +this.Precio;

        }

    }
}
