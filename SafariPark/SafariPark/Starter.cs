using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Helpers;
using SafariPark.Services;
using SafariPark.Services.Abstractions;
using SafariPark.Hierarchy;

namespace SafariPark
{
    public class Starter
    {
        private readonly ISafaryServices _safariService;

        public Starter()
        {
            _safariService = new SafariServices();
        }

        public void Run()
        {
            Animal();
        }

        private void Animal()
        {
            var animal = _safariService.MakeSection();
            Array.Sort(animal.KindofAnimals, new AnimalComparer());

            for (int i = 0; i < animal.KindofAnimals.Length; i++)
            {
                Console.WriteLine($"Name: {animal.KindofAnimals[i].Name} Kind: {animal.KindofAnimals[i].Kind} Age: {animal.KindofAnimals[i].Age} Weight: {animal.KindofAnimals[i].Weigh} Growth: {animal.KindofAnimals[i].Growth} LifeTime: {animal.KindofAnimals[i].LifeTime} DateArrival: {animal.KindofAnimals[i].DateArrival} HomeCountry: {animal.KindofAnimals[i].HomeCountry}");
            }

            Console.WriteLine($"Count of Animals: {animal.Count}");

            var animals = animal.FindAnimal(10);

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"Name: {animals[i].Name} Kind: {animals[i].Kind} Age: {animals[i].Age}");
            }
        }
    }
}
