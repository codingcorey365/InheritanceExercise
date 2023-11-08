using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; }
        public bool IsNocturnal { get; set; }
        public bool HasFeathers { get; set; }
        public bool HasHollowBones { get; set; }
    }
}
