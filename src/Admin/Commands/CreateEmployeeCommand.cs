using DDD.ApplicationLayer;
using Orion.Domain.DTOs;

namespace Orion.Admin.Commands
{
    public class CreateEmployeeCommand: ICommand
    {
        public CreateEmployeeCommand(IEmployeeFullEditDto values)
        {
            Values = values;
        }
        public IEmployeeFullEditDto Values { get; private set; }
    }
}
