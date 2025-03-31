using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private int MaNV;
        private string TenNV;
        private int SDT;
        private string QueQuan;
        private string GioiTinh;

        public int MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public NhanVien_DTO() { }
        public NhanVien_DTO(int ma, string ten, int sdt, string quequan, string gioitinh)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.SDT = sdt;
            this.QueQuan = quequan;
            this.GioiTinh = gioitinh;
        }
        public NhanVien_DTO(DataRow row)
        {
            this.MaNV = (int)row["MaNV"];
            this.TenNV = row["TenNV"].ToString();
            this.SDT = (int)row["SDT"];
            this.QueQuan = row["QueQuan"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
        }
    }

}
