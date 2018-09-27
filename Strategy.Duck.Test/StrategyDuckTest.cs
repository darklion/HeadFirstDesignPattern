using System;
using Xunit;

namespace Strategy.Duck.Test
{
    public class StrategyDuckTest
    {
        [Fact]
        public void MallarDuck_Should_Quack_Swim_Fly_Display()
        {
            Duck mallarDuck = new MallarDuck();

            Assert.Equal("quack", mallarDuck.PerformQuack());
            Assert.Equal("swim", mallarDuck.Swim());
            Assert.Equal("fly", mallarDuck.PerformFly());
            Assert.Equal("looks like a mallard", mallarDuck.Display());
        }

        [Fact]
        public void RedheadDuck_Should_Quack_Swim_Fly_Display()
        {
            var redheadDuck = new RedheadDuck();

            Assert.Equal("quack", redheadDuck.PerformQuack());
            Assert.Equal("swim", redheadDuck.Swim());
            Assert.Equal("fly", redheadDuck.PerformFly());
            Assert.Equal("looks like a redhead", redheadDuck.Display()); 
        }

        [Fact]
        public void RubberDuck_Should_Quack_Swim_Display()
        {
            var rubberDuck = new RubberDuck();

            Assert.Equal("squeak", rubberDuck.PerformQuack());
            Assert.Equal("swim", rubberDuck.Swim()); 
            Assert.Equal("looks like a rubberduck", rubberDuck.Display());
        }

        [Fact]
        public void RubberDuck_Should_Not_Fly()
        {
            var rubberDuck = new RubberDuck();

            Assert.Equal(String.Empty, rubberDuck.PerformFly());
        }
        
        [Fact]
        public void DecoyDuck_Should_Swim_Display()
        {
            var decoyDuck = new DecoycDuck();

            Assert.Equal("swim", decoyDuck.Swim());
            Assert.Equal("looks like a decoyduck", decoyDuck.Display());
        }

        [Fact]
        public void DecoyDuck_Should_Not_Fly_Quack()
        {
            var decoyDuck = new DecoycDuck();

            Assert.Equal(String.Empty, decoyDuck.PerformQuack());
            Assert.Equal(string.Empty, decoyDuck.PerformFly());
        }

        [Fact]
        public void ModelDuck_Should_Change_FlyBehavior()
        {
            var modelDuck = new ModelDuck();

            Assert.Equal(String.Empty, modelDuck.PerformFly());

            modelDuck.FlyBehavior = new FlyRocketPowered();

            Assert.Equal("rocket fly", modelDuck.PerformFly());
        }
    }
}
