using DenizKabacelik.JwtProje.Bussiness.Interfaces;
using DenizKabacelik.JwtProje.DataAccess.Interfaces;
using DenizKabacelik.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Bussiness.Concrete
{
   public  class ProductManager:GenericManager<Product>,IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IGenericDal<Product> genericDal,
             IProductDal productDal) :base(genericDal)
        {
            _productDal = productDal;

        }
    }
}
