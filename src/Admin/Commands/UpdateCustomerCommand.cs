using DDD.ApplicationLayer;
using Orion.Domain.DTOs;


namespace Orion.Admin.Commands
{
    public class UpdateCustomerCommand: ICommand
    {
        public UpdateCustomerCommand(ICustomerFullEditDto updates)
        {
            Updates = updates;
        }
        public ICustomerFullEditDto Updates { get; private set; }
    }
}
