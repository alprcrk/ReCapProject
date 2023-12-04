using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        // Id, BrandId, ColorId, ModelYear, DailyPrice, Description 
        public int Id { get; set; } // PK

        public int BrandId { get; set; } // FK
        public Brand CarBrand { get; set; } // Navigation property

        public int ColorId { get; set; } // FK
        public Color CarColor { get; set; } // Navigation property

        public DateTime ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }


    }
}
