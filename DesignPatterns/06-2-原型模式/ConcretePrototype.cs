using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2_原型模式
{
    public class ConcretePrototype:Prototype
    {
        public ConcretePrototype(string id) : base(id)
        { 
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
