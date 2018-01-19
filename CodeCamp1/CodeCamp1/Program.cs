using System;

namespace CodeCamp1
{

    class Bai_1
    {
        // Bien luu gia tri giai thua
        public long fact = 1;

        public void bai_1()
        {
            try
            {
                Console.Write("Nhap mot so nguyen (n) vao day: ");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    fact *= i;
                }

                Console.WriteLine("Giai thua cua so n la: {0}", fact);

            }
            catch (System.Exception e)
            {
                Console.Write(e.Message);
            }

        }

    }

    class Bai_2
    {
        public int num_size;
        public void bai_2()
        {
            try
            {
                Console.Write("Nhap mot so nguyen (n) vao day: ");
                int num = Convert.ToInt32(Console.ReadLine());
                string str = Convert.ToString(num);
                num_size = str.Length;

                Console.WriteLine("Tong cac chu so trong so n la: {0}", num_size);

            } catch (System.Exception e)
            {
                Console.Write(e.Message);
            }

        }

    }

    class Bai_3
    {
        // Khai bao string ket qua:
        public string str_b3 = "";

        public string bai_3()
        {
            Console.Write("Nhap mot so chuoi (str) vao day: ");
            string str = Convert.ToString(Console.ReadLine());

            str.Trim();

            char[] charSeparators = new char[] { ' ' };

            // Khao bao arr chua cac chu tu string
            string[] arr = str.Split(charSeparators);

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = Convert.ToString(arr[i].Substring(0, 1)).ToUpper() + Convert.ToString(arr[i].Substring(1)).ToLower();
            }

            str_b3 = String.Join(" ", arr);

            return str_b3;
        }
    }

    class Bai_4
    {
        // Khai bao bien so lon thu 2:
        public double num_b4;

        public void bai_4()
        {

            try
            {
                Console.Write("Nhap mot so day cac so vao day, cach nhau boi dau cach \" \": ");
                string str = Convert.ToString(Console.ReadLine());

                char[] charSeparators = new char[] { ' ' };

                // arr chua cac chu so sau khi tach
                string[] arr = str.Split(charSeparators);

                // Chuyen arr thanh arr2 chua cac so
                double[] arr2 = new double[arr.Length];

                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = Convert.ToInt32(arr[i]);
                }
                Array.Sort(arr2);

                num_b4 = arr2[arr.Length - 2];

                Console.WriteLine(num_b4);


            } catch (System.Exception e)
            {
                Console.Write(e.Message);
            }



        }
    }

    class Bai_5
    {

        //Khai bao nghiem
        public double x1;
        public double x2;
        public string result;

        public void bai_5()
        {

            try 
            {
                Console.WriteLine("Phuong trinh bac 2: ax2 + bx + c = 0 ");

                Console.Write("Nhap so a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhap so b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhap so c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                // Khai bao delta
                double delta = b * b - 4 * a * c;

                if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = -b / (2 * a);
                    result = "x1 = x2 = " + Convert.ToString(x1);
                }
                else if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    result = "x1= " + Convert.ToString(x1) + ", " + "x2= " + Convert.ToString(x2);

                }
                else if (delta < 0)
                {
                    result = "Phuong trinh vo nghiem.";
                }

                Console.WriteLine(result);


            } catch(System.Exception e) 
            {
                Console.WriteLine(e.Message);
            }


        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            //Bai 1
            Console.WriteLine("Bai 1: ");
            Bai_1 Bai_1 = new Bai_1();
            Bai_1.bai_1();


            //Bai 2
            Console.WriteLine("Bai 2: ");
            Bai_2 Bai_2 = new Bai_2();
            Bai_2.bai_2();


            //Bai 3
            Console.WriteLine("Bai 3: ");
            Bai_3 Bai_3 = new Bai_3();
            Console.WriteLine("Str: {0}", Bai_3.bai_3());

            //Bai 4
            Console.WriteLine("Bai 4: ");
            Bai_4 Bai_4 = new Bai_4();
            Bai_4.bai_4();


            //Bai 5
            Console.WriteLine("Bai 5: ");
            Bai_5 Bai_5 = new Bai_5();
            Bai_5.bai_5();

            Console.ReadKey();
        }
    }
}