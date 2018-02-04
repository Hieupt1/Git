using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Text;

namespace CodeCamp3
{

    class Bai_1
    {
        public static void bai_1 () {
            try
            {
                string[] cities =  {"ROME","ZURICH","AMSTERDAM","SAIGON", "LONDON","HANOI","CALIFORNIA", "PARIS"};

                var sort_cities = from city in cities orderby city.Length, city select city;

                foreach (string city in sort_cities) {
                    Console.WriteLine(city);
                }

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

    class Bai_2
    {
        public static void bai_2 () {
            try
            {
                // Day so number 
                Console.Write("Nhap vao mot day so, cac so cach nhau boi dau cach ' ': ");
                string input = Console.ReadLine();

                string[] arr = input.Split(' ');

                List<double> list = new List<double>();
            
                foreach (string num in arr) {
                    list.Add(Convert.ToDouble(num)) ;
                }

                // Day so Square
                Console.Write("Nhap vao mot day so - la cac so binh phuong cua day so tren, cac so cach nhau boi dau cach ' ': ");
                string input2 = Console.ReadLine();

                string[] arr2 = input2.Split(' ');

                List<double> list2 = new List<double>();
            
                foreach (string num in arr2) {
                    list2.Add(Convert.ToDouble(num)) ;
                }

                // Binh phuong moi phan tu cua day so thu nhat
                List<double> list_square = (from num in list where num !=0 select num*num).ToList();

                // So sanh
                bool isEqual = list2.SequenceEqual(list_square);
                Console.WriteLine(isEqual ? "Day so thu 2 la binh phuong day so thu 1" : "2 day so khong co moi quan he binh phuong");


            } catch (System.Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Bai_3
    {
        public static void bai_3 () {
            try
            {
                Console.Write("Nhap vao list cac string, cach nhau boi dau '\\' ");
                string input = Console.ReadLine();

                string[] arr = input.Split('\\');

                string[] arr_contains_e = arr.Where (s => s.Contains("e")).ToArray();

                string[] arr_contains_e_sort = arr_contains_e.OrderBy(s => s).ToArray();

                Console.WriteLine($"The last word is {arr_contains_e_sort.Last()}");

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Quiz
            // Cau 1: B
            // Cau 2: A
            // Cau 3: C
            // Cau 4: D
            // Cau 5: D
            // Cau 6: C
            // Cau 7: C
            // Cau 8: A
            // Cau 9: B
            // Cau 10: A
            // Cau 11: C
            // Cau 12: A
            // Cau 13: A
            // Cau 14: B
            // Cau 15: A
            // Cau 16: A

            // Thuc hanh

            // Bai 1
            Console.WriteLine("Bai 1: Sap xep City");
            Bai_1.bai_1();

            // Bai 2
            Console.WriteLine("Bai 2 Viết 1 phương thức kiểm tra 2 tập hợp dữ liệu: sử dụng LINQ không dùng vòng lặp");
            Bai_2.bai_2();
            
            // Bai 3
            Console.WriteLine("Bai 3: Viết 1 phương thức kiểm tra tập hợp dữ liệu: sử dụng LINQ không dùng vòng lặp");
            Bai_3.bai_3();
        }
    }
}
