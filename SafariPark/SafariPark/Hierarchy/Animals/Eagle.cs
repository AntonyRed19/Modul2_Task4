using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;
using SafariPark.Hierarchy;

namespace SafariPark.Hierarchy.Animals
{
    public class Eagle : KindofAnimal
    {
        public override Kind Kind => Kind.SomeEagle;

        public override Family Family => Family.Hawk;

        public override Detachment Detachment => Detachment.Predatory;

        public override Classes Classes => Classes.Bird;

        public override double Weigh => 30;

        public override double Growth => 35;

        public override string Name => "Yastreb";

        public override Country HomeCountry => Country.USA;

        public override DateTime DateArrival => DateTime.Now;

        public override int LifeTime => 15;

        public override int Age => 5;
    }
}
