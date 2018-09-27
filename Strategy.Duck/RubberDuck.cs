namespace Strategy.Duck
{
    public class RubberDuck : Duck
    {
        public override string Display()
        {
            return "looks like a rubberduck";
        }

        public override string Quack()
        {
            return "squeak";
        }

        public override string Fly()
        {
            return "nothing";
        }
    }
}