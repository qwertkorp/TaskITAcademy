using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateBranchExchange
{
    internal class TariffPlan : BillingSystem
    {
        private int tariffLight = 5;
        private int tariffMedium = 10;
        private int tariffMax = 20;
        public int TariffLight { get { return tariffLight; } }
        public int TariffMedium { get { return tariffMedium; } }
        public int TariffMax { get { return tariffMax; } }

    }
}
