using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoResolvido.Entities
{
    internal class Departmant
    {
        public string Name { get; set; }

        public Departmant()
        {
        }

        public Departmant(string name)
        {
            Name = name;
        }
    }
}
