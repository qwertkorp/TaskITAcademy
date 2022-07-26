using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateBranchExchange
{
    internal class Operator
    {
        public string ClientName { get; set; }
        public PortStatus Port;
        public int PhoneNumber;
        public List<Client> clients = new List<Client>();
        public void RunOperator()
        {
            

        }
        public void AddClient()
        {
            TariffPlan plan = new TariffPlan();

            clients.Add(new Client()
            {
                name = "Bob_Chief",
                phoneNamber = 1,
                port = PortStatus.Off,
                tariff = plan.TariffMax,
                isBusy = true

            });
            clients.Add(new Client()
            {
                name = "Liza_PR",
                phoneNamber = 2,
                port = PortStatus.On,
                tariff = plan.TariffMedium,
                isBusy = false

            });
            clients.Add(new Client()
            {
                name = "Oliver_Developer",
                phoneNamber = 3,
                port = PortStatus.On,
                tariff = plan.TariffMedium,
                isBusy = true

            });
            UserInput userInput = new UserInput();

            clients.Add(new Client()
            {
                name = userInput.InputName(),
                phoneNamber = 4,
                port = PortStatus.On,
                tariff = userInput.InputTariff(),
                isBusy = true
                
            });
            Console.WriteLine($"\nname={clients[3].name},phoneNamber={clients[3].phoneNamber},port={clients[3].port},tariff={clients[3].tariff},isBusy={clients[3].isBusy}");
        }
        
    }
    
}
