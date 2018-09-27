namespace Strategy.Duck
{
    public class ModelDuck : Duck 
    {
        public ModelDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override string Display()
        {
            return "looks like a modelduck";
        }
    }
}