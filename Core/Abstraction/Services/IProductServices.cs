using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction.Services
{
    public interface IProductServices
    {
        public void InsertProducts(Proizvod product);
    }
}
