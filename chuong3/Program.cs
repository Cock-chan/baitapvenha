using System;

namespace chuong3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for(x=1;x<10;x++) 
            { 
                System.Console.WriteLine("so : {0,03}",x);
                //doan code dung vong lap de in ra cac so tu 1 den 9 nho hon 10 yheo trinh tu tang dan
            }
            //cau2
            for(int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(" {0} ", i);
                //thieu  dau ngoac nhon o cau lech for
                //cau lech for thi nen dung {0} o dong writeline vi no chi nhan gia tri =0 de chay chuong trinh
            }
            //cau 3
            double mydouble;
            double mydecimal;//chuyen tu decimal thanh double
            mydecimal = 3.14;
            mydouble = 3.14;
            Console.WriteLine("{0}",mydouble);
            Console.WriteLine("{0}", mydecimal);
            //cau4
            int value = 100_000_000;// nhap 1 gia tri bat ki lon hon 100
            if(value > 100)
            {
                System.Console.WriteLine("number is greater than 100");
            }
            //cau5
            Console.WriteLine("*         $$$$$$             *");
            Console.WriteLine("**        $$$$$              **");
            Console.WriteLine("***       $$$$              ***");
            Console.WriteLine("****      $$$              *****");
            Console.WriteLine("*****     $$              *******");
            Console.WriteLine("******    $              **********");
            //CAU6
            Console.WriteLine("         1    ");
            Console.WriteLine("        232    ");
            Console.WriteLine("       34534    ");
            Console.WriteLine("      4567654             ");
            Console.WriteLine("     567898765            ");
            Console.WriteLine("    67890109876");
            Console.WriteLine("   7890123210987         ");
            Console.WriteLine("  890123454321098");
            Console.WriteLine(" 90123456765432109");
            Console.WriteLine("0123456789876543210");
            //cau7
            for(int i = 0;i < 10; i++)
            {
                char kitu=(char)('0'+i);
                Console.WriteLine($"'{kitu}': {(int)kitu}");
            }
            for(int i = 0; i < 26; i++)
            {
                char kitu2=(char)('a'+i);
                Console.WriteLine($"'{kitu2}': {(int)kitu2}");

            }
            //cau 8 
            
            Console.WriteLine(" giai phuong trinh ax + b = 0");
            Console.WriteLine(" nhap gia tri a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri b");
            double b = double.Parse(Console.ReadLine());    
            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine(" phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("phuong trinh vo nghiem ");
                }
            }
            else
            {
               double x1 = 0;
                 x1 = -b / a;
                Console.WriteLine(" phuong trinh co nghiem x={0}",x1);
            }
            Console.ReadLine();

            //cau9
            Console.WriteLine("giai phuong trinh a2x^2 +b2x +c2 = 0");
            Console.WriteLine(" nhap gia tri a ");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" nhap gia tri b ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" nhap giai tri c ");
            double c2 = double.Parse(Console.ReadLine());
            double X2 = b2 * b2 - 4 * a2 * c2;
            if(X2<0)
            {
                Console.WriteLine(" phuong trinh vo nghiem");

            }
            else if(X2 == 0)
            {
                double x3 = -b / (2 * a2);
                Console.WriteLine(" phuong trinh co nghiem kep");
            }
            else
            {
                double x4  = (-b2 + Math.Sqrt(x)) /(2* a2);
                double x5 = (-b2 - Math.Sqrt(x)) /(2* a2);
                Console.WriteLine("phuong trinh co 2 nghiem phan biet");
                Console.WriteLine("x4 = ", x4);
                Console.WriteLine("x5 = ", x5);
            }
            //cau10
            Console.WriteLine("tinh chu vi va dien tich hinh binh hanh");
            Console.WriteLine("1. duong tron");
            Console.WriteLine("2. hinh chu nhat");
            Console.WriteLine("3. hinh thang");
            Console.WriteLine("4. tam giac");
            Console.WriteLine("----------------------------------");
            Console.Write("nhap lua chon cua ban tu (1-4):");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateCircle();
                    break;
                case 2:
                    CalculateRectangle();
                    break;
                case 3:
                    CalculateTrapezoid();
                    break;
                case 4:
                    CalculateTriangle();
                    break;
                default:
                    Console.WriteLine("lua chon khong hop le");
                    break;
            }

            Console.ReadLine();
        }

        static void CalculateCircle()
        {
            Console.Write("Nhap ban kinh duong tron");
            double radius = double.Parse(Console.ReadLine());

            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("chu vi duong tron la :", +circumference);
            Console.WriteLine("nhap dien tich duong tron :", +area);
        }

        static void CalculateRectangle()
        {
            Console.Write("Nhap chieu dai hinh chu nhat la :");
            double length = double.Parse(Console.ReadLine());

            Console.Write("nhap chieu rong hinh chu nhat la :");
            double width = double.Parse(Console.ReadLine());

            double perimeter = 2 * (length + width);
            double area = length * width;

            Console.WriteLine("Chu vi hinh chu nhat la :", perimeter);
            Console.WriteLine("dien tich hinh chu nhat la :", +area);
        }

        static void CalculateTrapezoid()
        {
            Console.Write("nhap canh day hinh thang");
            double base1 = double.Parse(Console.ReadLine());

            Console.Write("nhap do dia hinh thang:");
            double base2 = double.Parse(Console.ReadLine());

            Console.Write("nhap chieu cao thinh thang");
            double height = double.Parse(Console.ReadLine());

            double perimeter = base1 + base2 + 2 * Math.Sqrt(Math.Pow((base1 - base2) / 2, 2) + height * height);
            double area = (base1 + base2) * height / 2;

            Console.WriteLine("Chu vi hinh thang la ", +perimeter);
            Console.WriteLine("dien tich cua hinh thang la :" + area);
        }

        static void CalculateTriangle()
        {
            Console.Write("nhap do dai canh thu nhat cua tam giac");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("nhap do dai cua tam giac ");
    

        }   


    }
}
