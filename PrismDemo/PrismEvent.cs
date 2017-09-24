using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace PrismDemo
{
    public class OpenABScreenEvent :PubSubEvent
    {
    }

    public class CloseABFormEvent : PubSubEvent
    {

    }

    public class SynchronizeABEvent : PubSubEvent
    {

    }

    public class OpenMainScreenEvent : PubSubEvent
    {

    }

    public class CloseMainFormEvent : PubSubEvent
    {

    }

    public class SynchronizeMainEvent : PubSubEvent
    {
    }


    
}
