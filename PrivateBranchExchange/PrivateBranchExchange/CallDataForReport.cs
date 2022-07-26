using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateBranchExchange
{
    internal class CallDataForReport
    {
        public string CallingClient { get; set; }
        public string ReceivingClient { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime CallDuration { get; set; }
        public double CallCost { get; set; }
        public CallDataForReport(string callingClient, string receivingClient, DateTime dateTime, DateTime callDuration, double callCost)
        {
            CallingClient = callingClient;
            ReceivingClient = receivingClient;
            DateTime = dateTime;
            CallDuration = callDuration;
            CallCost = callCost;
        }
    }
}
