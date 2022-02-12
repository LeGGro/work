using System;

namespace working
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            MapData map = new MapData(20,40, '0');
            

            GameObject first = new GameObject("FIRST_OBJ", new Vector2(6, 5), (char)4);
            first.AddComponent(new Phisics2d());
            first.AddComponent(new Collision2d());

            ObjectHierarchi Hierarchi = new ObjectHierarchi();
            Hierarchi.Add(first);
            map.ShowMap(Hierarchi);
            
            GameObject second = new GameObject("Sec_OBJ", new Vector2(7, 7), (char)4);
            second.AddComponent(new Phisics2d());
            second.AddComponent(new Collision2d());
            Hierarchi.Add(second);

            first.Phisics2D.Fall(map, Hierarchi);
            second.Phisics2D.Fall(map, Hierarchi);
            Console.ReadKey();
            
        }
    }
}
