using System;

class Program
{
    static void Main()
    {
        int ultimoDigito = 2;
        int N = ultimoDigito + 10;
        string[] pacientes = new string[N];
        int[] urgencia = new int[N];
        int cantidad = 0;
        int opcion;
        do
        {
            Console.Clear();

            Console.WriteLine("=== HOSPITAL SAN RAFAEL ===");
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Ver pacientes");
            Console.WriteLine("3. Cambiar urgencia");
            Console.WriteLine("4. Eliminar paciente");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            // REGISTRAR
            if (opcion == 1)
            {
                if (cantidad < N)
                {
                    Console.Write("Nombre: ");
                    pacientes[cantidad] = Console.ReadLine();

                    Console.Write("Urgencia (1-5): ");
                    urgencia[cantidad] = int.Parse(Console.ReadLine());

                    cantidad++;

                    Console.WriteLine("Paciente registrado.");
                }
                else
                {
                    Console.WriteLine("No hay espacio.");
                }
            }

            // MOSTRAR
            else if (opcion == 2)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine(
                        i + ". " + pacientes[i] +
                        " - Urgencia: " + urgencia[i]);
                }
            }

            // CAMBIAR URGENCIA
            else if (opcion == 3)
            {
                Console.Write("Posición del paciente: ");
                int pos = int.Parse(Console.ReadLine());

                if (pos >= 0 && pos < cantidad)
                {
                    Console.Write("Nueva urgencia (1-5): ");
                    urgencia[pos] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Urgencia modificada.");
                }
                else
                {
                    Console.WriteLine("Posición incorrecta.");
                }
            }

            // ELIMINAR
            else if (opcion == 4)
            {
                Console.Write("Posición del paciente: ");
                int pos = int.Parse(Console.ReadLine());

                if (pos >= 0 && pos < cantidad)
                {
                    for (int i = pos; i < cantidad - 1; i++)
                    {
                        pacientes[i] = pacientes[i + 1];
                        urgencia[i] = urgencia[i + 1];
                    }

                    cantidad--;

                    Console.WriteLine("Paciente eliminado.");
                }
                else
                {
                    Console.WriteLine("Posición incorrecta.");
                }
            }

            Console.WriteLine("\nPresione ENTER...");
            Console.ReadLine();

        } while (opcion != 5);
    }
}
