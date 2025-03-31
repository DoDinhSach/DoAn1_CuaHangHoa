using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class KhachHang_DTO
    {
        private int MaKH;
        private string TenKH;
        private int SDT;
        private string DiaChi;


        public int MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    
        public KhachHang_DTO() { }

        public KhachHang_DTO(int makh, string tenkh, int sdt, string diachi)
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.SDT = sdt;
            this.DiaChi = diachi;
        }

        public KhachHang_DTO(DataRow row)
        {
            this.MaKH = (int)row["makh"];
            this.TenKH = row["tenkh"].ToString();
            this.SDT = (int)row["sdt"];
            this.DiaChi = row["diachi"].ToString();

        }

    }
}
