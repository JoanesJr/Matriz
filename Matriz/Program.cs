using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte[,] matriz = new byte[9, 9];
            byte[] values = new byte[5];
            for (byte value = 0; value < values.Length; value++)
            {
                values[value] = (byte)((value + 1));
            }
            for (byte line = 0; line < matriz.GetLength(0); line++)
            {
                for (byte collumn = 0; collumn < matriz.GetLength(1); collumn++)
                {
                    if (line == 4 && collumn == 4)
                    {
                        matriz[line, collumn] = values[0];
                    }else if ((line >= 3 && line <= 5) && (collumn >= 3 && collumn <= 5))
                    {
                        matriz[line, collumn] = values[1];
                    }else if ((line >= 2 && line <= 6) && (collumn >= 2 && collumn <= 6))
                    {
                        matriz[line, collumn] = values[2];
                    }else if ((line >= 1 && line <= 7) && (collumn >= 1 && collumn <= 7))
                    {
                        matriz[line, collumn] = values[3];
                    }else
                    {
                        matriz[line, collumn] = values[4];
                    }
                }
            }

            for (byte line = 0; line < matriz.GetLength(0); line++)
            {
                for (byte collumn = 0; collumn < matriz.GetLength(1); collumn++)
                {    
                    Console.Write(" " + matriz[line, collumn] + " ");
                    if (collumn == 8)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
