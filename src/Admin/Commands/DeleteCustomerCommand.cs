using DDD.ApplicationLayer;

namespace Orion.Admin.Commands
{
    public class DeleteCustomerCommand: ICommand
    {
        public DeleteCustomerCommand(int id)
        {
            CustomerId = id;
        }
        public int CustomerId { get; private set; }
    }
}
