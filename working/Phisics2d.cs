using System;
using System.Collections.Generic;
using System.Text;

namespace working
{
    class Phisics2d
    {
        public GameObject parent;
        public DateTime currTime = new DateTime();
        //public DateTime fallTime = new DateTime(0,0,0,0,0,1);
        public int Gravity;
        public int Mass;
        public bool isGrounded;
        public Collision2d coll;
        public Phisics2d()
        {
            
        
        }
        public void Fall(MapData Map, ObjectHierarchi hi)
        {
            while (true)
            {
                if (Map.Map[parent.position2d.x , parent.position2d.y+ 1 ] != parent.Collision2D.collision)
                {

                    currTime = DateTime.Now;
                    //Console.WriteLine(DateTime.Now.ToString() + " " + currTime.ToString());
                    while (DateTime.Now.Second  - currTime.Second != 1)
                    { }
                    parent.position2d.x += 1;
                    //Console.WriteLine("iter" + parent.position2d.x);
                }
                Map.ShowMap(hi);
            }
        }
    }
}
