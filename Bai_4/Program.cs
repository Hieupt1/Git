using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Text;


namespace Bai_4
{
    class Bai_4_1
    {
        static public void bai_4_1() {

            try
            {
                Console.Write("Nhap vao duong dan thu muc muon tao: ");
                Directory.CreateDirectory(Console.ReadLine());
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }

    class Bai_4_2
    {
        static public void bai_4_2() {
            try
            {
                Console.Write("Nhap duong dan file ban muon tao: ");
                StreamWriter sw = new StreamWriter(Console.ReadLine());
                Console.WriteLine("Them noi dung vao file vua tao: ");

                string quit = "";

                quit = Console.ReadLine();
                    
                while (quit != "") {
                    sw.WriteLine(quit);
                    quit = Console.ReadLine();
                };
                
                sw.Close();

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Bai_4_3
    {
        public static void bai_4_3() {

            try
            {
                Console.Write("Nhap vao duong dan thu muc: ");
                string folder_path = Console.ReadLine();

                DirectoryInfo di = new DirectoryInfo (folder_path);

                List<FileInfo> list_file = di.GetFiles("*", SearchOption.AllDirectories).ToList();
    
                Console.WriteLine($"There are {list_file.Count()} files in the folder {folder_path}");
                foreach (FileInfo file in list_file ) {
                    Console.WriteLine($"The size of {file} is: {file.Length} bytes");
                }

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class  Bai_4_4
    {
        public static void bai_4_4() {
            try
            {   
                string path = @"keyword.txt";
                String[] str = File.ReadAllLines(path);

                // random keyword
                Random rd = new Random();
                int random_index = rd.Next(0, 4);

                // Gan random thanh o chu
                string my_secret = str[random_index];

                // pattern de loc cac ky tu thoa man tu string
                string pattern = @"[A-Za-z0-9_ ]";

                MatchCollection matches = Regex.Matches(my_secret, pattern);

                List<string> list = new List<string>();
                
                // Chuyen string => List
                foreach (Match elm in matches) {
                    list.Add(elm.Value);
                }

                // Ma hoa List thanh List ky tu an
                List<string> hide_list = new List<string>();

                // Chuyen List an thanh String an
                for (int i = 0; i< list.Count(); i++) {
                    if (list[i] != " ") {
                        hide_list.Add("*");
                    } else {
                        hide_list.Add("_");
                    }
                }

                string hide_str = String.Join("", hide_list.ToArray());

                Console.WriteLine("Tim cau sau, biet moi dau sao la mot chu cai và dau gach duoi la mot day cach: ");
                Console.WriteLine(hide_str);
                
                // Xac dinh so lan choi toi da
                int max_count = 10;

                Console.WriteLine ($"\n Ban co toi da {max_count} lan doan");

                //

                int count = 0;
                // Bat dau doan chu
                for (count = 1; count <= max_count; count++ ) {

                    Console.Write ($"Lan {count}: ");

                    string char1 = Console.ReadLine();

                    List<int> index = new List<int>();

                    for (int j = 0; j < list.Count(); j++) {
                        index.Add (Array.IndexOf (list.ToArray(), char1, j));
                    }

                    int count_chars = 0;

                    for (int k = 0; k < index.Count(); k++) {
                        if (index.Contains(k)) {
                            hide_list[k] = list[k];
                            count_chars ++;
                        }
                    }

                    hide_str = String.Join("", hide_list.ToArray());

                    if (count_chars > 0) {
                        Console.WriteLine($"Chuc mung, co {count_chars} chu cai '{char1}' trong cau.");
                    } else {
                        Console.WriteLine ($"Rat tiec, khong co chu cai '{char1}' nao.");
                    }

                    Console.WriteLine(hide_str);

                    Console.WriteLine("Ban da doan ra duoc o chu ? Ghi vao day (Neu ko, an Enter de choi tiep):");
                    Console.WriteLine("  LUU Y: NEU DOAN SAI, BAN SE THUA VA NGAY LAP TUC DUNG CUOC CHOI !");
                    string guess = Console.ReadLine();

                    if (guess == my_secret) {
                        Console.WriteLine("CHUC MUNG, ban da thang cuoc!");
                        return;
                    } else if (guess != "")
                    {
                        Console.WriteLine("RAT TIEC, ban da thua cuoc va phai dung cuoc choi");
                        return;
                    }

                }

                if (hide_list.Contains("*")) {
                    Console.WriteLine("RAT TIEC, Ban da thua cuoc !");
                } else {
                    Console.WriteLine("CHUC MUNG, ban da tim ra o chu va thang cuoc!");
                }

            }   
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            // Bai 4.1
            Console.WriteLine("Bai 4.1 Tạo 1 thư mục mới");
            Bai_4_1.bai_4_1();

            // Bai 4.2
            Console.WriteLine("Bai 4.2 Tạo 1 file text mới và viết dữ liệu vào");
            Bai_4_2.bai_4_2();

            // Bai 4.3
            Console.WriteLine("Bai 4.3 Tìm tất cả file trong 1 thư mục");
            Bai_4_3.bai_4_3();

            // Bai 4.4
            Console.WriteLine("Bai 4.4 Hangman game: đọc dữ liệu từ 1 file text chứa các từ khóa, chọn 1 từ ngẫu nhiên trong file này và viết game đoán chữ trên console");
            Bai_4_4.bai_4_4();

        }
    }
}
