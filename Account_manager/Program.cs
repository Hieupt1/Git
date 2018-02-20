using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Text;

namespace Account_manager
{
    class Account
    {
        public string MaTK { get; set; }
        
        public string Password { get; set; }
        
        public string Name { get; set; }
        
        public string tel_num { get; set; }
        
    }

    class Account_manager
    {
        List <Account> account_list = new List <Account>();

        // Loading
        public void account_loading () {
            List<string> accounts = File.ReadAllLines(@"./user.txt").ToList();

            foreach(var acc in accounts) {
                
                List<string> split = acc.Split('_').ToList();

                account_list.Add(new Account() {MaTK = split[0], Password = split[1], Name = split[2], tel_num = split[3] });
            }
        }

        // Tim tai khoan theo ten
        public void Find_acc_by_name () {

            account_loading();

            Console.Write("Nhap ten tai khoan muon tim: ");
            string name = Console.ReadLine().ToLower().Trim();

            var find = account_list.Where(acc => acc.Name.ToLower().Trim() == name).ToList();

            Console.WriteLine($"Ket qua ({find.Count()}):");

            foreach (var acc in find) {
                Console.WriteLine($"MaTK: {acc.MaTK}, Name: {acc.Name}, Sdt: {acc.tel_num}");
            }

        }

        // Dang nhap
        public void Sign_in () {

            account_loading();

            Console.Write("Nhap MaTK: ");
            string MaTK = Console.ReadLine();

            Console.Write("Nhap password: ");
            string Password = Console.ReadLine();

            int check_name = account_list.FindIndex(acc => acc.MaTK == MaTK);

            int check_pass = account_list.FindIndex(acc => acc.Password == Password);

            if (check_name == check_pass && check_name >= 0 ) {
                Console.WriteLine("Dang nhap thanh cong.");
            } else {
                Console.WriteLine("Ten hoac mat khau khong dung.");
            }

        }

        // Dang ky
        public void Sign_up () {

            account_loading();

            Console.WriteLine("Tao tai khoan moi:");
            Console.Write("Nhap ho ten (Tieng viet khong dau va khong duoc su dung cac ky tu dac biet): ");
            string Name = Console.ReadLine();
            Console.Write("Nhap Password: ");
            string Password = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string tel_num = Console.ReadLine();

            account_list.Add(new Account() {MaTK = Guid.NewGuid().ToString() ,Password = Password, Name = Name, tel_num = tel_num });

            int index = account_list.Count() -1;

            Console.WriteLine($"Chuc mung, ban vua Dang ky voi cac thong tin sau: ");
            Console.WriteLine($"MaTK: {account_list[index].MaTK}, Password: {account_list[index].Password}, Name: {account_list[index].Name}, Sdt: {account_list[index].tel_num}");

            List<string> account_list_str = new List<string>();

            foreach (var acc in account_list) {
                string info = acc.MaTK + "_" + acc.Password + "_" + acc.Name + "_" + acc.tel_num;
                account_list_str.Add(info);
            }

            File.WriteAllLines(@"./user.txt", account_list_str);
        }

        // Xoa Tai khoan
        public void Delete () {

            account_loading();

            Console.WriteLine("Xoa tai khoan");
            Console.Write("Nhap ten muon xoa: ");
            string name_delete = Console.ReadLine();

            int check = account_list.FindIndex(acc => acc.Name == name_delete);

            if (check >=0) {
                account_list.RemoveAt(check);
                Console.WriteLine("Xoa TK thanh cong");

                List<string> account_list_str = new List<string>();

                foreach (var acc in account_list) {
                string info = acc.MaTK + "_" + acc.Password + "_" + acc.Name + "_" + acc.tel_num;
                account_list_str.Add(info);
            }

            File.WriteAllLines(@"./user.txt", account_list_str);


            } else {
                Console.WriteLine("Nhap sai ten, hay lam lai.");
            }

        }

        // Sap xep
        public void Sort () {

            account_loading();

            Console.WriteLine("Sap xep cac TK theo ten: ");

            var account_list_sort = account_list.OrderBy(acc => acc.Name).ToList();

            account_list_sort.ForEach(acc => Console.WriteLine($"MaTK: {acc.MaTK}, Pass: {acc.Password}, Name: {acc.Name}, Sdt: {acc.tel_num}"));

        }




    }


    class Program
    {
        static void Main(string[] args)
        {
            Account_manager AM = new Account_manager();
            // AM.Find_acc_by_name();
            // AM.Sign_in();
            // AM.Sign_up();
            // AM.Delete();
            // AM.Sort();
        }
    }
}
