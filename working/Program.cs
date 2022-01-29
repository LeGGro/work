using System;

namespace working
{
    class Program
    {
        static void Main(string[] args)
        {
            MapData<int> map = new MapData<int>(20,40, 0);
            map.ShowMap(1);
            Console.ReadKey();
            
        }
    }
}
