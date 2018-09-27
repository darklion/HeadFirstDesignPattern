namespace Strategy.Duck
{
    public class DecoyDuck : Duck
    {
        public override string Display()
        {
            return "looks like a decoyduck";
        }

        public override string Quack()
        {
            return "nothing";
        }

        public override string Fly()
        {
            return "nothing";
        }
    }
}