using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Duck
{
    public class MuteQuack : IQuackBehavior
    {
        public string quack()
        {
            return string.Empty;
        }
    }
}
