namespace Strategy.Duck
{
    public class MallarDuck : Duck 
    {
        public MallarDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override string Display()
        {
            return "looks like a mallard";
        } 
    }
}