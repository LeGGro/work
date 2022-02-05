using System;
using System.Collections.Generic;
using System.Text;

namespace working
{
    class ObjectHierarchi
    {
        public List<GameObject> allObjects = new List<GameObject>();
        public void Add(GameObject obj)
        {
            allObjects.Add(obj);
        }

    }
}
