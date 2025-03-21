# 📝 Tarea: Herencia y Polimorfismo en C# 🚗⚡


## ¿Qué es este proyecto?

La idea era hacer un sistema de vehículos donde tenemos una clase base que se llama `Vehiculo` y de ahí derivar otras clases como `CarroDeCombustion`, `Motocicleta`, `Camion` y también un `CarroElectrico` que ya venía en el ejemplo.

## ¿Qué hice?

- **Clase `Vehiculo`**: Es como el plano principal, o sea, la clase padre. Tiene propiedades como `Color`, `Modelo`, `Year`, y métodos como `acelerar`, `frenar`, `encender` y `apagar`. Hice unas validaciones para que no acelere si no está encendido y así.
- **Clases derivadas**: Creé las clases `CarroDeCombustion`, `Motocicleta` y `Camion`, cada una con 3 propiedades encapsuladas (`private`) y sobrescribí los métodos para que se comporten diferente. También usé el `CarroElectrico` del ejemplo.
- **Polimorfismo**: Sobrescribí los métodos en cada clase, o sea, el carro de combustión gasta gasolina, la moto acelera más rápido, y el camión acelera más lento.
- 

## ¿Cómo funciona?

El programa crea instancias de los vehículos y prueba sus métodos. Por ejemplo, podés encender un camión, acelerar, frenar, y ver cómo gasta gasolina o cómo se comporta. Cada vehículo tiene su propia lógica, pero todos heredan de `Vehiculo`.

