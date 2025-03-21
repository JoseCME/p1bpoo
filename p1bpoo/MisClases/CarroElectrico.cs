using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            cargaBateria = 50;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }


        public int NivelBateria()
        {
            Console.WriteLine("El nivel de bateria es {0}", this.cargaBateria);
            return this.cargaBateria;
        }
        public void cargarBateria()
        {
            cargaBateria++;
        }
        public override void InformacionVehiculo()
        {
            Console.WriteLine("----------------------");
            base.InformacionVehiculo();
            Console.WriteLine("----------------------");
        }


    }
}
