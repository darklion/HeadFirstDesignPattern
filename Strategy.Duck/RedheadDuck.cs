namespace Strategy.Duck
{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return "looks like a redhead";
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