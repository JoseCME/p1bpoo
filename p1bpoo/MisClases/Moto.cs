using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    
    internal class Moto : Vehiculo
    {
        private int cilindrada;
        private int gas;
        private string manubrio;
        public Moto(int anio, string elColor, string elModelo, int cilindrada,string manubrio) : base(anio, elColor, elModelo)
        {
          this.cilindrada = cilindrada;
          this.manubrio = manubrio;
        }
        public override void InformacionVehiculo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Cilindrada: {0}", this.cilindrada);
            Console.WriteLine("Manubrio: {0}", this.manubrio);
            base.InformacionVehiculo();
            Console.WriteLine("----------------------");

        }
        public override void encender()
        {
            if (gas <= 0)
            {
                Console.WriteLine("No hay gasolina, cargue gasolina");
                return;
            }
            base.encender();
           
        }
        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
            gas -= 1;
        }
        public override void acelerar(int cuanto)
        {
            if (gas <= 0)
            {
                Console.WriteLine("No hay gasolina, cargue gasolina");
                return;
            }
            int velocidad = (int)(cuanto * 1.5);
            base.acelerar(velocidad);
            gas -= 1;
        }
        public void gasrestante()
        {
            Console.WriteLine("Gasolina restante: {0}", gas);
        }
        public void cargargas(int cuanto) 
        {
            gas += cuanto;

        }
    }
}
