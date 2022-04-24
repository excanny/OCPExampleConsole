using System;
using System.Collections.Generic;
using System.Text;

namespace OCPExampleConsole
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
