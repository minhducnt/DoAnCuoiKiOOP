using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    public class Program
    {
        public static RandomDate date = new RandomDate();
        public static List<Ve> ve = new List<Ve>();
        public static List<ThucAn> dt = new List<ThucAn>();
        public static List<DongVat> dv = new List<DongVat>();
        public static List<KhachXem> kx = new List<KhachXem>();
        public static List<PhongBan> pb = new List<PhongBan>();
        public static List<KhauPhan> kp = new List<KhauPhan>();
        public static List<NhanVien> nv = new List<NhanVien>();
        public static List<ChuongNuoi> cn = new List<ChuongNuoi>();
        public static List<CongTyBanVe> ct = new List<CongTyBanVe>();
        public static List<LoaiDongVat> ldv = new List<LoaiDongVat>();
        public static List<DVChuongNuoi> dvcn = new List<DVChuongNuoi>();

        public static void TaoDSDongVat()
        {
            dv.Add(new DongVat("Sư Tử", "01", "anthit"));
            dv.Add(new DongVat("Hổ", "02", "anthit"));
            dv.Add(new DongVat("Voi", "03", "anco"));
            dv.Add(new DongVat("Hươu Cao Cổ", "04", "anco"));
            dv.Add(new DongVat("Linh Dương", "05", "anco"));
            dv.Add(new DongVat("Thằn Lằn", "06", "anthit"));
            dv.Add(new DongVat("Đười Ươi", "07", "anco"));
            dv.Add(new DongVat("Khỉ", "08", "anco"));
            dv.Add(new DongVat("Gấu", "09", "anthit"));
            dv.Add(new DongVat("Khỉ Sóc", "10", "anco"));
            dv.Add(new DongVat("Hà Mã", "11", "anthit"));
            dv.Add(new DongVat("Ngựa Vằn", "12", "anco"));
            dv.Add(new DongVat("Gấu Ngựa", "13", "anthit"));
            dv.Add(new DongVat("Tê Giác", "14", "anco"));
        }

        public static void TaoDSLoaiDongVat()
        {
            ldv.Add(new LoaiDongVat("Bò Sát", "bosat"));
            ldv.Add(new LoaiDongVat("Chim", "chim"));
            ldv.Add(new LoaiDongVat("Lưỡng Cư", "luongcu"));
            ldv.Add(new LoaiDongVat("Côn Trùng", "contrung"));
            ldv.Add(new LoaiDongVat("Cá", "ca"));
            ldv.Add(new LoaiDongVat("Động Vật Ăn Thịt", "anthit"));
            ldv.Add(new LoaiDongVat("Động Vật Ăn Cỏ", "anco"));
            ldv.Add(new LoaiDongVat("Động Vật Không Xương", "khongxuong"));
        }

        public static void TaoDSChuongNuoi()
        {
            cn.Add(new ChuongNuoi("A", "01"));
            cn.Add(new ChuongNuoi("B", "02"));
            cn.Add(new ChuongNuoi("C", "03"));
            cn.Add(new ChuongNuoi("D", "04"));
            cn.Add(new ChuongNuoi("E", "05"));
            cn.Add(new ChuongNuoi("F", "06"));
            cn.Add(new ChuongNuoi("G", "07"));
            cn.Add(new ChuongNuoi("H", "08"));
            cn.Add(new ChuongNuoi("I", "09"));
            cn.Add(new ChuongNuoi("J", "10"));
            cn.Add(new ChuongNuoi("K", "11"));
            cn.Add(new ChuongNuoi("L", "12"));
            cn.Add(new ChuongNuoi("M", "13"));
            cn.Add(new ChuongNuoi("N", "14"));
            cn.Add(new ChuongNuoi("O", "15"));
            cn.Add(new ChuongNuoi("P", "16"));
            cn.Add(new ChuongNuoi("Q", "17"));
            cn.Add(new ChuongNuoi("R", "18"));
            cn.Add(new ChuongNuoi("S", "19"));
            cn.Add(new ChuongNuoi("T", "20"));
            cn.Add(new ChuongNuoi("U", "21"));
            cn.Add(new ChuongNuoi("V", "22"));
            cn.Add(new ChuongNuoi("W", "23"));
            cn.Add(new ChuongNuoi("X", "24"));
            cn.Add(new ChuongNuoi("Y", "25"));
            cn.Add(new ChuongNuoi("Z", "26"));
        }

        public static void TaoDSDVChuongNuoi()
        {
            dvcn.Add(new DVChuongNuoi("01", "A", date, "2 tháng"));
            dvcn.Add(new DVChuongNuoi("02", "B", date, "2 tháng"));
            dvcn.Add(new DVChuongNuoi("03", "C", date, "2 tháng"));
            dvcn.Add(new DVChuongNuoi("04", "D", date, "2 tháng"));
            dvcn.Add(new DVChuongNuoi("05", "E", date, "4 tháng"));
            dvcn.Add(new DVChuongNuoi("06", "F", date, "4 tháng"));
            dvcn.Add(new DVChuongNuoi("07", "G", date, "4 tháng"));
            dvcn.Add(new DVChuongNuoi("08", "H", date, "4 tháng"));
            dvcn.Add(new DVChuongNuoi("09", "I", date, "8 tháng"));
            dvcn.Add(new DVChuongNuoi("10", "J", date, "8 tháng"));
            dvcn.Add(new DVChuongNuoi("11", "K", date, "8 tháng"));
            dvcn.Add(new DVChuongNuoi("12", "L", date, "8 tháng"));
            dvcn.Add(new DVChuongNuoi("13", "M", date, "12 tháng"));
            dvcn.Add(new DVChuongNuoi("14", "N", date, "12 tháng"));
            dvcn.Add(new DVChuongNuoi("15", "O", date, "12 tháng"));
            dvcn.Add(new DVChuongNuoi("16", "P", date, "12 tháng"));
            dvcn.Add(new DVChuongNuoi("17", "Q", date, "24 tháng"));
            dvcn.Add(new DVChuongNuoi("18", "R", date, "24 tháng"));
            dvcn.Add(new DVChuongNuoi("19", "S", date, "24 tháng"));
            dvcn.Add(new DVChuongNuoi("20", "T", date, "24 tháng"));
            dvcn.Add(new DVChuongNuoi("21", "U", date, "36 tháng"));
            dvcn.Add(new DVChuongNuoi("22", "V", date, "36 tháng"));
            dvcn.Add(new DVChuongNuoi("23", "W", date, "36 tháng"));
            dvcn.Add(new DVChuongNuoi("24", "X", date, "36 tháng"));
            dvcn.Add(new DVChuongNuoi("25", "Y", date, "48 tháng"));
            dvcn.Add(new DVChuongNuoi("26", "Z", date, "48 tháng"));
        }

        public static void TaoDSKhauPhan()
        {
            kp.Add(new KhauPhan("01", "THIT01"));
            kp.Add(new KhauPhan("02", "THIT01"));
            kp.Add(new KhauPhan("06", "THIT01"));
            kp.Add(new KhauPhan("09", "THIT02"));
            kp.Add(new KhauPhan("11", "THIT02"));
            kp.Add(new KhauPhan("13", "THIT02"));
            kp.Add(new KhauPhan("03", "THUCVAT01"));
            kp.Add(new KhauPhan("04", "THUCVAT01"));
            kp.Add(new KhauPhan("014", "THUCVAT01"));
            kp.Add(new KhauPhan("07", "THUCVAT02"));
            kp.Add(new KhauPhan("08", "THUCVAT02"));
            kp.Add(new KhauPhan("10", "THUCVAT02"));
            kp.Add(new KhauPhan("12", "THUCVAT02"));
        }

        public static void TaoDSPhongBan()
        {
            pb.Add(new PhongBan("PB1", "Phòng Ban Chăm Sóc Khách Hàng", "Trung tâm Sở Thú"));
            pb.Add(new PhongBan("PB2", "Phòng Ban Bán Vé", "Cổng Sở Thú"));
            pb.Add(new PhongBan("PB3", "Phòng Ban Bảo Vệ", "Trung Tâm Sở Thú"));
            pb.Add(new PhongBan("PB4", "Phòng Ban Thức Ăn", "Phía Tây Sở Thú"));
            pb.Add(new PhongBan("PB5", "Phòng Ban Quản Lý Nhân Viên", "Phía Đông Sở Thú"));
            pb.Add(new PhongBan("PB6", "Phòng Ban Chăm Sóc Thú", "Phía Nam Sở Thú"));
            pb.Add(new PhongBan("PB7", "Phòng Ban Vệ Sinh", "Phía Bắc Sở Thú"));
        }

        public static void TaoDSThucAn()
        {
            dt.Add(new ThucAn("THIT01", "Thịt tươi"));
            dt.Add(new ThucAn("THIT02", "Thịt chín"));
            dt.Add(new ThucAn("THUCVAT01", "Cỏ"));
            dt.Add(new ThucAn("THUCVAT02", "Trái cây"));
        }

        public static void TaoDSCongTyBanVe()
        {
            ct.Add(new CongTyBanVe("CTY01", "Công ty 01", 1000, 800, date));
            ct.Add(new CongTyBanVe("CTY02", "Công ty 02", 1500, 900, date));
            ct.Add(new CongTyBanVe("CTY03", "Công ty 03", 2000, 1500, date));
            ct.Add(new CongTyBanVe("CTY04", "Công ty 04", 2500, 200, date));
        }

        public static void TaoDSNhanVien()
        {
            nv.Add(new NhanVien("NV1", "Nguyễn Thanh Minh Đức", "PB1", "Nhân viên Chăm Sóc Khách Hàng"));
            nv.Add(new NhanVien("NV2", "Lê Vũ Minh Hoàng", "PB2", "Nhân viên Bán Vé"));
            nv.Add(new NhanVien("NV3", "Đoàn Thị Thanh Vân", "PB2", "Nhân viên Bán Vé"));
            nv.Add(new NhanVien("NV4", "Lê Trần Minh Nhựt", "PB3", "Nhân viên Bảo Vệ"));
            nv.Add(new NhanVien("NV5", "Bạch Trung Quốc", "PB3", "Nhân viên Thức Ăn"));
            nv.Add(new NhanVien("NV6", "Nguyễn Như Anh Tài", "PB4", "Nhân viên Thức Ăn"));
            nv.Add(new NhanVien("NV7", "Trần Tiến Phát", "PB4", "Nhân viên Bảo Vệ"));
            nv.Add(new NhanVien("NV8", "Đặng Lê Quang", "PB5", "Quản lý"));
            nv.Add(new NhanVien("NV9", "Nguyễn Thành Long", "PB6", "Nhân viên Chăm Sóc Thú Ăn Thịt"));
            nv.Add(new NhanVien("NV10", "Dương Hoàng Thy Trân", "PB6", "Nhân viên Chăm Sóc Thú Ăn Thịt"));
            nv.Add(new NhanVien("NV11", "Hoàng Nguyễn Kim Duy", "PB6", "Nhân viên Chăm Sóc Thú Ăn Cỏ"));
            nv.Add(new NhanVien("NV12", "Nguyễn Khánh Hòa", "PB6", "Nhân viên Chăm Sóc Thú Ăn Cỏ"));
            nv.Add(new NhanVien("NV13", "Bùi Hà Nhi", "PB7", "Nhân viên Vệ Sinh"));
            nv.Add(new NhanVien("NV14", "Mai Thanh Phúc", "PB7", "Nhân viên Vệ Sinh"));
        }

        public static void TaoDSVe()
        {
            ve.Add(new Ve("V1", "Kh01", "NV2", date));
            ve.Add(new Ve("V1", "Kh02", "NV2", date));
            ve.Add(new Ve("V1", "Kh03", "NV2", date));
            ve.Add(new Ve("V1", "Kh04", "NV2", date));
            ve.Add(new Ve("V1", "Kh05", "NV2", date));
            ve.Add(new Ve("V1", "Kh06", "NV2", date));
            ve.Add(new Ve("V1", "Kh07", "NV2", date));
            ve.Add(new Ve("V1", "Kh08", "NV2", date));
            ve.Add(new Ve("V1", "Kh09", "NV2", date));
            ve.Add(new Ve("V1", "Kh11", "NV2", date));
            ve.Add(new Ve("V1", "Kh12", "NV2", date));
            ve.Add(new Ve("V1", "Kh13", "NV2", date));
            ve.Add(new Ve("V1", "Kh14", "NV2", date));
            ve.Add(new Ve("V1", "Kh15", "NV2", date));
            ve.Add(new Ve("V2", "Kh16", "NV3", date));
            ve.Add(new Ve("V2", "Kh17", "NV3", date));
            ve.Add(new Ve("V2", "Kh18", "NV3", date));
            ve.Add(new Ve("V2", "Kh19", "NV3", date));
            ve.Add(new Ve("V2", "Kh20", "NV3", date));
            ve.Add(new Ve("V2", "Kh21", "NV3", date));
            ve.Add(new Ve("V2", "Kh22", "NV3", date));
            ve.Add(new Ve("V2", "Kh23", "NV3", date));
            ve.Add(new Ve("V2", "Kh24", "NV3", date));
            ve.Add(new Ve("V2", "Kh25", "NV3", date));
            ve.Add(new Ve("V2", "Kh26", "NV3", date));
            ve.Add(new Ve("V2", "Kh27", "NV3", date));
            ve.Add(new Ve("V2", "Kh28", "NV3", date));
            ve.Add(new Ve("V2", "Kh29", "NV3", date));
            ve.Add(new Ve("V2", "Kh30", "NV3", date));
        }

        public static void TaoDSKhachXem()
        {
            kx.Add(new KhachXem("Hồ Hoài Phong", "Kh01", "V1", date));
            kx.Add(new KhachXem("Nguyễn Văn Sơn", "Kh02", "V1", date));
            kx.Add(new KhachXem("Nguyễn Trường Giang", "Kh03", "V1", date));
            kx.Add(new KhachXem("Dan Bảo Nguyễn", "Kh04", "V1", date));
            kx.Add(new KhachXem("Nguyễn Thuận", "Kh05", "V1", date));
            kx.Add(new KhachXem("Trần Nguyễn Quốc Khánh", "Kh06", "V1", date));
            kx.Add(new KhachXem("Nguyễn Kỳ Hải", "Kh07", "V1", date));
            kx.Add(new KhachXem("Lê Trung Hậu", "Kh08", "V1", date));
            kx.Add(new KhachXem("Nguyễn Xuân Bách", "Kh09", "V1", date));
            kx.Add(new KhachXem("Bùi Đình Xuân", "Kh10", "V1", date));
            kx.Add(new KhachXem("Trịnh Định Hoàng Huy", "Kh11", "V1", date));
            kx.Add(new KhachXem("Nguyễn Thành Trọng", "Kh12", "V1", date));
            kx.Add(new KhachXem("Huỳnh Minh Thông", "Kh13", "V1", date));
            kx.Add(new KhachXem("Lê Nhựt Trường", "Kh14", "V1", date));
            kx.Add(new KhachXem("Nguyễn Minh Trí", "Kh15", "V1", date));
            kx.Add(new KhachXem("Hoàng Minh Đức", "Kh16", "V2", date));
            kx.Add(new KhachXem("Trần Mạnh Cường", "Kh17", "V2", date));
            kx.Add(new KhachXem("Nguyễn Văn Hoàng", "Kh18", "V2", date));
            kx.Add(new KhachXem("Vỹ Minh Khánh Hoa", "Kh19", "V2", date));
            kx.Add(new KhachXem("Bùi Công Danh", "Kh20", "V2", date));
            kx.Add(new KhachXem("Nguyễn Thị Xuân Thanh", "Kh21", "V2", date));
            kx.Add(new KhachXem("Hồ Quốc Vinh", "Kh22", "V2", date));
            kx.Add(new KhachXem("Phan Tân Tỵ", "Kh23", "V2", date));
            kx.Add(new KhachXem("Nguyễn Trọng Hiếu", "Kh24", "V2", date));
            kx.Add(new KhachXem("Nguyễn Nhật Tâm", "Kh25", "V2", date));
            kx.Add(new KhachXem("Nguyễn Chí Hải", "Kh26", "V2", date));
            kx.Add(new KhachXem("Lê Hoàng Lộc", "Kh27", "V2", date));
            kx.Add(new KhachXem("Nguyễn Thái Hưng", "Kh28", "V2", date));
            kx.Add(new KhachXem("Hoàng Nhựt Khánh Ngân", "Kh29", "V2", date));
            kx.Add(new KhachXem("Lê Hoàng Mai Ngân", "Kh30", "V2", date));
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
        }
    }
}