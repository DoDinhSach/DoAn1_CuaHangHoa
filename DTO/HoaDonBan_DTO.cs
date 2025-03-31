using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBan_DTO
    {
        private int MaHDB;
        private DateTime NgayBan;
        private int MaKH;
        private int MaNV;
        private string TrangThai;
        private int MaHoa;
        private int SoLuong;
        private int DonGia;
        private int ThanhTien;

        public int MaHDB1 { get => MaHDB; set => MaHDB = value; }
        public DateTime NgayBan1 { get => NgayBan; set => NgayBan = value; }
        public int MaKH1 { get => MaKH; set => MaKH = value; }
        public int maNV { get => MaNV; set => MaNV = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
        public int maHoa { get => MaHoa; set => MaHoa = value; }
        public int soLuong { get => SoLuong; set => SoLuong = value; }
        public int donGia { get => DonGia; set => DonGia = value; }
        public int thanhTien { get => ThanhTien; set => ThanhTien = value; }

        private HoaDonBan_DTO() { }
        public HoaDonBan_DTO(int mahdb, DateTime ngayban, int Makh, int Manv, string trangthai, int MaHoa, int soluong, int DonGia, int ThanhTien)
        {
            this.MaHDB = mahdb;
            this.NgayBan = ngayban;
            this.MaKH = Makh;
            this.MaNV = Manv;
            this.TrangThai = trangthai;
            this.MaHoa = MaHoa;
            this.SoLuong = soluong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
        }

        public HoaDonBan_DTO(DataRow row)
        {
            this.MaHDB = Convert.ToInt32(row["mahdb"]);
            this.NgayBan = (DateTime)row["ngayban"];
            this.MaKH = Convert.ToInt32(row["Makh"]);
            this.MaNV = Convert.ToInt32(row["Manv"]);
            this.TrangThai = row["trangthai"].ToString();
            this.MaHoa = Convert.ToInt32(row["MaHoa"]);
            this.SoLuong = Convert.ToInt32(row["soluong"]);
            this.DonGia = Convert.ToInt32(row["DonGia"]);
            this.ThanhTien = Convert.ToInt32(row["ThanhTien"]);
        }
    }

}
