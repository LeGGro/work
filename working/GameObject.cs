using System;
using System.Collections.Generic;
using System.Text;

namespace working
{
    class GameObject<T>
    {
        public string name = "newObj";
        public Vector3 position = new Vector3(0,0,1);
        public T pointer;
    }
}
