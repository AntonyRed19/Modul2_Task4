using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;
using SafariPark.Hierarchy;
using SafariPark.Services.Abstractions;
using SafariPark.Hierarchy.Animals;

namespace SafariPark.Services
{
    public class SafariServices : ISafaryServices
    {
        public SafariServices()
        {
        }

        public Section MakeSection()
        {
            var animals = new KindofAnimal[]
            {
                new Lion(),
                new Zebra(),
                new Frog(),
                new Сrocodile(),
                new Eagle()
            };

            var count = animals.Length;
            return new Section { KindofAnimals = animals, Count = count };
        }
    }
}
