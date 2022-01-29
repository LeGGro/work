using System;
using System.Collections.Generic;
using System.Text;

namespace working
{
    class MapData<T> where T : notnull
    {
        private readonly int width;
        private readonly int height;
        public T[,] Map;
        public MapData(int Width, int Height, T signToFill)
        {
            Map = new T[Height,Width];
            height = Height;
            width = Width;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {

                    Map[y, x] = signToFill;
                }
            }
        }
        /// <summary>
        /// Shows the map as a table of values. Console output. Put any int in Arguments to extend the info.
        /// </summary>
        public void ShowMap()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(Map[y, x]); Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Shows the map as a table of values, with numered strokes. Console output.
        /// </summary>
        public void ShowMap(int d)
        {
            Console.WriteLine();
            if (height > 10)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(y); Console.Write("  | ");
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(Map[y, x]); Console.Write(" ");
                    }
                    Console.Write("  ");
                    Console.WriteLine();
                }
                for (int y = 10; y < height; y++)
                {
                    Console.Write(y); Console.Write(" | ");
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(Map[y, x]); Console.Write(" ");
                    }
                    Console.Write("  ");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(y); Console.Write(" | ");
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(Map[y, x]); Console.Write(" ");
                    }
                    Console.Write("  ");
                    Console.WriteLine();
                }
            }
        }

        

    }
}
