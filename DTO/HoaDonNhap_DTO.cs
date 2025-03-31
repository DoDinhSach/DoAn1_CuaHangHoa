using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDonNhap_DTO
    {
        //hoá đơn nhập
        private int MaHDN;
        private DateTime NgayNhap;
        private string TenNhaCC;
        private int MaNV;
        //chi tiết hoá đơn nhập
        private int MaHoa;
        private int SoluongNhap;
        private int DonGia;
        private int ThanhTien;

        public int MaHDN1 { get => MaHDN; set => MaHDN = value; }
        public DateTime NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public string TenNhaCC1 { get => TenNhaCC; set => TenNhaCC = value; }
        public int MaNV1 { get => MaNV; set => MaNV = value; }
        public int MaHoa1 { get => MaHoa; set => MaHoa = value; }
        public int SoluongNhap1 { get => SoluongNhap; set => SoluongNhap = value; }
        public int DonGia1 { get => DonGia; set => DonGia = value; }
        public int ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public HoaDonNhap_DTO() { }
        public HoaDonNhap_DTO(int mahdn, DateTime ngaynhap, string tennhacc, int manv, int mahoa, int soluongnhap, int dongia, int thanhtien)
        {
            this.MaHDN = mahdn;
            this.NgayNhap = ngaynhap;
            this.TenNhaCC = tennhacc;
            this.MaNV = manv;
            this.MaHoa = mahoa;
            this.SoluongNhap = soluongnhap;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }
        public HoaDonNhap_DTO(DataRow row)
        {
            this.MaHDN = (int)row["mahdn"];
            this.NgayNhap = (DateTime)row["ngaynhap"];
            this.TenNhaCC = row["tennhacc"].ToString();
            this.MaNV = (int)row["manv"];
            this.MaHoa = (int)row["mahoa"];
            this.SoluongNhap = (int)row["soluongnhap"];
            this.DonGia = (int)row["dongia"];
            this.ThanhTien = (int)row["thanhtien"];
        }
    }
}
