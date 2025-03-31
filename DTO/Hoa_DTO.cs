using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Hoa_DTO
    {
        private int MaHoa;
        private string TenHoa;
        private int GiaTien;
        private string XuatXu;
        private int MaLoaiHoa;

        public int MaHoa1 { get => MaHoa; set => MaHoa = value; }
        public string TenHoa1 { get => TenHoa; set => TenHoa = value; }
        public int GiaTien1 { get => GiaTien; set => GiaTien = value; }
        public string XuatXu1 { get => XuatXu; set => XuatXu = value; }
        public int MaLoaiHoa1{ get => MaLoaiHoa; set => MaLoaiHoa = value; }

        public Hoa_DTO() { }

        public Hoa_DTO(int mahoa, string tenhoa, int giatien, string xuatXu, int maloaihoa)
        {
            this.MaHoa = mahoa;
            this.TenHoa = tenhoa;
            this.GiaTien = giatien;
            this.XuatXu = xuatXu;
            this.MaLoaiHoa = maloaihoa;
        } 

        public Hoa_DTO(DataRow row)
        {
            this.MaHoa = (int)row["mahoa"];
            this.TenHoa = row["tenhoa"].ToString();
            this.GiaTien = (int)row["giatien"];
            this.XuatXu = row["xuatxu"].ToString();
            this.MaLoaiHoa = (int)row["maloaihoa"];

        }

    }
}
