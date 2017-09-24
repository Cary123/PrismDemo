using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo
{
    class MainABAgent
    {
        public static void SubscribeEvent()
        {
            AggregatorFactory.GetAggregrator().GetEvent<OpenABScreenEvent>().Subscribe(OpenABScreen);
            AggregatorFactory.GetAggregrator().GetEvent<CloseABFormEvent>().Subscribe(CloseWindow);
            AggregatorFactory.GetAggregrator().GetEvent<SynchronizeABEvent>().Subscribe(SyncAB);
            AggregatorFactory.GetAggregrator().GetEvent<SynchronizeABEvent>().Subscribe(SyncAB1);
        }

        public static void OpenABScreen()
        {
            Console.WriteLine();
        }

        public static void CloseWindow()
        {
            Console.WriteLine();
        }

        public static void SyncAB()
        {
            Console.WriteLine();
        }

        public static void SyncAB1()
        {
            Console.WriteLine();
        }
    }
   
}
