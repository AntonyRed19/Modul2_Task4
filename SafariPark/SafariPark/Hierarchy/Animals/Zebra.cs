using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;
using SafariPark.Hierarchy;

namespace SafariPark.Hierarchy.Animals
{
    public class Zebra : KindofAnimal
    {
        public override Kind Kind => Kind.SomeZebra;

        public override Family Family => Family.Hourses;

        public override Detachment Detachment => Detachment.Herbivores;

        public override Classes Classes => Classes.Mammals;

        public override double Weigh => 150.55;

        public override double Growth => 2.1;

        public override string Name => "Marty";

        public override Country HomeCountry => Country.SouthAfrica;

        public override DateTime DateArrival => DateTime.Now;

        public override int LifeTime => 25;

        public override int Age => 13;
    }
}
