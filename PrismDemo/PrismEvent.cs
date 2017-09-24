using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace PrismDemo
{
    public class OpenFormEvent :PubSubEvent
    {
    }
    public class CloseFormEvent : PubSubEvent
    {
    }
    public class SynchronizeABEvent : PubSubEvent
    {
    }
    public class ReloadFormEvent : PubSubEvent
    {
    }
}
