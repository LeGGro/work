using System;
using System.Collections.Generic;
using System.Text;

namespace working
{
    class KinematicEntities: Error
    {
        public enum Walls 
        {
            _usualWall = 1,
            _stairs = 2
        }

        public void SetWall(int startX, int endX, int startY, int endY)
        {
            if (startY != endY)
            {
                Console.WriteLine(InvalidRange);
                
            
            }
        }
    }
}
