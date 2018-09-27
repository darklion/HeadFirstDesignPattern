namespace Strategy.Duck
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public string Fly()
        {
            return "rocket fly";
        }
    }
}