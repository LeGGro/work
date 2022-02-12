using System;

namespace working
{
    abstract class Error
    {
        public string InvalidRange
        {
            get {return "range is not vaild"; }
        
        }
        public static void GetError(object error)
        {
            Console.WriteLine(error);
            
        }
        
    }
    
}
