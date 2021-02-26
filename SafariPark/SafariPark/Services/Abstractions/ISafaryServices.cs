using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;
using SafariPark.Hierarchy;

namespace SafariPark.Services.Abstractions
{
    public interface ISafaryServices
    {
        Section MakeSection();
    }
}
