using System;
using System.Collections.Generic;
using System.Text;

namespace MedCRM
{

    public class Client
    {
        private const int TotalWidth = 10;
        public ClientType type;
        public string name;
        public string edrpou;
        public DateTime registrationDate;
        public double contractHours;
        public double hours;
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
            this.hours = contractHours;
            this.size = size;
            this.ownerName = ownerName;
            this.ownerPhone = ownerPhone;
            this.ownerEmail = ownerEmail;

            this.hiddenNote = hiddenNote;
        }

        public override string ToString()
        {
            return $"Type: {type}, Name: {name}, EDRPOU: {edrpou ?? "N/A"}, RegistrationDate: {registrationDate:dd.MM.yyyy}, " +
                   $"ContractHours: {contractHours}, Size: {size}, Owner: {ownerName}, Phone: {ownerPhone}, Email: {ownerEmail}";
        }

        public List<string> ToDisplayValues()
        {
            List<String> result = new List<string>();

            result.Add(type.ToString());
            result.Add(name);
            result.Add(edrpou);
            result.Add(registrationDate.ToString("dd.MM.yyyy"));
            result.Add(contractHours.ToString());
            result.Add(size.ToString());
            result.Add(ownerName);
            result.Add(ownerPhone.ToString());
            result.Add(ownerEmail.ToString());

            return result;
        }

        public static List<string> ToDisplayNames()
        {
            List<String> result = new List<string>();

            result.Add("Тип клієнта");
            result.Add("Назва");
            result.Add("ЄДРПОУ/ІПН");
            result.Add("Дата реєстр.");
            result.Add("Кількість год");
            result.Add("Розмір компанії");
            result.Add("ПІБ власн.");
            result.Add("Телефон власн.");
            result.Add("Email власн.");

            return result;

        }

        public void SetContractHours(double contractHours)//встановлюємо кількість сервісних годин в договорі
        {
            this.contractHours = contractHours;
        }

        public void BuyHours(double purchasedServiceHours)//купляємо години
        {
            this.hours += purchasedServiceHours;
        }

        public void UseHours(double purchasedServiceHours)//користуємо години
        {
            this.hours -= purchasedServiceHours;
        }

        public void RefreshContract()//зазвичай робиться на початку періоду, якщо поточних годин більше 0 тоді встановлюємо contractHours
            //якщо баланс годин негативний тоді просто додаємо contractHours
        {
            if (this.contractHours > 0)
            {
                this.hours = this.contractHours;
            }
            else
            {
                this.hours += contractHours;
            }
        }
        public void ShowHiddenNote()
        {
            Console.WriteLine($"Hidden note: {hiddenNote}");
        }
    }
}
