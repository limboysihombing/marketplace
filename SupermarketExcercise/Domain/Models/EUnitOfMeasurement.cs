using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketExcercise.Domain.Models
{
    public enum EUnitOfMeasurement :byte
    {
        [Description("UN")]
        Unity = 1,

        [Description("MG")]
        Milligram=2,

        [Description("G")]
        Gram = 3,

        [Description("KG")]
        Kilogram = 4,

        [Description("MG")]
        Liter = 5
    }
}
