namespace Strategy.Duck
{
    public class Quack : IQuackBehavior
    {
        public string quack()
        {
            return "quack";
        }
    }
}