using DenizKabacelik.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos
{
     public class ProductUpdateDto:IDto
    {

        public int Id { get; set; }
        public string  Name { get; set; }
    }
}
