using DDD.ApplicationLayer;
using Orion.Domain.DTOs;

namespace Orion.Admin.Commands
{
    public class UpdateOrderCommand: ICommand
    {
        public UpdateOrderCommand(IOrderFullEditDto updates)
        {
            Updates = updates;
        }
        public IOrderFullEditDto Updates { get; private set; }
    }
}
