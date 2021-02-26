using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;

namespace SafariPark.Hierarchy
{
    public abstract class ClassofAnimal : Animal
    {
        public Classes Classes { get; set; }
    }
}
