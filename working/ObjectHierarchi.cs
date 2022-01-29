using System;
using System.Collections.Generic;
using System.Text;

namespace working
{
    class ObjectHierarchi<T>
    {
        public List<GameObject<T>> allObjects;
        public void Add(GameObject<T> obj)
        {
            allObjects.Add(obj);
        }

    }
}
