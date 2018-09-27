namespace Strategy.Duck
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "fly";
        }
    }
}