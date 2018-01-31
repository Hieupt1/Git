using System;

namespace Bai_7
{

    // Bai 7.1
    class Car
    {
        // Dem so doi tuong Car duoc tao
        public static int count = 0;
        public string Brand { get; set; } = "Lexus";

        public string Color { get; set; } = "black";

        public int Year { get; set; } = 2016;

        public double Mileage { get; set; } = 1100.68;
        
        public Car (string brand, string color, int year, double mileage) {
            Brand = brand;
            Color = color;
            Year = year;
            Mileage = mileage;
            count ++;
        }
        
        public Car (string color, int year, double mileage) {
            Color = color;
            Year = year;
            Mileage = mileage;
            count ++;
        }

    }

    // Bai 7.2

    class Person
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        
        // Ty le chieu cao / can nang
        public double Ratio () {
            return Height / Weight;
        }
    }     

    class Student: Person
    {

        public static int stds_num;
        public int Rating { get; set; }
        
        public Student (double height, double weight, int rating) {
            Height = height;
            Weight = weight;
            Rating = rating;
            stds_num ++;
        }

        public double Get_ratio() {
            return base.Ratio();
        }

    }

    class Teacher: Person
    {
        public static int tchrs_num;
        public int Experience_year { get; set; }
        
        public Teacher (double height, double weight, int experience_year) {
            Height = height;
            Weight = weight;
            Experience_year = experience_year;
            tchrs_num ++;
        }

        public double Get_ratio() {
            return base.Ratio();
        }

    }

    // Bai 7.3

    static class Calculator
    {
        static double A = 0;
        static double B = 0;
        static public void Assign (double a, double b) {
            A = a;
            B = b;
        }
        static public double Add () {
            double Add;
            return Add = A + B;
        }
        static public double Subtract () {
            double Subtract;
            return Subtract = A - B;
        }
        static public double Multiply () {
            double Subtract;
            return Subtract = A * B;
        }
        static public double Divide () {
            double Subtract;
            return Subtract = A / B;
        }
    }

    // Bai 7.4

    class PERSON
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        // bien dem so Hoc sinh va giao vien
        public static int stds_num = 0;
        public static int tchrs_num = 0;
        
        public PERSON (double h, double w) {
            Height = h;
            Weight = w;
        }

        // Ty le chieu cao/ can nang
        public double Ratio () {
            return Height / Weight;
        }
    }

    class STUDENT: PERSON
    {
        public int Rating { get; set; }
        public STUDENT (double h, double w, int rating) : base(h,w) {
            Rating = rating;
            stds_num ++;
        }

        public STUDENT (double h, double w) : base(h,w) {
            stds_num ++;
        }
        public double Get_ratio() {
            return base.Ratio();
        }
    } 

    class TEACHER: PERSON
    {
        public int Exprerience_year { get; set; }
        public TEACHER (double h, double w, int experience_year) : base(h,w) {
            Exprerience_year = experience_year;
            tchrs_num ++;
        }
        public TEACHER (double h, double w) : base(h,w) {
            tchrs_num ++;
        }
        public double Get_ratio() {
            return base.Ratio();
        }
    } 


    class Program
    {
        static void Main(string[] args)
        {   

            // Bai 7.1
            Console.WriteLine ("Bai 7.1");
            Car Car1 = new Car ("Msd", "blue", 2010, 2000);
            Car Car2 = new Car ("Toyota", "white", 2012, 100.69);
            Car Car3 = new Car ("gray", 2018, 10.10);
            Console.WriteLine($"There are {Car.count} cars on inventory right now.");

            // Bai 7.2
            Console.WriteLine ("Bai 7.2");
            Student student1 = new Student (1.68, 68.6 , 9);
            Student student2 = new Student (1.79, 86, 4);
            Teacher teacher1 = new Teacher (1.58, 48, 5);
            Teacher teacher2 = new Teacher (1.64, 58, 10);
            Console.WriteLine($"There are {Student.stds_num} teachers and {Teacher.tchrs_num} students in the class.");
            Console.WriteLine($"Ty le Chieu Cao/ Can Nang cua student1 la: {student1.Get_ratio()}");
            
            // Bai 7.3
            Console.WriteLine("Bai 7.3");
            Console.Write("Nhap A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Calculator.Assign(a, b);

            Console.WriteLine($"{a} + {b} = {Calculator.Add()}");
            Console.WriteLine($"{a} - {b} = {Calculator.Subtract()}");
            Console.WriteLine($"{a} * {b} = {Calculator.Multiply()}");
            Console.WriteLine($"{a} / {b} = {Calculator.Divide()}");

            // Bai 7.4
            Console.WriteLine("Bai 7.4");
            STUDENT STUDENT1 = new STUDENT (1.68 , 68.6, 9);
            STUDENT STUDENT2 = new STUDENT (1.79 , 86);
            STUDENT STUDENT3 = new STUDENT (1.48 , 54.9, 8);
            TEACHER TEACHER1 = new TEACHER (1.58, 48, 5);
            TEACHER TEACHER2 = new TEACHER (1.64, 52, 2);
            Console.WriteLine($"There are {STUDENT.stds_num} teachers and {TEACHER.tchrs_num} students in the class.");
            Console.WriteLine($"Ty le Chieu Cao/ Can Nang cua STUDENT1 la: {STUDENT1.Get_ratio()}");
        }
    }
}
