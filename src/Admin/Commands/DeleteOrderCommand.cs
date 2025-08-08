using DDD.ApplicationLayer;

namespace Orion.Admin.Commands
{
    public class DeleteOrderCommand: ICommand
    {
        public DeleteOrderCommand(int id)
        {
            OrderId = id;
        }
        public int OrderId { get; private set; }
    }
}
