using System.Text;

namespace Parcial1parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drone drone = new Drone();
            string continuar;
            Console.WriteLine("-------------------------------------");
            Console.Write("Porfavor ingrese el nombre del drone: ");
            string nombre = Console.ReadLine();
            drone.NameDrone(nombre);
            do
            {
                try
                {
                    Console.WriteLine("-----------------------------------");
                    Console.Write("Ingrese el peso (Kg) del paquete: ");
                    double peso = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese la distancia (Km) recorrida: ");
                    double distancia = double.Parse(Console.ReadLine());

                    drone.RegistrarEnvio(peso, distancia);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                Console.Write("¿Desea registrar otro envío? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            drone.MostrarInforme();
            Console.WriteLine("Presione ENTER para terminar...");
            Console.ReadLine();
        }
    
    }
}
