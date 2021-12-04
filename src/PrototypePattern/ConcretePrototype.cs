using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class ConcretePrototype : Prototype//or ICloneable
    {
        //some props
        public string Name { get; set; }
        public int Id { get; set; }
        public ConcretePrototype(string name,int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public override Prototype Clone()
        {
            //this.MemberwiseClone创建当前对象的浅表副本
            return (Prototype)MemberwiseClone();
        }
    }
}
