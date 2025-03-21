using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {

        private int cargaMaxima;
        private int gas;
        private string tipogas;
        public Camion(int anio, string elColor, string elModelo, int cargaMaxima, string tipogas) : base(anio, elColor, elModelo)
        {
            this.cargaMaxima = cargaMaxima;
            this.tipogas = tipogas;
        }

        public override void acelerar(int cuanto)   
        {
         
            int velocidad = (int)(cuanto * 0.5);
            base.acelerar(velocidad);
            gas -= 5;
        }

        public override void frenar(int cuanto)
        {
            
            
            int velocidad = (int)(cuanto * 0.7);
            base.frenar(velocidad);
            gas -= 2;
        }
        public void cargarGasolina(int cuanto)
        {
            gas += cuanto;
            Console.WriteLine("Cargando gasolina....");
        }
        public void GasolinaRestante()
        {
            Console.WriteLine("Gasolina restante: {0}", gas);
        }
        public override void encender()
        {
            if (gas <= 0)
            {
                Console.WriteLine("No hay gasolina, cargue gasolina");
                return;
            }
            Console.WriteLine("Encendiendo....");
            base.encender();
        }


        public override void InformacionVehiculo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Carga Maxima : {0}", cargaMaxima);
            Console.WriteLine("Tipo de Gasolina: {0}", tipogas);
            base.InformacionVehiculo();
            Console.WriteLine("----------------------");
        }
    }
   
}
