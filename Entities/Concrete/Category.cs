using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class kalmasın implementasyon inheritance alması lazım
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
