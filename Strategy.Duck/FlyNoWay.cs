namespace Strategy.Duck
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return string.Empty;
        }
    }
}