using System;

namespace ArreglosBidimencionalesv2
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("+======================================================================+");
                Console.WriteLine("|                 PRÁCTICAS SOBRE ARREGLOS BIDIMENSIONALES             |");
                Console.WriteLine("+----------------------------------------------------------------------+");
                Console.WriteLine("|  1) Promedio de 4 estudiantes en 3 asignaturas                       |");
                Console.WriteLine("|  2) Matriz dinámica: máximo, mínimo y posiciones                     |");
                Console.WriteLine("|  0) Salir                                                            |");
                Console.WriteLine("+----------------------------------------------------------------------+");
                Console.Write("Seleccione una opción: ");

                string? opt = Console.ReadLine()?.Trim();
                Console.Clear();

                if (opt == "1")
                {
                    StudentAverages.Run();
                }
                else if (opt == "2")
                {
                    MatrixProcessor.Run();
                }
                else if (opt == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("+----------------------------------------------------------------------+");
                    Console.WriteLine("| Opción no válida.                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------+");
                }

                Console.WriteLine("\nPresione ENTER para volver al menú...");
                Console.ReadLine();
            }
        }
    }
}