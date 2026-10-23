using System;

namespace CSLab01
{
class Program
{
static void Main(string[] args)
{
while (true)
{
Console.Clear();
Console.WriteLine("================ LAB 01 - CONSOLE ================");
Console.WriteLine("1. Bai tap 1: Nhap - Xuat ten");
Console.WriteLine("2. Bai tap 2: Giai phuong trinh bac 1");
Console.WriteLine("3. Bai tap 3: Thao tac voi mang (Tong, Min, Max)");
Console.WriteLine("4. Bai tap 4: Xu ly chuoi (Ho ten)");
Console.WriteLine("0. Thoat");
Console.Write("Chon bai tap (0-4): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    BaiTap1();
                    break;
                case "2":
                    BaiTap2();
                    break;
                case "3":
                    BaiTap3();
                    break;
                case "4":
                    BaiTap4();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            Console.WriteLine("\nNhan phím bat ky de tiep tuc...");
            Console.ReadKey();
        }
    }

    static void BaiTap1()
    {
        Console.WriteLine("--- BAI TAP 1: NHAP - XUAT ---");
        Console.Write("Nhap vao ten ban: ");
        string ten = Console.ReadLine();
        Console.WriteLine("Xin chao " + ten);
    }

    static void BaiTap2()
    {
        Console.WriteLine("--- BAI TAP 2: GIAI PHUONG TRINH BAC 1 (ax + b = 0) ---");
        try
        {
            Console.Write("Nhap tham so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap tham so b: ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem x = " + x.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi nhap lieu: " + ex.Message);
        }
    }

    static void BaiTap3()
    {
        Console.WriteLine("--- BAI TAP 3: THAO TAC VOI MANG ---");
        try
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i.ToString() + ": ");
                mang[i] = int.Parse(Console.ReadLine());
            }

            int tong = 0;
            int max = mang.Length > 0 ? mang[0] : 0;
            int min = mang.Length > 0 ? mang[0] : 0;

            for (int i = 0; i < n; i++)
            {
                tong += mang[i];
                if (mang[i] > max) max = mang[i];
                if (mang[i] < min) min = mang[i];
            }

            Console.WriteLine("Tong cua mang la: " + tong.ToString());
            Console.WriteLine("So lon nhat trong mang la: " + max.ToString());
            Console.WriteLine("So nho nhat trong mang la: " + min.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
    }

    static void BaiTap4()
    {
        Console.WriteLine("--- BAI TAP 4: XU LY CHUOI ---");
        Console.WriteLine("1. Nhap ho, ten lot, ten va xuat day du");
        Console.WriteLine("2. Tach ho ten day du thanh cac phan");
        Console.WriteLine("3. Chuan hoa ho ten");
        Console.Write("Chon y (1-3): ");
        string subChoice = Console.ReadLine();

        if (subChoice == "1")
        {
            Console.Write("Nhap ho: ");
            string ho = Console.ReadLine();
            Console.Write("Nhap ten lot: ");
            string tenlot = Console.ReadLine();
            Console.Write("Nhap ten: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Ho va ten day du: {0} {1} {2}", ho, tenlot, ten);
        }
        else if (subChoice == "2")
        {
            Console.Write("Nhap ho ten day du: ");
            string fullname = Console.ReadLine();
            string[] parts = fullname.Split(new string[] { " " }, StringSplitOptions.None);
            if (parts.Length >= 3)
            {
                Console.WriteLine("Ho: {0}, ten lot: {1}, ten: {2}", parts[0], parts[1], parts[2]);
            }
            else
            {
                Console.WriteLine("Chuoi nhap vao khong du 3 phan (ho, ten lot, ten).");
            }
        }
        else if (subChoice == "3")
        {
            Console.Write("Nhap ho ten (khong theo chuan): ");
            string fullname = Console.ReadLine();
            string[] parts = fullname.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 3)
            {
                string ho = parts[0].Substring(0, 1).ToUpper() + parts[0].Substring(1).ToLower();
                string tenlot = parts[1].Substring(0, 1).ToUpper() + parts[1].Substring(1).ToLower();
                string ten = parts[2].Substring(0, 1).ToUpper() + parts[2].Substring(1).ToLower();
                Console.WriteLine("Ten theo dung chuan la: {0} {1} {2}", ho, tenlot, ten);
            }
            else
            {
                Console.WriteLine("Vui long nhap it nhat 3 tu (ho, ten lot, ten).");
            }
        }
        else
        {
            Console.WriteLine("Lua chon khong hop le.");
        }
    }
}