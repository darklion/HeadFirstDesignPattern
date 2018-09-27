namespace Strategy.Duck
{
    public class RubberDuck : Duck , IQuackable
    {
        public override string Display()
        {
            return "looks like a rubberduck";
        }

        public   string Quack()
        {
            return "squeak";
        } 
    }
}