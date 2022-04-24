using System;
using System.Collections.Generic;
using System.Text;

namespace OCPExampleConsole
{
    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _type;

        public MonitorTypeSpecification(MonitorType type)
        {
            _type = type;
        }

        public bool IsSatisfied(ComputerMonitor item) => item.Type == _type;
    }
}
