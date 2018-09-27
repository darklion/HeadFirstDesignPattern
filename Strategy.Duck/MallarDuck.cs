namespace Strategy.Duck
{
    public class MallarDuck : Duck , IFlyable, IQuackable
    {
        public override string Display()
        {
            return "looks like a mallard";
        }

        public string Fly()
        {
            return "fly";
        }

        public string Quack()
        {
            return "quack";
        }
    }
}