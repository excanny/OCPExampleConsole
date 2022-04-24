using System;
using System.Collections.Generic;
using System.Text;

namespace OCPExampleConsole
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
