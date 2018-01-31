using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CodeCamp_2
{
    class Bai_1
    {
        public static void bai_1() {

            try
            {
                Random rnd = new Random();
                int number = rnd.Next(-100, 100);

                // Bien luu tru gia tri nhap
                int input = 0;

                // Bien luu so lan nhap
                int count = 0;

                while (input != number)
                {

                    Console.Write("Nhap vao day mot so trong khoang (-100, 100): ");
                    input = Convert.ToInt32(Console.ReadLine());

                    count += 1;

                    if (input > number)
                    {
                        Console.WriteLine("Guess Higher");
                    }
                    else if (input < number)
                    {
                        Console.WriteLine("Guess Lower");
                    }
                    else if (input == number)
                    {
                        Console.WriteLine($"You win with {count} guesses. The correct number is: {number}");
                    }

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

        }
    }

    class Bai_3
    {
        public static void bai_3() {

            try
            {
                Console.WriteLine("Hay nhap vao mot list so nguyen, cach nhau boi dau cach");
                string input = Console.ReadLine();

                // Chuyen tu input thanh Array cac so
                string[] arr = input.Split(' ');

                List<int> num_list = new List<int>();

                // Chuyen tu Arr la string sang List cac int
                foreach (string elm in arr) {
                    num_list.Add(Convert.ToInt32(elm));
                }

                // Check so phan tu trong list xem co > 2 
                if (num_list.Count() < 2) {
                    Console.WriteLine("Qua it so nguyen trong list nen khong the kiem tra tinh lien tuc, hay lam lai.");
                    return;
                }

                // Set khoang cach chuan cho cac so
                int gap_standard = num_list[1] - num_list[0];

                List<int> check = new List<int>();

                // Check khoang cach giua cac so
                for (int i = 1; i < num_list.Count() ; i++) {
                    if (num_list[i] - num_list[i - 1] != gap_standard) {
                        check.Add(i);
                    }
                }

                if (check.Count() == 0) {
                    Console.WriteLine("Yes. This is a consecutive array of numbers");
                } else {
                    Console.WriteLine("No. This is not a consecutive array of numbers");
                }

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Bai 1
            Console.WriteLine("Bai 1. Game doan so");
            Bai_1.bai_1();

            // Bai 2


            // Bai 3
            Console.WriteLine("Bai 3. Viết một chương trình yêu cầu người dùng nhập vào 1 mảng số nguyên và kiểm tra xem mảng này có chứa các số liền nhau không.");
            Bai_3.bai_3();

        }
    }
}
