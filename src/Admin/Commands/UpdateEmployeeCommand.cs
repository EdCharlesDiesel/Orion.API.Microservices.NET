using DDD.ApplicationLayer;
using Orion.Domain.DTOs;

namespace Orion.Admin.Commands
{
    public class UpdateEmployeeCommand: ICommand
    {
        public UpdateEmployeeCommand(IEmployeeFullEditDto updates)
        {
            Updates = updates;
        }
        public IEmployeeFullEditDto Updates { get; private set; }
    }
}
