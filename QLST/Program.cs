using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class Program
    {
        public static List<Ve> dsve = new List<Ve>();
        public static List<ThucAn> dsdt = new List<ThucAn>();
        public static List<DongVat> dsdv = new List<DongVat>();
        public static List<KhachXem> dskx = new List<KhachXem>();
        public static List<PhongBan> dspb = new List<PhongBan>();
        public static List<KhauPhan> dskp = new List<KhauPhan>();
        public static List<NhanVien> dsnv = new List<NhanVien>();
        public static List<ChuongNuoi> dscn = new List<ChuongNuoi>();
        public static List<CongTyBanVe> dsct = new List<CongTyBanVe>();
        public static List<LoaiDongVat> dsldv = new List<LoaiDongVat>();
        public static List<DVChuongNuoi> dsdvcn = new List<DVChuongNuoi>();

        public static void TaoDSDongVat()
        {
        }

        public static void TaoDSLoaiDongVat()
        {
        }

        public static void TaoDSChuongNuoi()
        {
        }

        public static void TaoDSDVChuongNuoi()
        {
        }

        public static void TaoDSKhauPhan()
        {
        }

        public static void TaoDSPhongBan()
        {
            dspb.Add(new PhongBan("PB1", "Phong CSKH", "Cua So Thu"));
            dspb.Add(new PhongBan("PB2", "Phong Ban Ve", "Cua So Thu"));
            dspb.Add(new PhongBan("PB3", "Phong Bao Ve", "Trung Tam So Thu"));
            dspb.Add(new PhongBan("PB4", "Phong Thuc An", "Phia Dong So Thu"));
            dspb.Add(new PhongBan("PB5", "Phong QLNV", "Phia Dong So Thu"));
        }

        public static void TaoDSThucAn()
        {
            dsdt.Add(new ThucAn("THIT01", "THIT SONG"));
            dsdt.Add(new ThucAn("THITO2", "THIT CHIN"));
            dsdt.Add(new ThucAn("THUCVAT01", "CO"));
            dsdt.Add(new ThucAn("THUCVAT02", "TRAI CAY"));
        }

        public static void TaoDSCongTyBanVe()
        {
            dsct.Add(new CongTyBanVe("CTY01", "Cong ty 01", 1000, "1/1/2010"));
            dsct.Add(new CongTyBanVe("CTY02", "Cong ty 02", 1500, "15/1/2001"));
            dsct.Add(new CongTyBanVe("CTY03", "Cong ty 03", 2000, "16/2/2019"));
            dsct.Add(new CongTyBanVe("CTY04", "Cong ty 04", 2500, "5/5/2006"));
        }

        public static void TaoDSNhanVien()
        {
            dsnv.Add(new NhanVien("234345", "Nguyen Van Anh", "PB1", "Nhan Vien Ve Sinh"));
            dsnv.Add(new NhanVien("234456", "Tran Thi Bao", "PB1", "Nhan Vien Cham Soc Thu An Thit"));
            dsnv.Add(new NhanVien("232325", "To Van Van", "PB2", "Nhan Vien Cham Soc Thu An Co"));
            dsnv.Add(new NhanVien("223456", "Cao Thi Duyen", "PB2", "Nhan Vien Bao Ve"));
            dsnv.Add(new NhanVien("256784", "Vo Van Toan", "PB3", "Nhan Vien Bao Ve"));
            dsnv.Add(new NhanVien("232453", "Dinh Quoc Khanh", "PB3", "Nhan Vien Cham Khach Hang"));
            dsnv.Add(new NhanVien("232234", "Nguyen Minh Lan", "PB4", "Nhan Vien Bao Ve"));
            dsnv.Add(new NhanVien("256234", "Le Van Minh", "PB4", "Nhan Vien Ban Ve"));
            dsnv.Add(new NhanVien("256254", "Le Van Kiet", "PB4", "Nhan Vien Trong Xe"));
        }

        public static void TaoDSVe()
        {
            dsve.Add(new Ve("V1", "Kh01", "234345", "1/1/2020"));
            dsve.Add(new Ve("V2", "Kh02", "256254", "2/1/2020"));
            dsve.Add(new Ve("V3", "Kh03", "232234", "5/1/2020"));
            dsve.Add(new Ve("V4", "Kh04,Kh02", "234456", "1/4/2020"));
            dsve.Add(new Ve("V5", "Kh05", "234456", "14/1/2020"));
        }

        public static void TaoDSKhachXem()
        {
            dskx.Add(new KhachXem("Kh01","Nguyen Van An", "V1", "1/1/2020"));
            dskx.Add(new KhachXem("Kh02","Tran Van Cao", "V2", "2/1/2020"));
            dskx.Add(new KhachXem("Kh03","Cao Thi Linh", "V3", "5/1/2020"));
            dskx.Add(new KhachXem("Kh04","Nguyen Van Tung", "V4", "1/4/2020"));
            dskx.Add(new KhachXem("Kh05","Dao Thi Xuan", "V5", "1/1/2020"));
            dskx.Add(new KhachXem("Kh02", "Tran Van Cao", "V4", "31/1/2020"));
            dskx.Add(new KhachXem("Kh02", "Tran Van Cao", "V5", "1/4/2020"));
            dskx.Add(new KhachXem("Kh04", "Nguyen Van Tung", "V4", "1/4/2020"));
            dskx.Add(new KhachXem("Kh02", "Tran Van Cao", "V2", "1/5/2020"));
            dskx.Add(new KhachXem("Kh03", "Cao Thi Linh", "V3", "10/5/2020"));
            dskx.Add(new KhachXem("Kh02", "Tran Van Cao", "V2", "22/5/2020"));
        }
        // In Thong tin nhan vien?
        public static void cau1()
        {
            var ds_nv =
               from nv in dsnv
               select nv;
            Console.WriteLine("Cau 1:");
            foreach (var nv in ds_nv)
            {
                Console.WriteLine("Ma nhan vien: {0}", nv.MaNhanVien);
                Console.WriteLine("Ten nhan vien: {0}", nv.TenNhanVien);
                Console.WriteLine("Chuc Vu: {0}", nv.ChucVu);
                Console.WriteLine("Ma Phong Quan Ly: {0}", nv.MaPhongBan);
                Console.WriteLine();
            }
        }
        
        //2. cho biet so nhan vien cua tung phuong? 
        public static void cau2()
        {
            var sonhanvien =
                from x in dsnv
                group x by x.MaPhongBan into ss
                select new
                {
                    mk = ss.Key,
                    mv = ss.Count()
                };


            Console.WriteLine("Cau 2:");
            foreach (var nv in sonhanvien)
            {
                Console.WriteLine("So nhan vien cua phong {0} la {1}", nv.mk,nv.mv);
                Console.WriteLine();
            }
        }
        // 3. Sap xep so luong ve duoc mua giam
        public static void cau3()
        {
            var sapXepve =
              from v in dsct
              orderby v.SoLuongVeMua descending
              select v;
            Console.WriteLine("cau 3");
            Console.WriteLine("sap xep so ve cac cong ty mua giam dan");
            foreach (var sapxep in sapXepve)
            {
                Console.WriteLine(" cong ty {0} mua {1} ve.", sapxep.TenCongTy,sapxep.SoLuongVeMua);
            }
        }
        // 4. in thong tin nhan vien bao ve
        public static void cau4()
        {
            var ds_nv =
                from nv in dsnv
                where nv.ChucVu == "Nhan Vien Bao Ve"
                select nv;
            Console.WriteLine("Cau 4:");
            foreach (var nv in ds_nv)
            {
                Console.WriteLine("Ma nhan vien: {0}", nv.MaNhanVien);
                Console.WriteLine("Ten nhan vien: {0}", nv.TenNhanVien);
                Console.WriteLine("Chuc Vu: {0}", nv.ChucVu);
                Console.WriteLine("Ma Phong Quan Ly: {0}", nv.MaPhongBan);
                Console.WriteLine();
            }
        }
        //5. in thong tin nhan vien ban duoc nhieu ve nhat
        public static void cau5()
        {
            var NVMax =
                from ss in dsve
                group ss by ss.MaNhanVienBanVe into k
                select new { NhanVien = k.Key, sove = (from ss in k select ss.MaVe).Count() };
            var MAX =
               ( from ss in NVMax join k in dsnv  on ss.NhanVien equals k.MaNhanVien
                where ss.sove == NVMax.Max(sove=>sove.sove)
                select ss ).OrderBy(f =>f.sove);
            foreach (var ss in MAX)
            { foreach(var t in dsnv)
                {
                    if(ss.NhanVien==t.MaNhanVien)
                    {
                        Console.WriteLine("Ma Nhan Vien: {0}", ss.NhanVien);
                        Console.WriteLine("Ten Nhan Vien: {0}", t.TenNhanVien);
                        Console.WriteLine("So ve: {0}", ss.sove);
                    }
                }
                
            }
        }
        //6.Phong ban co nhieu nhan vien nhat
        public static void cau6()
        {
            var PBNVMax =
               from ss in dsnv
               group ss by ss.MaPhongBan into k
               select new {PB= k.Key, sonv = (from ss in k select ss.MaNhanVien).Count() };
            var MAX =
               (from ss in PBNVMax
                join k in dspb on ss.PB equals k.MaPhongBan
                where ss.sonv == PBNVMax.Max(sonv=> sonv.sonv)
                select ss).OrderBy(f => f.sonv);
            Console.WriteLine("cau 6: ");
            Console.WriteLine("phong ban co nhieu nhan vien nhat:");
            foreach (var ss in MAX)
            {
                foreach (var g in dspb)
                {
                    if (ss.PB == g.MaPhongBan)
                    {
                        Console.WriteLine("Ma phong ban: {0}", ss.PB);
                        Console.WriteLine("Ten phong ban: {0}", g.TenPhongBan);
                        Console.WriteLine("So ve: {0}", ss.sonv);
                    }
                }
            }
        }
        //7.Khach den xem nhieu nhat
        public static void cau7()
        {
            var KHMAx=
              from ss in dskx
              group ss by ss.MaKhach into k
              select new { MaKhach = k.Key, sove = (from ss in k select ss.MaVe).Count() };
            var MAX =
               (from ss in KHMAx
                join k in dskx on ss.MaKhach equals k.MaKhach
                where ss.sove == KHMAx.Max(sove => sove.sove)
                select ss).OrderBy(f => f.sove);
            Console.WriteLine("cau 7: ");
            Console.WriteLine("Khach hang mau nhieu ve nhat:");
            foreach (var ss in MAX)
            {
                foreach (var l in dskx)
                {
                    if (ss.MaKhach == l.MaKhach)
                    {
                        Console.WriteLine("Ma Khach: {0}", ss.MaKhach);
                        Console.WriteLine("Ten Khach: {0} ", l.tenkhach);
                        Console.WriteLine("So ve: {0}", ss.sove);
                        break;
                    }
                }
                break;
            }
        }
        //8. Cho biet phong nam tai phia dong so thu
        public static void cau8()
        {
            var NVQL =
               from ss in dspb
               select ss;

            Console.WriteLine("cau 8: ");
            Console.WriteLine("Cho biet phong nam tai phia dong so thu :");
            foreach (var ss in dspb)
            {
                if (ss.DiaDiem== "Phia Dong So Thu")
                {
                    Console.WriteLine("Ma PB: {0}", ss.MaPhongBan);
                    Console.WriteLine("Ten Phong: {0} ",ss.TenPhongBan);
                }
            }
        }
        //9.Tong so ve cong ty da mua de ban 
        public static void cau9()
        {
            var chiphi =
              from v in dsct
              select new
              {
                  sove=v.SoLuongVeMua
              };
            double sum = chiphi.Sum(t => t.sove);
            Console.WriteLine("cau 9");
            Console.WriteLine(" Tong ve la: {0}", sum);
        }
        //10. In thong tin cong ty mua tu 2000 ve
        public static void cau10()
        {
            var chiphi =
              from v in dsct
              select v;

            Console.WriteLine("cau 10");
            foreach (var ss in chiphi)
            {
                    if (ss.SoLuongVeMua >=2000)
                    {
                        Console.WriteLine("Ma cong ty: {0}", ss.MaCongTy);
                        Console.WriteLine("Ten cong ty: {0}", ss.TenCongTy);
                        Console.WriteLine("So ve: {0}", ss.SoLuongVeMua);
                    Console.WriteLine("Ngay mua: {0}", ss.NgayMua);
                    }
            }
        }
        private static void Main(string[] args)
        {
            TaoDSChuongNuoi();
            TaoDSDongVat();
            TaoDSKhauPhan();
            TaoDSLoaiDongVat();
            TaoDSDVChuongNuoi();
            TaoDSCongTyBanVe();
            TaoDSKhachXem();
            TaoDSNhanVien();
            TaoDSPhongBan();
            TaoDSThucAn();
            TaoDSVe();
            cau1();
            cau2();
            cau3();
            cau4();
            cau5();
            cau6();
            cau7();
            cau8();
            cau9();
            cau10();
        }
    }
}