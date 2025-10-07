namespace ArreglosBidimencionalesv2
{
    public static class MatrixProcessor
    {
        public static void Run()
        {
            Console.WriteLine("+======================================================================+");
            Console.WriteLine("|     EJERCICIO 2: MATRIZ DINÁMICA (MÁX/MÍN Y POSICIONES)              |");
            Console.WriteLine("+----------------------------------------------------------------------+");

            int filas;
            while (true)
            {
                Console.Write("Número de filas (>0): ");
                string? s = Console.ReadLine();
                if (int.TryParse(s, out filas) && filas > 0) break;
                Console.WriteLine("Valor inválido. Intente de nuevo.");
            }

            int cols;
            while (true)
            {
                Console.Write("Número de columnas (>0): ");
                string? s = Console.ReadLine();
                if (int.TryParse(s, out cols) && cols > 0) break;
                Console.WriteLine("Valor inválido. Intente de nuevo.");
            }

            int[,] m = new int[filas, cols];

            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    while (true)
                    {
                        Console.Write($"Valor en [fila {i + 1}, col {j + 1}]: ");
                        string? s = Console.ReadLine();
                        int v;
                        if (int.TryParse(s, out v))
                        {
                            m[i, j] = v;
                            break;
                        }
                        Console.WriteLine("Valor inválido. Intente de nuevo.");
                    }
                }
            }

            Console.WriteLine();
            string header = "Fila/Col |";
            for (int j = 0; j < cols; j++) header += $" {j + 1,6} |";
            Console.WriteLine("+----------------------------------------------------------------------+");
            Console.WriteLine(header);
            Console.WriteLine("+----------------------------------------------------------------------+");

            for (int i = 0; i < filas; i++)
            {
                string row = $"   {i + 1,3}  |";
                for (int j = 0; j < cols; j++)
                    row += $" {m[i, j],6} |";
                Console.WriteLine(row);
            }
            Console.WriteLine("+----------------------------------------------------------------------+");

            int maxVal = m[0, 0], maxI = 0, maxJ = 0;
            int minVal = m[0, 0], minI = 0, minJ = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (m[i, j] > maxVal) { maxVal = m[i, j]; maxI = i; maxJ = j; }
                    if (m[i, j] < minVal) { minVal = m[i, j]; minI = i; minJ = j; }
                }
            }

            Console.WriteLine();
            Console.WriteLine("+----------------------------------------------------------------------+");
            Console.WriteLine($"Mayor valor: {maxVal} en posición ({maxI + 1},{maxJ + 1}) |  ({maxI},{maxJ})");
            Console.WriteLine($"Menor valor: {minVal} en posición ({minI + 1},{minJ + 1}) |  ({minI},{minJ})");
            Console.WriteLine("+----------------------------------------------------------------------+");
        }
    }
}
