using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        private string Modelo { get;   }
        private int Year { get;   }

        private int velocidad = 0;

        private bool encendido = false;



        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public virtual void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
           
        }
        public virtual void acelerar(int cuanto)
        {
            if (!encendido )
            {
                Console.WriteLine("El vehiculo esta apagado, enciendalo");
                return;
            }
              
            velocidad += cuanto;
            Console.WriteLine("Acelerando.... vas a {0} KMS / Hora",this.velocidad);
            
        }
        public virtual void frenar(int cuanto)
        {
            if (!encendido )
            {
                Console.WriteLine("El vehiculo esta apagado");
                return;
            }
             
                 
                velocidad -= cuanto;
            Console.WriteLine("Frenando... vas a {0} KMS / Hora",this.velocidad);
            

        }
        public virtual void encender()
        {
            if (!encendido)
            {
                Console.WriteLine("Encendiendo el vehiculo");
                 encendido = true;
            }
            else { Console.WriteLine("El vehiculo ya esta encendido"); }
        }
         

        public virtual void apagar()
        {
            if (!encendido)
            {
                Console.WriteLine("El vehiculo ya esta apagado");
                return;
            }
            else
            {
                Console.WriteLine("Apagando el vehiculo");
                 encendido = false;
                velocidad = 0;
            }
           
        }
    }
}
