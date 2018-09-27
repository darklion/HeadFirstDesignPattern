﻿namespace Strategy.Duck
{
    public class RubberDuck : Duck 
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }

        public override string Display()
        {
            return "looks like a rubberduck";
        }
    }
}