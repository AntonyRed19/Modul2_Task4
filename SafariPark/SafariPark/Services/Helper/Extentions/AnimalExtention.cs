using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy;
using SafariPark.Hierarchy.Enums;
using SafariPark.Services.Helper;

namespace SafariPark.Services
{
    public static class AnimalExtention
    {
        public static KindofAnimal[] FindAnimal(this Section section, int age)
        {
            var temp = new KindofAnimal[section.KindofAnimals.Length];

            for (var i = 0; i < temp.Length; i++)
            {
                var item = section.KindofAnimals[i];
                if (item.Age > age)
                {
                    temp[i] = section.KindofAnimals[i];
                }
            }

            var tempResult = ArrayHelper.CleanCapacity(temp);
            var result = new KindofAnimal[tempResult.Length];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = tempResult[i] as KindofAnimal;
            }

            return result;
        }
    }
}
