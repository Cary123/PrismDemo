using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism;


namespace PrismDemo
{
    public class AggregatorFactory
    {
        private static IEventAggregator aggregator;
        public static IEventAggregator GetAggregrator()
        {
            if (aggregator == null)
            {
                aggregator = new EventAggregator();
            }
            return aggregator;
        }
    }
}
