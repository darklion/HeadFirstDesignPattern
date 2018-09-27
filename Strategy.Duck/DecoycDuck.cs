namespace Strategy.Duck
{
    public class DecoycDuck : Duck
    {
        public DecoycDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override string Display()
        {
            return "looks like a decoyduck";
        } 
    }
}