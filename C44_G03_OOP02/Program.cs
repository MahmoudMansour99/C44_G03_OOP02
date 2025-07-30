using C44_G03_OOP02.Encapsulation;

namespace C44_G03_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] person = new Person[3];

            //person[0] = new Person("Ahmed", 22);
            //person[1] = new Person("Omar", 25);
            //person[2] = new Person("Ali", 27);

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Name: {person[i].Name}, Age: {person[i].Age}");
            //}



            #endregion
            #region 2.	Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter coordinates of the first point:");
            //Console.Write("X1: ");
            //double.TryParse(Console.ReadLine(), out double x1);
            //Console.Write("Y1: ");
            //double.TryParse(Console.ReadLine(), out double y1);

            //Point P01 = new Point(x1, y1);

            //Console.WriteLine("Enter coordinates of the second point:");
            //Console.Write("X2: ");
            //double.TryParse(Console.ReadLine(), out double x2);
            //Console.Write("Y2: ");
            //double.TryParse(Console.ReadLine(), out double y2);

            //Point P02 = new Point(x2, y2);

            //double dx = P02.X - P01.X;
            //double dy = P02.Y - P01.Y;

            //double distance = Math.Sqrt(dx * dx + dy * dy);

            //Console.Clear();
            //Console.WriteLine($"Distance between the two points: {distance:F2}");

            #endregion
            #region 3.	Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] people = new Person[3];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for person #{i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int.TryParse(Console.ReadLine(), out int age);

            //    people[i] = new Person(name, age);
            //}

            //Person oldest = people[0];

            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine($"\nThe oldest person is: {oldest.Name}, Age: {oldest.Age}");

            #endregion
            #region 4.Create a struct named Rectangle that represents a rectangle with the following fields: width (type: double) - height (type: double) - Implement encapsulation by making the fields private and provide public properties access and modify these values. Ensure the following conditions are met: The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message. Implement a public read-only property Area that calculates and returns the area of the rectangle (Area = width * height). Implement a method DisplayInfo that prints the rectangle's dimensions and area. Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.

            Rectangle rectangle = new Rectangle(5, 10);

            rectangle.Width = 8;
            rectangle.Height = 12;

            Console.Clear();
            rectangle.DisplayInfo();

            #endregion

        }
    }
}
