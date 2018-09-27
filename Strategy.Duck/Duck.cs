using System;

namespace Strategy.Duck
{
    public abstract class Duck
    { 
        public string Swim()
        {
            return "swim";
        } 

        public abstract string Display();
    }
}
