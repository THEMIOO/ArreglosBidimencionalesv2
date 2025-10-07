namespace ArreglosBidimencionalesv2
{
    public static class StudentAverages
    {
        public static void Run()
        {
            Console.WriteLine("+======================================================================+");
            Console.WriteLine("|              EJERCICIO 1: PROMEDIOS DE ESTUDIANTES (4x3)             |");
            Console.WriteLine("+----------------------------------------------------------------------+");

            const int estudiantes = 4;
            const int asignaturas = 3;
            double[,] notas = new double[estudiantes, asignaturas];

            for (int i = 0; i < estudiantes; i++)
            {
                for (int j = 0; j < asignaturas; j++)
                {
                    while (true)
                    {
                        Console.Write($"Nota del Estudiante {i + 1}, Asignatura {j + 1} (0–100): ");
                        string? s = Console.ReadLine();

                        double v;
                        bool ok = false;

                        if (!string.IsNullOrWhiteSpace(s))
                        {
                            if (double.TryParse(s, out v)) ok = true;
                            else if (s.Contains(",") && double.TryParse(s.Replace(',', '.'), out v)) ok = true;
                            else if (s.Contains(".") && double.TryParse(s.Replace('.', ','), out v)) ok = true;

                            if (ok && v >= 0 && v <= 100)
                            {
                                notas[i, j] = v;
                                break;
                            }
                        }
                        Console.WriteLine("Valor inválido. Intente de nuevo.");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("+----------------------------------------------------------------------+");
            string header = "Estudiante |";
            for (int j = 0; j < asignaturas; j++) header += $"  A{j + 1,6} |";
            header += "  Promedio ";
            Console.WriteLine(header);
            Console.WriteLine("+----------------------------------------------------------------------+");

            for (int i = 0; i < estudiantes; i++)
            {
                double suma = 0;
                string row = $"   {i + 1,3}     |";
                for (int j = 0; j < asignaturas; j++)
                {
                    suma += notas[i, j];
                    row += $"  {notas[i, j],6:0.00} |";
                }
                row += $"  {(suma / asignaturas),8:0.00} ";
                Console.WriteLine(row);
            }
            Console.WriteLine("+----------------------------------------------------------------------+");

            // Promedios por estudiante
            Console.WriteLine("\nPromedio por estudiante:");
            for (int i = 0; i < estudiantes; i++)
            {
                double suma = 0;
                for (int j = 0; j < asignaturas; j++) suma += notas[i, j];
                Console.WriteLine($"  Estudiante {i + 1}: {(suma / asignaturas):0.00}");
            }

            // Promedios por asignatura
            Console.WriteLine("\nPromedio por asignatura:");
            for (int j = 0; j < asignaturas; j++)
            {
                double suma = 0;
                for (int i = 0; i < estudiantes; i++) suma += notas[i, j];
                Console.WriteLine($"  Asignatura {j + 1}: {(suma / estudiantes):0.00}");
            }

            Console.WriteLine("+----------------------------------------------------------------------+");
        }
    }
}
