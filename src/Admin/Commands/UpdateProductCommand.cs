using DDD.ApplicationLayer;
using Orion.Domain.DTOs;

namespace Orion.Admin.Commands
{
    public class UpdateProductCommand: ICommand
    {
        public UpdateProductCommand(IProductFullEditDto updates)
        {
            Updates = updates;
        }
        public IProductFullEditDto Updates { get; private set; }
    }
}
