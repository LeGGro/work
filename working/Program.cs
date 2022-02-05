using System;

namespace working
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            MapData map = new MapData(20,40, '0');
            GameObject first = new GameObject("FIRST_OBJ", new Vector2(6, 5), (char)4);
           // first.components.Add(Phisics2d);
            ObjectHierarchi Hierarchi = new ObjectHierarchi();
            Hierarchi.Add(first);
            map.ShowMap(Hierarchi);
            first.AddComponent(new Phisics2d());
            first.AddComponent(new Collision2d());
            first.Phisics2D.Fall(map, Hierarchi);
            Console.ReadKey();
            
        }
    }
}
