using Orion.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IProductRepository: IRepository<IProduct>
    {
        Task<IProduct> Get(int id);
        IProduct New();
        Task<IProduct> Delete(int id);
    }
}
