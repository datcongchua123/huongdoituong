using huongdoituong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HuongDoiTuong
{
    internal class HocSinh1 : Nguoi 
    {
        //Khai bao thuoc tinh
        private int MaHS;
        string TenHS;
        int namSinh;
        string DiaChi;
        double diemToan, diemVan, diemAnh, DTB;
        //Xay dung ham Constructor 2
       public HocSinh1()
        {

        }
        public HocSinh1(int ma, string ten, int ns, string diaChi)
        {
            MaHS = ma;
            TenHS = ten;
            namSinh = ns;
            DiaChi = diaChi;
        }
        Nguoi n = new Nguoi();
        public void NhapHS()
        {
            Console.Write("Nhap ma HS: ");
            MaHS = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap ten hoc sinh: ");
            TenHS = Console.ReadLine();
            n.NhapTT();
            Console.Write("Nhap nam sinh: ");
            namSinh = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            diemVan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh: ");
            diemAnh = Convert.ToDouble(Console.ReadLine());
        }
        // Viet ham tinh diem trung binh
        //NEu viet ham ghi de thi can them tu khoa virtual public virtual sniDouble TinhDTB()
    public Double TinhDTB()
        {
            DTB = Math.Round((diemAnh + diemToan + diemVan) / 3, 1);
            return DTB;
        }
        public void XuatHS()
        {
            Console.WriteLine("Thong tin sinh vien la  ");
            
            Console.WriteLine("Ma HS | Ten HS | Nam Sinh | Dia Chi |  DTB");
           
            Console.WriteLine(MaHS + "       " + TenHS + "        " + namSinh + "       "+ DiaChi + "       "+DTB);

            n.XuatTT();
        }
        //Viet ham tinh trung binh


    }
}
