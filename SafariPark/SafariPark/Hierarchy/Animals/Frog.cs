using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;
using SafariPark.Hierarchy;

namespace SafariPark.Hierarchy.Animals
{
    public class Frog : KindofAnimal
    {
        public override Kind Kind => Kind.SomeFrog;

        public override Family Family => Family.Frogs;

        public override Detachment Detachment => Detachment.TaillessAmphibians;

        public override Classes Classes => Classes.Reptile;

        public override double Weigh => 1;

        public override double Growth => 1;

        public override string Name => "Crazy";

        public override Country HomeCountry => Country.Ukraine;

        public override DateTime DateArrival => DateTime.Now;

        public override int LifeTime => 10;

        public override int Age => 3;
    }
}
