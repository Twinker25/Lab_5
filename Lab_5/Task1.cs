using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Employer
    {
        private string PIB;
        private string birth;
        private int telephone;
        private string email;
        private string position;
        private string[] responcible;
        private double salary;

        public void SetPIB(string PIB)
        {
            this.PIB = PIB;
        }
        public string GetPIB()
        {
            return PIB;
        }
        public void SetBirth(string birth)
        {
            this.birth = birth;
        }
        public string GetBirth()
        {
            return birth;
        }
        public void SetTelephone(int telephone)
        {
            this.telephone = telephone;
        }
        public int GetTelephone()
        {
            return telephone;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetPosition(string position)
        {
            this.position = position;
        }
        public string GetPosition()
        {
            return position;
        }
        public void SetResponcible(string[] responcible)
        {
            this.responcible = responcible;
        }
        public string[] GetResponcible()
        {
            return responcible;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }

        public static Employer operator +(Employer employee, double amount)
        {
            employee.salary += amount;
            return employee;
        }

        public static Employer operator -(Employer employee, double amount)
        {
            employee.salary -= amount;
            return employee;
        }

        public static bool operator ==(Employer employee1, Employer employee2)
        {
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            if ((object)employee1 == null || (object)employee2 == null)
            {
                return false;
            }

            return employee1.salary == employee2.salary;
        }

        public static bool operator !=(Employer employee1, Employer employee2)
        {
            return !(employee1 == employee2);
        }

        public static bool operator <(Employer employee1, Employer employee2)
        {
            return employee1.salary < employee2.salary;
        }

        public static bool operator >(Employer employee1, Employer employee2)
        {
            return employee1.salary > employee2.salary;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Employer employee = obj as Employer;

            if ((object)employee == null)
            {
                return false;
            }

            return salary == employee.salary;
        }

        public void ShowSalary()
        {
            Console.WriteLine($"\nSalary: {salary}");
        }

        public void Input()
        {
            Console.Write("Enter PIB: ");
            PIB = Console.ReadLine();

            Console.Write("Enter date of birth: ");
            birth = Console.ReadLine();

            Console.Write("Enter telephone number: ");
            telephone = int.Parse(Console.ReadLine());

            Console.Write("Enter email: ");
            email = Console.ReadLine();

            Console.Write("Enter position in company: ");
            position = Console.ReadLine();

            Console.Write("Enter number of responcibility: ");
            int numResponcible = int.Parse(Console.ReadLine());

            responcible = new string[numResponcible];

            for (int i = 0; i < numResponcible; i++)
            {
                Console.Write($"Enter name of responcibility {i + 1}: ");
                responcible[i] = Console.ReadLine();
            }
        }

        public void Show()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Date of birth: {birth}");
            Console.WriteLine($"Telephone number: {telephone}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine("Responcibles: ");
            foreach (string responcible in responcible)
            {
                Console.WriteLine($"- {responcible}");
            }
        }
    }
}
