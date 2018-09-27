using System;

namespace Strategy.Duck
{
    public abstract class Duck
    {
        public virtual string Quack()
        {
            return "quack";
        }

        public string Swim()
        {
            return "swim";
        }

        public virtual string Fly()
        {
            return "fly";
        }

        public abstract string Display();
    }
}
