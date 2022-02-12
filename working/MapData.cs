using System;
using System.Collections.Generic;
using System.Text;

namespace working
{
    class MapData
    {
        private int width;
        private int height;
        public char[,] Map;
        public char signToFill;

        public MapData()
        { }
        public MapData(int Width, int Height, char signTo)
        {
            signToFill = signTo;
            Map = new char[Height,Width];
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
        public void ShowMap(ObjectHierarchi objects)
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (int y = 0; y < objects.allObjects.Count; y++)
            {
                Map[objects.allObjects[y].position2d.x, objects.allObjects[y].position2d.y] = objects.allObjects[y].pointer;
            }
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (Map[y, x] == (char)4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    else
                    { Console.ForegroundColor = ConsoleColor.White; }
                    Console.Write(Map[y, x]); Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int y = 0; y < objects.allObjects.Count; y++)
            {
                Map[objects.allObjects[y].position2d.x, objects.allObjects[y].position2d.y] = signToFill;
            }
        }
        /// <summary>
        /// Shows the map as a table of values, with numered strokes. Console output.
        /// </summary>
        public void ShowMap(int d)
        { 
            //: TODO fix the showing. necessery to show with objects
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
