using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MedCRM
{

    public class Client
    {
        private const int TotalWidth = 10;
        public ClientType Type{get; set;}

        private string? _name;
        private string? _edrpou;
        private double? _contractHours;
        private string? _ownerName;
        private string? _ownerPhone;
        private string? _ownerEmail;
        public string Name
        {
            get { return _name ?? ""; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Назва пуста");
                }

                if (value.Length < 5)
                {
                    throw new Exception("Назва містить менше 5 символів.");
                }

                if (!Char.IsLetter(value[0]))
                {
                    throw new Exception("Назва повинна починатися з букви.");
                }

                _name = value;
            }
        }

        public string EDRPOU
        {
            get { return _edrpou ?? ""; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ЄДПРОУ/ІПН не може бути пустим.");
                }

                if (value.Length < 10)
                {
                    throw new Exception("ЄДПРОУ/ІПН повинен бути не менше 10 символів");
                }

                _edrpou = value;
            }
        }

        public DateTime? RegistrationDate { get; }
        public double? ContractHours
        {
            get { return _contractHours!; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Кількість годин не може дорівнювати 0.");
                }

                if (value < 0)
                {
                    throw new Exception("Кількість годин повинна бути позитивним числом.");
                }

                if (value > 100)
                {
                    throw new Exception("Кількість годин не має перевищувати 100.");
                }

                _contractHours = value;
            }
        }
        public double Hours {get; private set; }
        public CompanySize Size { get; set; }

        public string OwnerName
        {
            get { return _ownerName ?? ""; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ПІБ власника не може бути пустим полем.");
                }

                if (value.Length < 5)
                {
                    throw new Exception("ПІБ власника містить менше 5 символів.");
                }

                if (!Char.IsLetter(value[0]))
                {
                    throw new Exception("ПІБ власника повинна починатися з букви.");
                }

                _ownerName = value;
            }
        }

        public string OwnerPhone
        {
            get { return _ownerPhone ?? ""; }
            set
            {
                string phonePattern = @"^\+380\(\d{2}\)-\d{3}-\d{2}-\d{2}$";

                if (!Regex.IsMatch(value, phonePattern))
                {
                    throw new Exception("Номер телефону повинен відповідати формату +380(11)-111-11-11.");
                }

                _ownerPhone = value;
            }
        }

        public string OwnerEmail
        {
            get { return _ownerEmail ?? ""; }
            set
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(value, emailPattern))
                {
                    throw new Exception("Недопустимий тип email.");
                }

                _ownerEmail = value;
            }
        }

        public string NameForList
        {
            get 
            { 
                return $"{Name}-{EDRPOU}"; 
            } 
        }

        private string _hiddenNote = "normal";

        public Client(ClientType type, string name, string edrpou, DateTime registrationDate, double contractHours, CompanySize size, 
            string ownerName, string ownerPhone, string ownerEmail, string hiddenNote)
        {
            this.Type = type;
            this.Name = name;
            this.EDRPOU = edrpou;
            this.RegistrationDate = registrationDate;
            this.ContractHours = contractHours;
            this.Hours = contractHours;
            this.Size = size;
            this.OwnerName = ownerName;
            this.OwnerPhone = ownerPhone;
            this.OwnerEmail = ownerEmail;

            this._hiddenNote = hiddenNote;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Name: {Name}, EDRPOU: {EDRPOU ?? "N/A"}, RegistrationDate: {RegistrationDate:dd.MM.yyyy}, " +
                   $"ContractHours: {ContractHours}, Size: {Size}, Owner: {OwnerName}, Phone: {OwnerPhone}, Email: {OwnerEmail}";
        }

        public List<string> ToDisplayValues()
        {
            List<String> result = new List<string>();

            result.Add(Type.ToString());
            result.Add(Name);
            result.Add(EDRPOU);
            result.Add(RegistrationDate.GetValueOrDefault(DateTime.MinValue).ToString("dd.MM.yyyy"));
            result.Add(ContractHours.GetValueOrDefault(0).ToString());
            result.Add(Size.ToString());
            result.Add(OwnerName);
            result.Add(OwnerPhone);
            result.Add(OwnerEmail);

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

        public void AddHours(double purchasedServiceHours)//купляємо години
        {
            this.Hours += purchasedServiceHours;
        }

        public void UseHours(double purchasedServiceHours)//користуємо години
        {
            this.Hours -= purchasedServiceHours;
        }

        public void RefreshContract()//зазвичай робиться на початку періоду, якщо поточних годин більше 0 тоді встановлюємо contractHours
            //якщо баланс годин негативний тоді просто додаємо contractHours
        {
            if (this.ContractHours > 0)
            {
                this.Hours = this.ContractHours.Value;
            }
            else
            {
                this.Hours += ContractHours.GetValueOrDefault(0);
            }
        }
        public void ShowHiddenNote()
        {
            Console.WriteLine($"Hidden note: {_hiddenNote}");
        }
    }
}
