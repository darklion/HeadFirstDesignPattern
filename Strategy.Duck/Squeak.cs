namespace Strategy.Duck
{
    public class Squeak : IQuackBehavior
    {
        public string quack()
        {
            return "squeak";
        }
    }
}