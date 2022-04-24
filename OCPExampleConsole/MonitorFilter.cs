using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPExampleConsole
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        //public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type) =>
        //        monitors.Where(m => m.Type == type).ToList();

        //public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors, Screen screen) =>
        //monitors.Where(m => m.Screen == screen).ToList();
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(m => specification.IsSatisfied(m)).ToList();
        }
    }
}
