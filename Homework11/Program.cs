using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation linearEquation = new Equation();
            try
            {
                Console.WriteLine("Программа находит значение переменной линейного уравнения вида 0=kx+b ");

                Console.WriteLine("Введите значение коэффициента k = ");
                linearEquation.CoefficientK = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение коэффициента b = ");
                linearEquation.CoefficientB = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат.");
                Console.ReadKey();
                return;
            }
            linearEquation.GetRoot(); //Читал, что имена методов должны начинаться с глагола, поэтому назвал GetRoot. Поправьте, если заблуждаюсь.
        }
    }
    struct Equation
    {
        double coefficientK;
        public double CoefficientB { get; set; }

        public double CoefficientK
        {
            set
            {
                if (value != 0)
                {
                    coefficientK = value;
                }
                else
                {
                    Console.WriteLine("Коэффициент k не может быть равен 0");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            get
            {
                return coefficientK;
            }
        }
        public Equation(double CoefficientB, double CoefficientK)
        {
            this.CoefficientB = CoefficientB;
            coefficientK = CoefficientK;
        }

        public void GetRoot()
        {
            double VariableX = -(CoefficientB / coefficientK);
            if (CoefficientB == 0)
            {
                Console.WriteLine("Переменная х = 0");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Переменная х = {0:f3}", VariableX);
                Console.ReadKey();
            }
        }
    }
}
