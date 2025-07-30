using C44_G03_OOP02.Encapsulation;

namespace C44_G03_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            #region Example 01
            //Point P01;
            //P01 = new Point(15);

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);
            #endregion

            #region Example 02

            //Point P01 = new Point(10, 20);

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);

            //Point P02 = new Point(30, 40);

            //Console.WriteLine(P02.x);
            //Console.WriteLine(P02.y);

            //P02 = P01;

            //Console.WriteLine(P02.x);
            //Console.WriteLine(P02.y);

            //Console.WriteLine(P01);
            //Console.WriteLine(P01.ToString());

            #endregion

            #endregion

            #region OOP Pillars

            #endregion

            #region Encapsulation

            Employee employee = new Employee(10, "Ahmed", 9000);

            //employee.Id = 10; // Set Id  direct by attr
            //Console.WriteLine(employee.Id); // get Id direct by attr

            //employee.SetName("Ahmed");
            //Console.WriteLine(employee.GetName());

            //employee.Salary = 9000;
            //Console.WriteLine(employee.Salary);

            employee.Age = 10;
            Console.WriteLine(employee.Age);

            #endregion

        }
    }
}
