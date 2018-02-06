using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Text;

namespace Bai_6
{
    class Bai_6_1
    {
        enum Days {Mon, Tue, Web, Thu, Fri, Sat, Sun };
        public static void bai_6_1 () {
            try
            {
                Console.Write("Mon: 1 => Sun: 7, nhap so tuong ung de ra ngay trong tuan tuong ung: ");
                int num = Convert.ToInt32(Console.ReadLine()); 

                if (num == 1) {
                    Console.WriteLine(Days.Mon);
                } else if (num == 2) {
                    Console.WriteLine(Days.Tue);
                } else if (num == 3) {
                    Console.WriteLine(Days.Web);
                } else if (num == 4) {
                    Console.WriteLine(Days.Thu);
                } else if (num == 5) {
                    Console.WriteLine(Days.Fri);
                } else if (num == 6) {
                    Console.WriteLine(Days.Sat);
                } else if (num == 7) {
                    Console.WriteLine(Days.Sun);
                } else {
                    Console.WriteLine("Nhap sai!");
                } 
                
            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    // Bai 6.2
    class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        static int count = 0;

        public static int get_count () {
            return count;
        }
        public Book (int id, string title, string author, int year) {
            ID = id;
            Title = title;
            Author = author;
            Year = year;
            count ++;
        }
    }

    class Book_Store
    {
        public static List<Book> book_store () {
            List<Book> book_list = new List<Book> () {
                new Book(1 , "Summer" , "John", 2016) ,
                new Book(2 , "Spring" , "Nash", 2015) ,
                new Book(3 , "Winter" , "Frank", 2017) ,
                new Book(4 , "Autumn" , "John", 2018) ,
                new Book(5 , "Computer" , "John", 2010) ,
                new Book(6 , "Summer" , "Nash", 2012) ,
                new Book(7 , "Spring" , "Frank", 2014) ,
                new Book(8 , "smartwatch" , "John", 1998) ,
                new Book(9 , "C#" , "John", 2016) ,
                new Book(10 , "Java" , "Nash", 2015) ,
                new Book(11 , "JavaScript" , "Frank", 2016) ,
                new Book(12 , "Python" , "John", 2018) ,
            };
            return book_list;
        }
    }

    class Bai_6_2
    {
        // Loc theo Title
        public void title_filter () {

            List<Book> book_list = Book_Store.book_store();

            Console.Write("Nhap Title ban muon tim kiem. Goi y:  ");

            var group_title = from book in book_list group book by book.Title;

            foreach (var book in group_title) {
                Console.Write($"{book.Key}, ");
            }
            Console.Write("\n Title: ");

            string title_find = Console.ReadLine();

            var title_filter = from book in book_list where book.Title.ToLower().Trim() == title_find.ToLower().Trim() select book;

            Console.WriteLine($"Ket qua ({title_filter.Count()}): ");
            foreach (var book in title_filter) {
                Console.WriteLine($"ID: {book.ID}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }

        // Loc theo Author
        public void author_filter () {

            List<Book> book_list = Book_Store.book_store();
            
            Console.Write("Nhap Author ban muon tim kiem. Goi y: ");

            var group_author = from book in book_list group book by book.Author;

            foreach (var book in group_author) {
                Console.Write($"{book.Key}, ");
            }
            Console.Write("\n Author: ");
            string author_find = Console.ReadLine();

            var author_filter = from book in book_list where book.Author.ToLower().Trim() == author_find.ToLower().Trim() select book;

            Console.WriteLine($"Ket qua ({author_filter.Count()}): ");
            foreach (var book in author_filter) {
                Console.WriteLine($"ID: {book.ID}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }

        // Loc theo Year
        public void year_filter () {

            List<Book> book_list = Book_Store.book_store();

            Console.Write("Nhap Year ban muon tim kiem. Goi y: ");

            var group_year = from book in book_list group book by book.Year;

            foreach (var book in group_year) {
                Console.Write($"{book.Key}, ");
            }
            Console.Write("\n Year: ");

            int year_find = Convert.ToInt32 (Console.ReadLine());

            var year_filter = from book in book_list where book.Year == year_find select book;

            Console.WriteLine($"Ket qua ({year_filter.Count()}): ");
            foreach (var book in year_filter) {
                Console.WriteLine($"ID: {book.ID}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }

        public void bai_6_2 () {
            try
            {
                Console.WriteLine("Ban muon tim kiem Book theo? (Chon a hoac b hoac c) ");
                Console.WriteLine("a. Title");
                Console.WriteLine("b. Author");
                Console.WriteLine("c. Year");
                Console.Write("Cau tra loi: ");
                string choose = Console.ReadLine();

                while (choose != "a" && choose != "b" && choose != "c") {
                    Console.WriteLine("Ban chon sai quy tac, chon lai (chi viet 1 chu cai a hoac b hoac c, sau do Enter)");
                    Console.Write("Cau tra loi: ");
                    choose = Console.ReadLine();
                }

                if (choose == "a") {

                    this.title_filter();

                } else if (choose == "b") {

                    this.author_filter();

                } else if (choose == "c") {
                    
                    this.year_filter();
                }


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
            // Bai 6.1
            Console.WriteLine("Bai 6.1 Viết chương trình lưu các ngày trong tuần bằng enum và nhận 1 số người dùng nhập vào và in ra ngày tương ứng.");
            Bai_6_1.bai_6_1();

            // Bai 6.2
            Console.WriteLine("Bai 6.2 Book Store");
            Bai_6_2 b_6_2 = new Bai_6_2();
            b_6_2.bai_6_2();

        }
    }
}
