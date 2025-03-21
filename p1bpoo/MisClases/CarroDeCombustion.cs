using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroDeCombustion : Vehiculo
    {
        private int Gas=0;
        private int CapacidadTanque;
        private string TipodeGas;
        public CarroDeCombustion(int anio, string elColor, string elModelo, string TipodeGas,int CapacidadTanque) : base(anio, elColor, elModelo )
        {
            this.TipodeGas = TipodeGas;
            this.CapacidadTanque = CapacidadTanque;
        }
        public override void InformacionVehiculo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Tipo de Gasolina : {0}", TipodeGas);
            Console.WriteLine("capacidad del tanque: {0}", CapacidadTanque);
            base.InformacionVehiculo();
            Console.WriteLine("----------------------");


        }
        

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
            Gas-=1;
        }

        public void cargarGasolina(int cuanto)
        {
            if (cuanto + Gas > CapacidadTanque ) 
            {
                Console.WriteLine("Estas full");
            }if (cuanto > CapacidadTanque) 
            { 
                Console.WriteLine("No puedes cargar mas de {0} litros", CapacidadTanque);
            }
            else
            {
                Gas += cuanto;
            }
        }
        public void GasolinaRestante()
        {
            Console.WriteLine("Gasolina Restante: {0}", Gas);
        }
        public override void acelerar(int cuanto)
        {
            if (Gas <= 0)
            {
                Console.WriteLine("No hay gasolina");
                return;
            }
            base.acelerar(cuanto);
            Gas-=2;
        }
        public override void encender()
        {
            if (Gas <= 0)
            {
                Console.WriteLine("No hay gasolina");
                return;
            }
            base.encender();
        }
    }
}
