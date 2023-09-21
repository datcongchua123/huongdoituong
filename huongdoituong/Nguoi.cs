using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class Nguoi
    {
        public int SDT { get; set; }
        public String Gioitinh { get; set; }
        public Nguoi() { }
        public Nguoi(int sDT, string gioitinh)
        {
            SDT = sDT;
            Gioitinh = gioitinh;
        }
        public void NhapTT()
        {
            Console.Write("Nhap SDT :");
            SDT = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gioi tinh :");
            Gioitinh= Console.ReadLine();
        }
        public void XuatTT()
        {
            Console.WriteLine("Sdt :" + SDT);
            Console.WriteLine("Gioi tinh :"+ Gioitinh);
        }
    }
}
