using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism;
using Prism.Events;

namespace PrismDemo
{
    public class HanderRequest
    {
        public static IEventAggregator Aggregator;

        public const string SynchronizeAB = "SynchronizeAB";

        public ABForm abForm;

        public static void CloseForm()
        {

        }

    }
}
