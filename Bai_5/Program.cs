using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Text;

namespace Bai_5
{
    class Bai_5_1
    {
        static public void bai_5_1 () {

            try
            {
                Console.WriteLine("Nhap mot list cac so nguyen vao day, cach nhau boi dau cach ' ': ");
                string input = Console.ReadLine();
                
                List<string> list = input.Split(' ').ToList();

                // var even_num = list.Where(num => Convert.ToInt32(num) % 2 == 0);

                var even_num = from num in list where Convert.ToInt32(num) % 2 == 0 select num;

                Console.WriteLine("Cac so chan trong day la: ");

                foreach (string even in even_num) {
                    Console.WriteLine (even);
            }

            } catch (System.Exception e)
            {  
                Console.WriteLine(e.Message);
            }

        }
    }

    class Bai_5_2
    {
        public static void bai_5_2() {

            try
            {
                Console.WriteLine("Nhap vao mot tap hop cac chuoi, cach nhau boi ky hieu'\\': ");
                string input = Console.ReadLine();

                List<string> list = input.Split('\\').ToList();

                // Ky tu bat dau va cuoi cung cua mot string
                Console.Write("Nhap ky tu ban dau mot chuoi: ");
                string first_pattern = Console.ReadLine();
                Console.Write("Nhap ky tu ket thuc mot chuoi: ");
                string last_pattern = Console.ReadLine();

                // Loc chuoi thoa man dieu kien ky tu bat dau va ket thuc
                var filter = list.Where( str => str.StartsWith(first_pattern) && str.EndsWith(last_pattern) );
                Console.WriteLine("Chuoi thoa man dieu kien la: ");

                foreach (var ft in filter) {
                    Console.WriteLine(ft);
                }

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    class Bai_5_3
    {
        public static void bai_5_3() {

            try
            {
                Console.WriteLine("Nhap vao mot day cac so nguyen, cach nhau boi dau cach ' ': ");
            
                string input = Console.ReadLine();

                List<string> list = input.Split(' ').ToList();

                List<int> list_convert = new List<int>();

                for (int i = 0; i < list.Count(); i++) {
                    list_convert.Add(Convert.ToInt32(list[i]));
                }
                
                var max_num = list_convert.Max();

                Console.WriteLine($"So lon nhat trong list la: {max_num}");

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }

    class Bai_5_4
    {
        public static void bai_5_4() {
            try
            {
                Console.WriteLine("Nhap vao mot tap hop cac ky tu, cach nhau boi ky hieu'\\': ");
                string input = Console.ReadLine();

                List<string> list = input.Split('\\').ToList();

                var list_sort = list.OrderBy (li => li);

                foreach (var li in list_sort) {
                    Console.WriteLine(li);
                }                
        
            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }

    class Bai_5_5
    {
        public static void bai_5_5() {
            try
            {

                Console.Write("Nhap vao duong dan thu muc: ");
                string folder_path = Console.ReadLine();

                DirectoryInfo di = new DirectoryInfo (folder_path);

                List<FileInfo> list_file = di.GetFiles("*", SearchOption.AllDirectories).ToList();

                int total_size = 0;
    
                Console.WriteLine($"There are {list_file.Count()} files in the folder {folder_path}");
                foreach (FileInfo file in list_file ) {
                    total_size += Convert.ToInt32(file.Length);
                }

                Console.WriteLine($"Average of all file in folder is: {total_size / list_file.Count()} bytes");


            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    class Bai_5_6
    {
        public static void bai_5_6() {

            try
            {
                // Dicttionary luu try ho ten va diem
                Dictionary <string, double> dict = new Dictionary<string, double>();
                string name ;
                string rating;

                Console.WriteLine("Nhap vao day hoc sinh va diem tuong ung: \nKhi da nhap xong, an Enter o moi truong tuong ung");

                Console.Write("Ho ten: ");
                name = Console.ReadLine();
                
                Console.Write("Diem: ");
                rating = Console.ReadLine();

                while (name != "") {

                    dict.Add(name, Convert.ToDouble(rating));

                    Console.Write("Ho ten: ");
                    name = Console.ReadLine();
                    
                    Console.Write("Diem: ");
                    rating = Console.ReadLine();
                }

                // Check List sinh vien
                if (dict.Count() < 2) {
                    Console.WriteLine("Co it hon 2 sinh vien, khong the tinh diem trung binh.");
                    return;
                }


                // Tinh tong diem cua cac Sinh vien
                double total_rating = 0;

                foreach ( var std in dict ) {
                    total_rating += std.Value;
                }
                // Tinh trung binh diem
                double average = total_rating / dict.Count();


                // Loc ra sinh vien co diem thap hon diem trung binh
                var dict_filter = from di in dict let get_rating = di.Value where get_rating < average select di;    
                
                Console.WriteLine($"Sinh vien co diem thap hon diem trung binh {average} la: ");
                foreach (KeyValuePair<string, double> std_low in dict_filter ) {
                    Console.WriteLine($"{std_low.Key} : {std_low.Value}"); 
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
            // Bai 5.1: 
            Console.WriteLine("Bai 5.1: Nhận phần tử của 1 tập hợp List qua console và in ra những số chẵn");
            Bai_5_1.bai_5_1();

            // Bai 5.2: 
            Console.WriteLine("Bai 5.2 Có 1 tập hợp chuỗi, tìm phần tử bắt đầu và kết thúc với kí tự nhất định");
            Bai_5_2.bai_5_2();

            // Bai 5.3: 
            Console.WriteLine("Bai 5.3 Nhận tập hợp List chứa số và in ra n-th số lớn nhất");
            Bai_5_3.bai_5_3();
            
            // Bai 5.4: 
            Console.WriteLine("Bai 5.4 Tạo 1 tập hợp chuỗi và sắp xếp các phần tử riêng biệt theo thứ tự A-Z");
            Bai_5_4.bai_5_4();

            // Bai 5.5: 
            Console.WriteLine("Bai 5.5 Tính trung bình kích thước các file trong 1 thư mục bằng linq");
            Bai_5_5.bai_5_5();

            // Bai 5.6: 

            Console.WriteLine("Bai 5.6 Cho 1 tập hợp học sinh và điểm, tìm các học sinh có điểm thấp hơn điểm trung bình sử dụng let trong linq");
            Bai_5_6.bai_5_6();

        }
    }
}
