using DDD.ApplicationLayer;
using Orion.Domain.DTOs;

namespace Orion.Admin.Commands
{
    public class CreateProductCommand: ICommand
    {
        public CreateProductCommand(IProductFullEditDto values)
        {
            Values = values;
        }
        public IProductFullEditDto Values { get; private set; }
    }
}
