using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo
{
    class ABAgent
    {
        public static void SubscribeEvent()
        {
            AggregatorFactory.GetAggregrator().GetEvent<OpenMainScreenEvent>().Subscribe(OpenABScreen);
            AggregatorFactory.GetAggregrator().GetEvent<CloseMainFormEvent>().Subscribe(CloseWindow);
            AggregatorFactory.GetAggregrator().GetEvent<SynchronizeMainEvent>().Subscribe(SyncAB);
        }

        public static void OpenABScreen()
        {
            AggregatorFactory.GetAggregrator().GetEvent<OpenABScreenEvent>().Publish();
        }

        public static void CloseWindow()
        {
            AggregatorFactory.GetAggregrator().GetEvent<CloseABFormEvent>().Publish();
        }

        public static void SyncAB()
        {
            AggregatorFactory.GetAggregrator().GetEvent<SynchronizeABEvent>().Publish();
        }
    }
}
