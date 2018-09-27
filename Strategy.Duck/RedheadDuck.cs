namespace Strategy.Duck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override string Display()
        {
            return "looks like a redhead";
        } 
    }
}