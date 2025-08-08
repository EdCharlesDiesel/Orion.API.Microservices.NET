using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Domain.Utility
{
    public interface IValidatorStrategy<T>
    {
        bool IsValid(T validateThis);
    }
}
