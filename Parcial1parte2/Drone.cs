using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1parte2
{
    internal class Drone
    {
        public string Nombre { get; set; }
        public double PesoTotal { get; private set; }
        public double KilometrosTotales { get; private set; }

        public void NameDrone(string nombre = "XYZ123")
        {
            if (string.IsNullOrWhiteSpace(nombre))
                Nombre = "XYZ123";
            else
                Nombre = nombre;
        }

        public void RegistrarEnvio(double peso, double distancia)
        {
            if (peso < 0) throw new ArgumentException("El peso no puede ser menor a 0");
            if (distancia < 0) throw new ArgumentException("La distancia no puede ser negativa");

            PesoTotal += peso;
            KilometrosTotales += distancia;

            double costo = distancia * 2.00;
            if (peso > 10) costo += 5.00;

            Console.WriteLine($"Envío registrado. Costo: B/. {costo}");
        }

        public void MostrarInforme()
        {
            Console.WriteLine("\n=== INFORME DE ENVIOS ===");
            Console.WriteLine($"Fecha: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Nombre del Drone: {Nombre}");
            Console.WriteLine($"Peso total enviado: {PesoTotal} Kg");
            Console.WriteLine($"Distancia total recorrida: {KilometrosTotales} Km");
        }
    }
}
