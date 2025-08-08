using DDD.ApplicationLayer;
using Orion.Domain.DTOs;

namespace Orion.Admin.Commands
{
    public class CreateCustomerCommand: ICommand
    {
        public CreateCustomerCommand(ICustomerFullEditDto values)
        {
            Values = values;
        }
        public ICustomerFullEditDto Values { get; private set; }
    }
}
