using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateBranchExchange
{
    internal class UserReport:BillingSystem
    {
        public List<CallDataForReport> report = new List<CallDataForReport>();
        private void Report(string callingClient, string receivingClient, DateTime dateTime, DateTime callDuration, double callCost)
        {
            CallDataForReport data = new CallDataForReport(callingClient,receivingClient,dateTime,callDuration,callCost);
            string path = @$"Reports\{callingClient}_Report.txt";            
            report.Add(data);
            string str = $"{dateTime},{callingClient},{receivingClient},{callDuration},{callCost}";
            using (var sw = new StreamWriter(path, true))
            {            
                    sw.WriteLine(str);                
            }

        }
    }
}
