using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Text;


namespace Bai_8
{

    static class Bai_8_1
    {
        // Calculator Int
        public static double Add (int a, int b) {
            double Add;
            return Add = a + b;
        }
        public static double Subtract (int a, int b) {
            double Subtract;
            return Subtract = a - b;
        }
        public static double Multiply (int a, int b) {
            double Subtract;
            return Subtract = a * b;
        }
        public static double Divide (int a, int b) {
            double Subtract;
            return Subtract = a / b;
        }

        // Calculator Double
        public static double Add (double a, double b) {
            double Add;
            return Add = a + b;
        }
        public static double Subtract (double a, double b) {
            double Subtract;
            return Subtract = a - b;
        }
        public static double Multiply (double a, double b) {
            double Subtract;
            return Subtract = a * b;
        }
        public static double Divide (double a, double b) {
            double Subtract;
            return Subtract = a / b;
        }

        public static void calculator() {
            try
            {
                // Int
                Console.Write("Nhap vao so nguyen a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap vao so nguyen b: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"a + b = {Add(a,b)}");
                Console.WriteLine($"a - b = {Subtract(a,b)}");
                Console.WriteLine($"a * b = {Multiply(a,b)}");
                Console.WriteLine($"a / b = {Divide(a,b)}");

                // Double
                Console.Write("Nhap vao so thuc a: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap vao so nguyen b: ");
                double d = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"a + b = {Add(c,d)}");
                Console.WriteLine($"a - b = {Subtract(c,d)}");
                Console.WriteLine($"a * b = {Multiply(c,d)}");
                Console.WriteLine($"a / b = {Divide(c,d)}");


            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    // Bai 8.2
    abstract class Shape
    {
        public double Hight { get; set; }
        public double Width { get; set; }
        public virtual void Assign (double a, double b) {
            Hight = a;
            Width = b;
        }
        public virtual double getArea() {
            return Hight * Width;
        }
        public abstract double checkRatio();

    }

    class Square: Shape
    {
        public override double getArea() {
            return Hight * Width;
        }
        public override double checkRatio() {
            return Hight / Width;
        }
    }

    class Triange: Shape
    {
        public override double getArea() {
            return Hight * Width / 2;
        }
        public override double checkRatio() {
            return  2 * Hight /Width;
        }
    }

    class Bai_8_2
    {
        public static void bai_8_2() {
            try
            {
                Shape shape1 = new Square();
                Shape shape2 = new Triange();

                Console.Write("Nhap chieu dai: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap chieu rong: ");
                double b = Convert.ToDouble(Console.ReadLine());

                shape1.Assign(a,b);
                shape2.Assign(a,b);

                Console.WriteLine($"Dien tich hinh vuong la: {shape1.getArea()} , Ty le hinh vuong la: {shape1.checkRatio()}");
                Console.WriteLine($"Dien tich hinh tam giac la: {shape2.getArea()} , Ty le hinh tam giac la: {shape2.checkRatio()}");

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    // Bai 8.3

    interface Smartphone
    {
        void Open();
        void Time_open();
        void Close();
        void Time_clode();
        void Time_used(double x, double y);
        void Joke();
    }

    class Iphone : Smartphone {
        public void Open() {
            Console.WriteLine("Nhan nut Home de mo khoa");
        }
        public void Time_open() {
            Console.Write("Ban mo dien thoai luc may gio (nhap mot so thuc tu 0 den 24): ");
        }

        public void Close() {
            Console.WriteLine("An nut nguon de tat man hinh");
        }

        public void Time_clode() {
            Console.Write("Ban tat dien thoai luc may gio (nhap mot so thuc tu 0 den 24): ");
        }
        public void Time_used(double x, double y) {
            Console.WriteLine($"Ban vua su dung dien thoai trong: {y -x} h");
        }
        public void Joke() {
            Console.WriteLine("Ban nen dung cuc gach !");
        }
   }

    class Samsung : Smartphone {
       public void Open() {
           Console.WriteLine("Double tab de mo khoa");
       }
       public void Time_open() {
            Console.Write("Ban mo dien thoai luc may gio (nhap mot so thuc tu 0 den 24): ");
        }
       public void Close() {
           Console.WriteLine("An nut nguon de tat man hinh");
       }
       public void Time_clode() {
            Console.Write("Ban tat dien thoai luc may gio (nhap mot so thuc tu 0 den 24): ");
        }
        public void Time_used(double x, double y) {
            Console.WriteLine($"Ban vua su dung dien thoai trong: {y -x} h");
        }
        public void Joke() {
            Console.WriteLine("Ban nen dung cuc gach !");
        }
   }

   public class Bai_8_3
   {
       public static void bai_8_3() {
            try
            {
                Console.WriteLine("Ban chon Iphone hay Samsung ?");
                Console.WriteLine("a. Iphone");
                Console.WriteLine("b. Samsung");
                Console.Write("Chi nhap a hoac b: ");
                string choose = Console.ReadLine();

                if (choose.ToLower().Trim() == "a") {

                    Iphone iphone = new Iphone();
                    iphone.Open();
                    iphone.Time_open();
                    double a = Convert.ToDouble(Console.ReadLine());

                    iphone.Close();
                    iphone.Time_clode();
                    double b = Convert.ToDouble(Console.ReadLine());

                    if (b - a >= 0) {
                        iphone.Time_used(a, b);
                    } else {
                        iphone.Joke();
                    }
                    

                } else if (choose.ToLower().Trim() == "b") {

                    Samsung samsung = new Samsung();
                    samsung.Open();
                    samsung.Time_open();
                    double a = Convert.ToDouble(Console.ReadLine());
                    
                    samsung.Close();
                    samsung.Time_clode();
                    double b = Convert.ToDouble(Console.ReadLine());

                    if (b -a >= 0) {
                        samsung.Time_used(a, b);
                    } else {
                        samsung.Joke();
                    }

                } else {
                    Console.WriteLine("Ban nen dung cuc gach !");
                    return;
                }
               
            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    // Bai 8.4
    class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
    class Inventory
    {
        List<Product> inventory = new List <Product>() {
            new Product() {ID = Guid.NewGuid().ToString() , Name = "Time", Category = "Newspaper", Quantity = 2800, Price = 8000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "NYtime", Category = "Newspaper", Quantity = 1800, Price = 9000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "Blockchain", Category = "Book", Quantity = 680, Price = 200000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "ElonMust", Category = "Book", Quantity = 400, Price = 150000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "WallStreet", Category = "Book", Quantity = 0, Price = 99000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "Iphone", Category = "Smartphone", Quantity = 800, Price = 20000000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "Samsung", Category = "Smartphone", Quantity = 300, Price = 19000000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "LG", Category = "Smartphone", Quantity = 0, Price = 15000000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "Daikin", Category = "AirCondition", Quantity = 50, Price = 12000000},
            new Product() {ID = Guid.NewGuid().ToString() , Name = "Panasonic", Category = "AirCondition", Quantity = 2, Price = 18000000},
        };
        
        // Them san pham
        public void Add_product () {
            try
            {
                Console.Write("Nhap ten san pham muon them: ");
                string name = Console.ReadLine().Trim();
                Console.Write("Nhap category: ");
                string category = Console.ReadLine().Trim();
                Console.Write("Nhap so luong (so nguyen): ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap gia (VND): ");
                double price = Convert.ToDouble(Console.ReadLine());
                this.inventory.Add(new Product() {ID = Guid.NewGuid().ToString() , Name = name, Category = category, Quantity = quantity, Price = price});

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Name Input
        public string name_input () {
            Console.WriteLine("Nhap ten san pham. Goi y: ");
            
            // Goi y san pham
            var group_name = from product in this.inventory group product by product.Name;
            foreach (var product in group_name) {
                Console.Write($"{product.Key}, ");
            }

            // Nhap san pham
            Console.Write("\nSan pham muon tim: ");
            string name = Console.ReadLine();

            return name;
        }

        // Name filter
        public void name_filter () {
            try
            {
                // Nhap ten san pham
                string name = this.name_input();

                // Filter
                var name_filter  = from product in this.inventory where product.Name.ToLower() == name.ToLower().Trim() select product;

                // Kiem tra ket qua filter
                while (name_filter.Count() == 0) {
                    Console.WriteLine($"Khong co san pham {name} trong Inventory");
                    Console.WriteLine($"Ban muon thu lai hay Them san pham moi");
                    Console.WriteLine($"a. Thu tim lai san pham");
                    Console.WriteLine($"b. Them san pham moi.");
                    Console.WriteLine("Thoat");
                    Console.Write("\nNhap a hoac b hoac ky tu bat ky de thoat: ");
                    string choose = Console.ReadLine();

                    if (choose.ToLower().Trim() == "a") {
                        name = this.name_input();
                    } else if (choose.ToLower().Trim() == "b") {
                        this.Add_product();
                        name = this.name_input();
                    } else {
                        return;
                    }
                }

                if (name_filter.Count() > 0) {
                    Console.WriteLine($"Ket qua ({name_filter.Count()})");
                    foreach (Product prd in name_filter) {
                        Console.WriteLine($"ID: {prd.ID}, Name: {prd.Name}, Catergory: {prd.Category}, Quantity: {prd.Quantity}, Price: {prd.Price} ");
                    }
                }

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        // Change Quantity
        public void Change_quantity () {
            try
            {
                name_filter();

                Console.Write("Ban muon thay doi so luong cho san pham co ID (chinh xac): ");
                string choose = Console.ReadLine().Trim();

                var quantity = from product in this.inventory where product.ID == choose select product;

                int count = 0;

                foreach (var product in quantity) {
                    Console.WriteLine($"So luong hien tai: {product.Quantity}");
                    count = product.Quantity;
                }

                Console.Write("So luong muon thay doi (nhap mot so nguyen duong neu la tang va so nguyen am neu la giam: ");
                int change = Convert.ToInt32(Console.ReadLine());

                while (count + change < 0 ) {
                    Console.WriteLine ("Ban da nhap so luong sai. So luong giam phai nho hon hoac bang so luong dang co");
                    Console.Write("So luong muon thay doi (nhap mot so nguyen duong neu la tang va so nguyen am neu la giam: ");
                    change = Convert.ToInt32(Console.ReadLine());
                }

                if (count + change > 0) {

                    int index = this.inventory.FindIndex(product => product.ID == choose);
                    this.inventory[index].Quantity = count + change;
                    Console.WriteLine($"So luong sau khi thay doi: {count + change}");
                    
                }

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Xoa san pham
        public void Remove_product () {
            try
            {
                name_filter();
            
                Console.Write("Dien ID chinh xac san pham ban muon xoa ID (chinh xac): ");
                string choose = Console.ReadLine().Trim();

                var remove = from product in this.inventory where product.ID == choose select product;

                Console.WriteLine("Ban co chac chan muon xoa ?  Tra loi (yes/no)");
                string verify = Console.ReadLine();
                if (verify.ToLower().Trim() == "yes") {

                    int index = this.inventory.FindIndex(product => product.ID == choose);
                    this.inventory.RemoveAt(index);
                    Console.WriteLine("San pham da duoc xoa khoi Inventory.");
                
                } else
                {
                    return;
                }

            } catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

        
        }

        public void bai_8_4() {
            // chon phuong thuc lam viec voi Inventory
            Console.WriteLine("Ban muon lam gi ?");
            Console.WriteLine("a. Them san pham");
            Console.WriteLine("b. Xoa san pham");
            Console.WriteLine("c. Thay doi san luong cua san pham");
            Console.WriteLine("d. Thoat");
            Console.Write("Nhap hoac a, b, c hoac d: ");
            string choose = Console.ReadLine();

            if (choose.ToLower().Trim() == "a") {
                this.Add_product();
            } else if (choose.ToLower().Trim() == "b") {
                this.Remove_product();
            } else if (choose.ToLower().Trim() == "c") {
                this.Change_quantity();
            } 
            else if (choose.ToLower().Trim() == "d") {
                return;
            }

            Console.WriteLine("Ban con muon lam gi nua ko ? ");
            Console.WriteLine("x. Co");
            Console.WriteLine("y. Thoat");
            Console.Write("Nhap x hoac y: ");
            string choose2 = Console.ReadLine();

            // Duy tri qua trinh lam viec vs Inventory
            while (choose2.ToLower().Trim() == "x") {

                Console.WriteLine("Ban muon lam gi ?");
                Console.WriteLine("a. Them san pham");
                Console.WriteLine("b. Xoa san pham");
                Console.WriteLine("c. Thay doi san luong cua san pham");
                Console.WriteLine("d. Thoat");
                Console.Write("Nhap hoac a, b, c hoac d: ");
                choose = Console.ReadLine();

                if (choose.ToLower().Trim() == "a") {
                    this.Add_product();
                } else if (choose.ToLower().Trim() == "b") {
                    this.Remove_product();
                } else if (choose.ToLower().Trim() == "c") {
                    this.Change_quantity();
                } else if (choose.ToLower().Trim() == "d") {
                    return;
                }

                Console.WriteLine("Ban con muon lam gi nua ko ? ");
                Console.WriteLine("x. Co");
                Console.WriteLine("y. Thoat");
                Console.Write("Nhap x hoac y: ");
                choose2 = Console.ReadLine();
            }
            // Thoat
            if (choose2.ToLower().Trim() != "x") {
                return;
            }
        }

    }

    // Bai 8.5
    class Account
    {
        public string Account_Number { get; set; }
        public double Balance { get; set; }
        public bool Status { get; set; }

        public virtual void Setup () {
            Console.WriteLine("Change it");
        }
        public virtual void Withdraw(double x) {
            Console.WriteLine("Change it");
        }
        public virtual void Deposit(double y) {
            Balance += y;
        }
    }

    class Saving_Acount : Account
    {
        public override void Setup () {
            Account_Number = "0910000000068";
            Balance = 20000000;
            Status = true;
        }
        public override void Withdraw(double x) {
            Console.WriteLine("Ban chua den thoi han de rut tien tu TK Tiet kiem nay");
        }

    }

    class Credit_Acount : Account
    {
        public override void Setup () {
            Account_Number = "0910000000079";
            Balance = 1000000;
            Status = true;
        }
        public override void Withdraw(double x) {
            Balance -= x;
        }

    }

    class Debit_Acount : Account
    {
        public override void Setup () {
            Account_Number = "0910000000014";
            Balance = 20000000;
            Status = true;
        }
        public override void Withdraw(double x) {
            Balance -= x;
        }

    }

    class Bai_8_5
    {
        // Khai bao 3 Tai khoan
        Saving_Acount sva = new Saving_Acount();
        Credit_Acount cda = new Credit_Acount();
        Debit_Acount dba = new Debit_Acount();
        
        // Setup Tai khoan
        public void Setup () {
            sva.Setup();
            cda.Setup();
            dba.Setup();
        }

        string status;
        string status2;
        string status3;

        // Hien thong tin Tai khoan
        public void Show_info () {
            Console.WriteLine("Thong tin cac Tai khoan Ngan hang cua ban: ");

            Console.WriteLine($"1.Saving Account:");
            Console.WriteLine($"+) Account Number: {sva.Account_Number}");
            Console.WriteLine($"+) Balance: {sva.Balance}");
            status = sva.Status ? "Open" : "Close";
            Console.WriteLine($"+) Status: {status}");

            Console.WriteLine($"2.Credit Account:");
            Console.WriteLine($"+) Account Number: {cda.Account_Number}");
            Console.WriteLine($"+) Balance: {cda.Balance}");
            status2 = cda.Status ? "Open" : "Close";
            Console.WriteLine($"+) Status: {status2}");

            Console.WriteLine($"3.Debit Account:");
            Console.WriteLine($"+) Account Number: {dba.Account_Number}");
            Console.WriteLine($"+) Balance: {dba.Balance}");
            status3 = dba.Status ? "Open" : "Close";
            Console.WriteLine($"+) Status: {status3}");
        }

        // Chon loai giao dich
        public string Transfer () {
            Console.WriteLine("Ban muon thuc hien giao dich gi ?");
            Console.WriteLine("a. Gui tien");
            Console.WriteLine("b. Rut tien");
            Console.WriteLine("c. Chuyen khoan");
            Console.WriteLine("d. Thoat");
            Console.Write("Chon a hoac b hoac c: ");
            string choose = Console.ReadLine().ToLower().Trim();
            return choose;

        }

        // Chon Tai khoan giao dich
        public string Select_account () {
            Console.WriteLine("Chon tai khoan: ");
            Console.WriteLine("1. Saving Account");
            Console.WriteLine("2. Credit Account");
            Console.WriteLine("3. Debit Account");
            Console.WriteLine("4. Quay lai");
            Console.Write("Nhap 1 hoac 2 hoac 3, 4: ");
            string select = Console.ReadLine().Trim();
            return select;
        }
        string select;

        // Chon Tai khoan thu huong
        public string Receive_account () {
            Console.WriteLine("Chon tai khoan thu huong: ");
            Console.WriteLine("1. Saving Account");
            Console.WriteLine("2. Credit Account");
            Console.WriteLine("3. Debit Account");
            Console.WriteLine("4. Tai khoan khac");
            Console.Write("Nhap 1 hoac 2 hoac 3, 4: ");
            string receive = Console.ReadLine().Trim();
            return receive;
        }
        string receive;
        
        // So tien giao dich
        public double Amount ()
        {
            Console.Write("Nhap so tien giao dich: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            return amount;
        }
        double amount;

        // Thong bao giao dich thanh cong
        public void Success()
        {
            Console.WriteLine("Giao dich thanh cong");
        }
        // Thong bao giao dich that bai
        public void Fail()
        {
            Console.WriteLine("Giao dich khong thanh cong");
        }

        // Gui tien
        public void Deposit_transfer () {
            select = Select_account();

            if (select != "4") {
                amount = Amount();
            }

            if (select == "1" ) {
                sva.Deposit(amount);
                Success(); 
            } else if (select == "2") {
                cda.Deposit(amount);
                Success();
            } else if (select == "3") {
                dba.Deposit(amount);
                Success();
            } else {
                return;
            }
        }

        // Rut tien
        public void Withdraw_transfer () {
            select = Select_account();

            if (select != "4") {
                amount = Amount();
                if (select == "2" && cda.Balance - amount < 50000) {
                    Console.WriteLine("Tai khoan ko du so tien de thuc hien giao dich nay. ");
                    return;
                } else if (select == "3" && dba.Balance - amount < 50000) {
                    Console.WriteLine("Tai khoan ko du so tien de thuc hien giao dich nay. ");
                    return;
                }

            }
            
            if (select == "1" ) {
                sva.Withdraw(amount);
                Fail(); 
            } else if (select == "2") {
                cda.Withdraw(amount);
                Success();
            } else if (select == "3") {
                dba.Withdraw(amount);
                Success();
            } else {
                return;
            }
        }

        // Chuyen tien
        public void Transfer_transfer () {
            select = Select_account();

            if (select != "4") {
                receive = Receive_account();
                amount = Amount();
                
                if (select == "2" && cda.Balance - amount < 50000) {
                    Console.WriteLine("Tai khoan ko du so tien de thuc hien giao dich nay. ");
                    return;
                } else if (select == "3" && dba.Balance - amount < 50000) {
                    Console.WriteLine("Tai khoan ko du so tien de thuc hien giao dich nay. ");
                    return;
                }
            }
            
            if (select == "1" && receive == "2") {
                sva.Withdraw(amount);
                Fail();
            } else if (select == "1" && receive == "3") {
                sva.Withdraw(amount);
                Fail();
            } else if (select == "1" && receive == "4") {
                sva.Withdraw(amount);
                Fail();
            } else if (select == "2" && receive == "1") {
                cda.Withdraw(amount);
                sva.Deposit(amount);
                Success();
            } else if (select == "2" && receive == "3") {
                cda.Withdraw(amount);
                dba.Deposit(amount);
                Success();
            } else if (select == "2" && receive == "4") {
                cda.Withdraw(amount);
                Success();
            } else if (select == "3" && receive == "1") {
                dba.Withdraw(amount);
                sva.Deposit(amount);
                Success();
            } else if (select == "3" && receive == "2") {
                dba.Withdraw(amount);
                cda.Deposit(amount);
                Success();
            } else if (select == "3" && receive == "4") {
                dba.Withdraw(amount);
                Success();
            } else {
                Fail();
                return;
            }
        }

        // Tiep tuc giao dich
        public string Keep ()
        {
            Console.WriteLine("Ban co muon thuc hien giao dich nua khong ?");
            Console.WriteLine("x. Co");
            Console.WriteLine("y. Thoat");
            Console.Write("Nhap a hoac b: ");
            string keep = Console.ReadLine().ToLower().Trim();
            return keep;
        }

        public void bai_8_5() {
            try
            {
                Setup();

                Show_info();

                string choose = Transfer();
                
                // Gui tien
                if (choose == "a") {
                    Deposit_transfer();
                // Rut tien
                } else if (choose == "b") {
                    Withdraw_transfer();
                // chuyen khoan
                } else if (choose == "c") {
                    Transfer_transfer();
                } else {
                    return;
                }

                // Tiep tuc giao dich
                string keep = Keep();

                while (keep == "x") {

                    Show_info();    

                    choose = Transfer();

                    // Gui tien
                    if (choose == "a") {
                        Deposit_transfer();
                    // Rut tien
                    } else if (choose == "b") {
                        Withdraw_transfer();
                    // chuyen khoan
                    } else if (choose == "c") {
                        Transfer_transfer();
                    }

                }

                if (keep != "x") {
                    Console.WriteLine("Xin cam on !");
                    return;
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
            // Bai 8.1
            Console.WriteLine("Bai 8.1 Calculator static polymorphism");
            Bai_8_1.calculator();

            // Bai 8.2
            Console.WriteLine("Bai 8.2 Dynamic polymorphism");
            Bai_8_2.bai_8_2();

            // Bai 8.3
            Console.WriteLine("Bai 8.3 interface");
            Bai_8_3.bai_8_3();

            // Bai 8.4
            Console.WriteLine("Bai 8.4 Product Inventory");
            Inventory i1 = new Inventory();
            i1.bai_8_4();

            // Bai 8.5
            Console.WriteLine("Bai 8.5 Bank Account");
            Bai_8_5 b85 = new Bai_8_5();
            b85.bai_8_5();
        }
    }
}
