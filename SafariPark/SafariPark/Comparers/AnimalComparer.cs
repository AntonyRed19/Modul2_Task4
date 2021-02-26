using System.Collections;
using SafariPark.Hierarchy;

namespace SafariPark.Helpers
{
    public class AnimalComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as KindofAnimal;
            var y = second as KindofAnimal;

            if (x.Age > y.Age)
            {
                return 1;
            }
            else if (x.Age < y.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
