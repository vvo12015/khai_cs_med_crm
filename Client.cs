using System;

namespace MedCRM
{

    public class Client
    {

        public ClientType type;
        public string name;
        public string edrpou;
        public DateTime registrationDate;
        public double contractHours;
        public double hourPrice;
        public double sum;
        public CompanySize size;

        public string ownerName;
        public string ownerPhone;
        public string ownerEmail;

        private string hiddenNote;
        private List<string> services = new List<string>();

        public Client(ClientType type, string name, string edrpou, DateTime registrationDate, double contractHours, CompanySize size, 
            string ownerName, string ownerPhone, string ownerEmail, string hiddenNote)
        {
            this.type = type;
            this.name = name;
            this.edrpou = edrpou;
            this.registrationDate = registrationDate;
            this.contractHours = contractHours;
            this.size = size;
            this.ownerName = ownerName;
            this.ownerPhone = ownerPhone;
            this.ownerEmail = ownerEmail;

            this.hiddenNote = hiddenNote;
        }

        public void ProvideService(string service, double hours)
        {
            if (hours <= contractHours)
            {
                contractHours -= hours;
                services.Add(service);
                Console.WriteLine($"При наданні послуги {service}, було використано {hours} сервісних годин. Залишок годин {contractHours} ");
            }
            else
            {
                Console.WriteLine("Не достатньо сервісних годин");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Type: {type}, Name: {name}, EDRPOU: {edrpou ?? "N/A"}, RegistrationDate: {registrationDate:dd.MM.yyyy}, " +
                              $"ContractHours: {contractHours}, Size: {size}, Owner: {ownerName}, Phone: {ownerPhone}, Email: {ownerEmail}");
        }

        public void ShowServices()
        {
            Console.WriteLine($"Послуги, які виконалися у клієнта {name}");
            for (int i = 0; i < services.Count; i++)
            {
                Console.WriteLine(services[i]);
            }
        }

        public void AddContractHours(double contractHoursToAdd)
        {
            this.contractHours += contractHoursToAdd;
        }

        public void AddSum(double sumToAdd)
        {
            this.sum += sumToAdd;
        }

        public void buyHours(double purchasedServiceHours)
        {
            this.contractHours += purchasedServiceHours;
            this.sum += (purchasedServiceHours * hourPrice);
        }

        public void ShowHiddenNote()
        {
            Console.WriteLine($"Hidden note: {hiddenNote}");
        }
    }
}
