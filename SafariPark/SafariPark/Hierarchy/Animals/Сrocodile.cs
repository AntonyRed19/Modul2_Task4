using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;
using SafariPark.Hierarchy;

namespace SafariPark.Hierarchy.Animals
{
    public class Сrocodile : KindofAnimal
    {
        public override Kind Kind => Kind.SomeCrocodile;

        public override Family Family => Family.RealCrocodile;

        public override Detachment Detachment => Detachment.Crocodile;

        public override Classes Classes => Classes.Reptile;

        public override double Weigh => 1000;

        public override double Growth => 4;

        public override string Name => "Gena";

        public override Country HomeCountry => Country.Egypt;

        public override DateTime DateArrival => DateTime.Now;

        public override int LifeTime => 80;

        public override int Age => 45;
    }
}
