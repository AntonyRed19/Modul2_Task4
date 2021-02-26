using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;
using SafariPark.Hierarchy;
namespace SafariPark.Hierarchy.Animals
{
    public class Lion : KindofAnimal
    {
        public Lion()
        {
        }

        public override Kind Kind => Kind.African;
        public override Family Family => Family.Cats;
        public override Detachment Detachment => Detachment.Predatory;
        public override Classes Classes => Classes.Mammals;
        public override double Weigh => 350.55;
        public override double Growth => 1.5;
        public override string Name => "Alex";
        public override Country HomeCountry => Country.Botswana;
        public override DateTime DateArrival => DateTime.Now;
        public override int LifeTime => 10;
        public override int Age => 7;
    }
}
