using DDD.ApplicationLayer;
using Orion.Domain.DTOs;

namespace Orion.Admin.Commands
{
    public class CreateOrderCommand: ICommand
    {
        public CreateOrderCommand(IOrderFullEditDto values)
        {
            Values = values;
        }
        public IOrderFullEditDto Values { get; private set; }
    }
}
