using System;
using System.Collections.Generic;
using System.Text;

namespace working
{
    class GameObject
    {
        #region COMPONENTS
        public Phisics2d Phisics2D;
        public Collision2d Collision2D;
        #endregion
        public string name = "newObj";
        public Vector3 position3d = new Vector3(0,0,1);
        public Vector2 position2d = new Vector2(0, 0);
        public char pointer;
        public GameObject(string namer, Vector2 pos, char point)
        {
            name = namer;
            position2d = pos;
            pointer = point;
        }
        public GameObject(string namer, Vector3 pos, char point)
        {
            name = namer;
            position3d = pos;
            pointer = point;
        }
        public GameObject(int x, int y, char point)
        {
            position2d.x = x;
            position2d.y = y;
            pointer = point;
        }
        public GameObject(int x, int y, int z, char point)
        {
            position3d.x = x;
            position3d.y = y;
            position3d.z = z;
            pointer = point;
        }
        public void AddComponent(Phisics2d phis)
        {
            Phisics2D = phis;
            Phisics2D.parent = this;

        }
        public void AddComponent(Collision2d coll)
        {
            Collision2D = coll;
            Collision2D.parent = this;
        }
    }
}
