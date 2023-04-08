using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class City
    {
        private string name;
        private string country;
        private int humanity;
        private int phonecode;
        private string[] district;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetCountry(string country)
        {
            this.country = country;
        }
        public string GetCountry()
        {
            return country;
        }
        public void SetHumanity(int humanity)
        {
            this.humanity = humanity;
        }
        public int GetHumanity()
        {
            return humanity;
        }
        public void SetPhonecode(int phonecode)
        {
            this.phonecode = phonecode;
        }
        public int GetPhonecode()
        {
            return phonecode;
        }
        public void SetDistrict(string[] district)
        {
            this.district = district;
        }
        public string[] GetDistrict()
        {
            return district;
        }

        public static City operator +(City city, int amount)
        {
            city.humanity += amount;
            return city;
        }

        public static City operator -(City city, int amount)
        {
            city.humanity -= amount;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            if (ReferenceEquals(city1, city2))
            {
                return true;
            }

            if ((object)city1 == null || (object)city2 == null)
            {
                return false;
            }

            return city1.humanity == city2.humanity;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.humanity < city2.humanity;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.humanity > city2.humanity;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            City city = obj as City;

            if ((object)city == null)
            {
                return false;
            }

            return humanity == city.humanity;
        }

        public void ShowHumanity()
        {
            Console.WriteLine($"\nPopulation: {humanity}");
        }

        public void Input()
        {
            Console.Write("Enter city name: ");
            name = Console.ReadLine();

            Console.Write("Enter country name: ");
            country = Console.ReadLine();

            Console.Write("Enter city population: ");
            humanity = int.Parse(Console.ReadLine());

            Console.Write("Enter phone code: ");
            phonecode = int.Parse(Console.ReadLine());

            Console.Write("Enter number of districts: ");
            int numDistrict = int.Parse(Console.ReadLine());

            district = new string[numDistrict];

            for (int i = 0; i < numDistrict; i++)
            {
                Console.Write($"Enter name of district {i + 1}: ");
                district[i] = Console.ReadLine();
            }
        }

        public void Show()
        {
            Console.WriteLine($"\nResult:\nCity: {name}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Population: {humanity}");
            Console.WriteLine($"Phone code: {phonecode}");
            Console.WriteLine("Districts: ");
            foreach (string district in district)
            {
                Console.WriteLine($"- {district}");
            }
        }
    }
}
