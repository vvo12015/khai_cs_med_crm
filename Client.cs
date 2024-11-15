using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MedCRM
{

    public class Client
    {
        private const int TotalWidth = 10;
        private const int TypeIndex = 0;
        private const int NameIndex = 1;
        private const int EDPROU_Index = 2;
        private const int Date_Index = 3;
        private const int ContactHours_Index = 4;
        private const int Hours_Index = 5;
        private const int Size_Index = 6;
        private const int OwnerName_Index = 7;
        private const int OwnerPhone_Index = 8;
        private const int OwnerEmail_Index = 9;


        public ClientType Type{get; set;}

        private string? _name;
        private string? _edrpou;
        private double? _contractHours;
        private string? _ownerName;
        private string? _ownerPhone;
        private string? _ownerEmail;

        private static int _conter;
        public static double MinHours { get; set; } = -50.0;

        public static int Counter {  get
            {
                return _conter;
            }
        }

        public static void AddObject()
        {
            _conter++;
        }

        public static void RemoveObject()
        {

            _conter--;
        }

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

        public DateTime? RegistrationDate { get; set; }
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

        public Client()
        {
            AddObject();
        }

        public Client(ClientType type, string? name, string? edrpou, DateTime registrationDate, double contractHours, CompanySize size, string hiddenNote):this()
        {
            Type = type;
            Name = name!;
            EDRPOU = edrpou!;
            this.RegistrationDate = registrationDate;
            this.ContractHours = contractHours;
            this.Hours = contractHours;
            this.Size = size;
            this._hiddenNote = hiddenNote;
            this._ownerEmail = "";
            this._ownerPhone = "";
            this._ownerName = "";
        }

        public Client(ClientType type, string name, string edrpou, DateTime registrationDate, double contractHours, CompanySize size, 
            string ownerName, string ownerPhone, string ownerEmail, string hiddenNote):this(type, name, edrpou, registrationDate, contractHours, size, hiddenNote) { 
            this.OwnerName = ownerName;
            this.OwnerPhone = ownerPhone;
            this.OwnerEmail = ownerEmail;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Name: {Name}, EDRPOU: {EDRPOU ?? "N/A"}, RegistrationDate: {RegistrationDate:dd.MM.yyyy}, " +
                   $"ContractHours: {ContractHours}, Hours: {Hours}, Size: {Size}, OwnerName: {OwnerName}, Phone: {OwnerPhone}, Email: {OwnerEmail}";
        }

        public static Client Parse(string s)
        {

            if (s.Split(',').Length != Client.ToDisplayNames().Count)
            {
                throw new Exception("Не вірний формат рядка");
            }

            string[] fields = s.Split(",");

            ClientType clientType;

            if (!Enum.TryParse(fields[TypeIndex].Substring(fields[TypeIndex].IndexOf(':'), fields[TypeIndex].Length), out clientType)){
                throw new Exception("Неіснуючий тип клієнта");
            }

            string name = fields[NameIndex].Substring(fields[NameIndex].IndexOf(':'), fields[NameIndex].Length);
            string EDRPOU = fields[EDPROU_Index].Substring(fields[EDPROU_Index].IndexOf(':'), fields[EDPROU_Index].Length);

            DateTime registerDate;

            if (!DateTime.TryParse(fields[Date_Index].Substring(fields[Date_Index].IndexOf(':'), fields[Date_Index].Length), out registerDate))
            {
                throw new Exception("Неіснуючий тип клієнта");
            }

            double countractHours;

            if (!double.TryParse(fields[ContactHours_Index].Substring(fields[ContactHours_Index].IndexOf(':'), fields[ContactHours_Index].Length), out countractHours))
            {
                throw new Exception("Неіснуючий тип клієнта");
            }

            double hours;

            if (!double.TryParse(fields[Hours_Index].Substring(fields[Hours_Index].IndexOf(':'), fields[Hours_Index].Length), out hours))
            {
                throw new Exception("Неіснуючий тип клієнта");
            }

            CompanySize size;

            if (!Enum.TryParse(fields[Size_Index].Substring(fields[Size_Index].IndexOf(':'), fields[Size_Index].Length), out size))
            {
                throw new Exception("Неіснуючий тип клієнта");
            }

            string ownerName = fields[OwnerName_Index].Substring(fields[OwnerName_Index].IndexOf(':'), fields[OwnerName_Index].Length);
            string ownerPhone = fields[OwnerPhone_Index].Substring(fields[OwnerPhone_Index].IndexOf(':'), fields[OwnerPhone_Index].Length);
            string ownerEmail = fields[OwnerEmail_Index].Substring(fields[OwnerEmail_Index].IndexOf(':'), fields[OwnerEmail_Index].Length);

            Client client = new Client()
            {
                Type = clientType,
                Name = name,
                EDRPOU = EDRPOU,
                RegistrationDate = registerDate,
                ContractHours = countractHours,
                Hours = hours,
                Size = size,
                OwnerName = ownerName,
                OwnerPhone = ownerPhone,
                OwnerEmail = ownerEmail
            };

            return client;
        }

        public static bool TryParse(string s, out Client client)
        {
            try
            {
                client = Client.Parse(s);
            }
            catch
            {
                client = null;
                return false;
            }
            return true;
        }

        public List<string> ToDisplayValues()
        {
            List<String> result = new List<string>();

            result.Add(Type.ToString());
            result.Add(Name);
            result.Add(EDRPOU);
            result.Add(RegistrationDate.GetValueOrDefault(DateTime.MinValue).ToString("dd.MM.yyyy"));
            result.Add(ContractHours.GetValueOrDefault(0).ToString());
            result.Add(Hours.ToString());
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
            result.Add("Кількість год по договору");
            result.Add("Кількість залишок год");
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

        public void RefreshContract()//зазвичай робиться на початку періоду, якщо поточних годин більше 0 тоді hours присвоюємо contractHours
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

        public void RefreshContract(double newContractHours)//зазвичай робиться на початку періоду, встановлюємо нові contractHours, якщо поточних годин більше 0 тоді встановлюємо contractHours
                                     //якщо баланс годин негативний тоді просто додаємо contractHours
        {
            this.ContractHours = newContractHours;

            RefreshContract();
        }

        public void ShowHiddenNote()
        {
            Console.WriteLine($"Hidden note: {_hiddenNote}");
        }
    }
}
