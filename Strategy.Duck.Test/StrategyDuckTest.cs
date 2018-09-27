using System;
using Xunit;

namespace Strategy.Duck.Test
{
    public class StrategyDuckTest
    {
        [Fact]
        public void MallarDuck_Should_Quack_Swim_Fly_Display()
        {
            var mallarDuck = new MallarDuck();

            Assert.Equal("quack", mallarDuck.Quack());
            Assert.Equal("swim", mallarDuck.Swim());
            Assert.Equal("fly", mallarDuck.Fly());
            Assert.Equal("looks like a mallard", mallarDuck.Display());
        }

        [Fact]
        public void RedheadDuck_Should_Quack_Swim_Fly_Display()
        {
            var redheadDuck = new RedheadDuck();

            Assert.Equal("quack", redheadDuck.Quack());
            Assert.Equal("swim", redheadDuck.Swim());
            Assert.Equal("fly", redheadDuck.Fly());
            Assert.Equal("looks like a redhead", redheadDuck.Display());
        }

        [Fact]
        public void RubberDuck_Should_Quack_Swim_Display()
        {
            var rubberDuck = new RubberDuck();

            Assert.Equal("squeak", rubberDuck.Quack());
            Assert.Equal("swim", rubberDuck.Swim()); 
            Assert.Equal("looks like a rubberduck", rubberDuck.Display());
        }

        [Fact]
        public void RubberDuck_Should_Not_Fly()
        {
            var rubberDuck = new RubberDuck();

            Assert.Equal("nothing", rubberDuck.Fly());
        }
        
        [Fact]
        public void DecoyDuck_Should_Swim_Display()
        {
            var decoyDuck = new DecoyDuck();
             
            Assert.Equal("swim", decoyDuck.Swim()); 
            Assert.Equal("looks like a decoyduck", decoyDuck.Display());
        }

        [Fact]
        public void DecoyDuck_Should_Not_Fly_Quack()
        {
            var decoyDuck = new DecoyDuck();

            Assert.Equal("nothing", decoyDuck.Quack());
            Assert.Equal("nothing", decoyDuck.Fly());
        }

        
    }
}
