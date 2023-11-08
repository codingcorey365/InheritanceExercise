using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool CanShed { get; set; }
        public bool ColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public bool HasLungs { get; set; }

    }
}
