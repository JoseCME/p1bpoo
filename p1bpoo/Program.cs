
using p1bpoo.MisClases;

CarroDeCombustion Hilux = new CarroDeCombustion(2020, "Rojo", "Toyota", "Disel",100);

Camion Kenworth = new Camion(2021, "Azul", "Kenworth", 1000,"Disel");

Moto yamaha = new Moto(2021, "Gris", "Yamaha", 150, "Deportivo");

CarroElectrico Tesla = new CarroElectrico(2024, "Gris", "Tesla");

Hilux.InformacionVehiculo();
Hilux.GasolinaRestante();
Hilux.encender();
Hilux.cargarGasolina(50);
Hilux.acelerar(20);
Hilux.encender();
Hilux.acelerar(50);
Hilux.GasolinaRestante();
Kenworth.InformacionVehiculo();
Kenworth.GasolinaRestante();
Kenworth.encender();
Kenworth.cargarGasolina(100);
Kenworth.encender();
Kenworth.acelerar(20);
Kenworth.GasolinaRestante();
yamaha.InformacionVehiculo();
yamaha.gasrestante();
yamaha.acelerar(20);
yamaha.cargargas(20);
yamaha.encender();
yamaha.acelerar(20);
yamaha.gasrestante();
yamaha.frenar(20);
yamaha.gasrestante();







