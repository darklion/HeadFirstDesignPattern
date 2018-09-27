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

        public IFlyBehavior FlyBehavior { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }
          
        public string PerformFly()
        {
            return this.FlyBehavior.Fly();
        }
        public string PerformQuack()
        {
           return this.QuackBehavior.quack();
        }
    }
}
