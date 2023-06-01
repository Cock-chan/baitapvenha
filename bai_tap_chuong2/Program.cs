using System;

namespace bai_tap_chuong2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cau 3
            int x, y;
            for (x = 0; x < 10; x++, Console.Write(" \n ")) ;
            for(y = 0; y < 10; y++, Console.Write(" {0} ",y)) ;
            //chuong trinh su dung ham for de in ra cac gia tri nho hon 10 the hinh thu tang dan trong vong lap
            //cau 5
            Console.WriteLine(" xin chao ");
            Console.WriteLine(" tam biet ");
            //cau 6
            Console.WriteLine(" xin chao ");
            Console.WriteLine(" tam biet ");
            //cau 7 
            Console.WriteLine("\t\t\t ram thang rieng ");
            Console.WriteLine("ram xuan long long trang soi,");
            Console.WriteLine("song xuan nuoc lan mau tran them xuan ");
            Console.WriteLine("giua dong ban bac viec quan ");
            Console.WriteLine("\t khuya ve bat ngat trang ngam day thuyen");
            Console.WriteLine("\t\t\t\t Ho Chi Minh");
            //cau2 
            int bankinh = 4;
            const double pi = 3.14159;
            double chuvi, dientich;
            dientich = pi * bankinh * bankinh;
            chuvi = 2 * pi * bankinh;
            Console.WriteLine("ban kinh = {0}, pi = {1}", bankinh, pi);
            Console.WriteLine("dien tich ={0} ", dientich);
            Console.WriteLine("chu vi ={0} ", chuvi);
            //cau 2 su dung cac phep tinh nham bat chuong trinh tinh va in ra ket qua 
            //chuong 3

        }
    }
}
