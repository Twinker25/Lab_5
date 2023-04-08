using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Write("Enter number of task (1 - 4): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                { 
                case 1:
                        Employer employer1 = new Employer();
                        Employer employer2 = new Employer();
                        employer1.Input();
                        Console.WriteLine();
                        employer2.Input();
                        Console.WriteLine("\nShow info:");
                        employer1.Show();
                        Console.WriteLine();
                        employer2.Show();
                        Console.WriteLine();
                        employer1 += 100;
                        employer2 += 100;
                        Console.Write("\nSalary of employer 1: ");
                        employer1.ShowSalary();
                        Console.Write("\nSalary of employer 2: ");
                        employer2.ShowSalary();
                        employer1 -= 50;
                        employer2 -= 25;
                        Console.Write("\nSalary of employer 1: ");
                        employer1.ShowSalary();
                        Console.Write("\nSalary of employer 2: ");
                        employer2.ShowSalary();
                        Console.WriteLine();

                        if (employer1 == employer2)
                        {
                            Console.WriteLine("\nEmployees have equal salary.");
                        }

                        if (employer1 > employer2)
                        {
                            Console.WriteLine("\nEmployee 1 has higher salary than Employee 2.");
                        }

                        else if (employer1 < employer2)
                        {
                            Console.WriteLine("\nEmployee 2 has higher salary than Employee 1.");
                        }

                        if (employer1 != employer2)
                        {
                            Console.WriteLine("\nEmployees have different salary.");
                        }
                    
                        if (employer1.Equals(employer2))
                        {
                            Console.WriteLine("\nEmployees are the same person.");
                        }
                        break;
                case 2:
                        Matrix matrix1 = new Matrix(2, 2);
                        Matrix matrix2 = new Matrix(2, 2);
                        matrix1.GenMatrix();
                        matrix2.GenMatrix();
                        Console.WriteLine("Matrix 1: ");
                        matrix1.Show();
                        Console.WriteLine("\nMatrix 2: ");
                        matrix2.Show();
                        Console.WriteLine("\nSum of matrix: ");
                        Matrix sum = matrix1 + matrix2;
                        sum.Show();
                        Console.WriteLine("\nSub of matrix: ");
                        Matrix sub = matrix1 - matrix2;
                        sub.Show();
                        Console.WriteLine("\nMult of matrix: ");
                        Matrix mult = matrix1 * matrix2;
                        mult.Show();
                        Console.WriteLine("\nMult matrix 1 on number: ");
                        Console.Write("Enter number: ");
                        int num = int.Parse(Console.ReadLine());
                        Matrix mult1 = matrix1 * num;
                        mult1.Show();

                        if(matrix1 == matrix2)
                        {
                            Console.WriteLine("\nMatrix are similar!");
                        }

                        if (matrix1 != matrix2)
                        {
                            Console.WriteLine("\nMatrix aren`t similar!");
                        }

                        if (matrix1.Equals(matrix2))
                        {
                            Console.WriteLine("\nMatrix are equal similar!");
                        }
                        break;
                case 3:
                        City city1 = new City();
                        City city2 = new City();
                        city1.Input();
                        Console.WriteLine();
                        city2.Input();
                        Console.WriteLine("\nShow info:");
                        city1.Show();
                        Console.WriteLine();
                        city2.Show();
                        Console.WriteLine();
                        Console.Write("\nPopulation of city 1: ");
                        city1.ShowHumanity();
                        Console.Write("\nPopulation of city 2: ");
                        city2.ShowHumanity();
                        Console.Write("\nPopulation of city 1: ");
                        city1.ShowHumanity();
                        Console.Write("\nPopulation of city 2: ");
                        city2.ShowHumanity();
                        Console.WriteLine();

                        if (city1 == city2)
                        {
                            Console.WriteLine("\nCity have equal population.");
                        }

                        if (city1 > city2)
                        {
                            Console.WriteLine("\nCity 1 has higher population than City 2.");
                        }

                        else if (city1 < city2)
                        {
                            Console.WriteLine("\nCity 2 has higher population than City 1.");
                        }

                        if (city1 != city2)
                        {
                            Console.WriteLine("\nCities have different population.");
                        }

                        if (city1.Equals(city2))
                        {
                            Console.WriteLine("\nCities are the equals.");
                        }
                        break;
                case 4:

                        break;
                default:
                        Console.WriteLine("Error! Try again!");
                        break;
                }
            } while (choice < 1 || choice > 4);
        }
    }
}