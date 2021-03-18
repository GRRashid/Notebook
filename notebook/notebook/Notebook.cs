using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Xml.Serialization;
using Console = System.Console;

namespace notebook
{
    class Notebook
    {
        private string surname;
        private string name;
        private string lastName;
        private string phoneNumber;
        private string country;
        private string bornDate;
        private string organization;
        private string position;
        private string others;

        public Notebook(string surname, string name, string phoneNumber, 
            string country)
        {
            while (surname == "")
            {
                Console.WriteLine("От меня не скроешься! Фамилия обязательное поле!!!!");
                surname = Console.ReadLine();
            }
            while (name == "")
            {
                Console.WriteLine("От меня не скроешься! Имя обязательное поле!!!!");
                name = Console.ReadLine();
            }
            while (country == "")
            {
                Console.WriteLine("От меня не скроешься! Страна обязательное поле!!!!");
                country = Console.ReadLine();
            }


            while (!Regex.IsMatch("[0-9]",phoneNumber) && phoneNumber.Length != 11)
            {
                Console.WriteLine("Мне нужен твой номер, состоящий из 11 цифр!");
                phoneNumber = Console.ReadLine();
            }

            this.surname = surname;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.country = country;
        }

        public string GetName()
        {
            return this.name;
        }
        public string GetSurName()
        {
            return this.surname;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public string GetCountry()
        {
            return this.country;
        }
        public string GetDate()
        {
            return this.bornDate;
        }
        public string GetOrg()
        {
            return this.organization;
        }
        public string GetPosition()
        {
            return this.position;
        }
        public string GetOther()
        {
            return this.others;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurName(string surname)
        {
            this.surname = surname;
        }
        public void SetNumber(string number)
        {
            this.phoneNumber = number;
        }
        public void SetCountry(string country)
        {
            this.country = country;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void SetDate(string date)
        {
            this.bornDate = date;
        }
        public void SetOrganization(string organization)
        {
            this.organization = organization;
        }
        public void SetPosition(string position)
        {
            this.position = position;
        }public void SetOthers(string others)
        {
            this.others = others;
        }
        
    }
}
