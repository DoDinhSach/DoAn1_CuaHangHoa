using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class LoaiHoa_DTO
    {
        private int MaLoaiHoa;
        private string TenLoaiHoa;
        private string MoTa;

        public int MaLoaiHoa1 { get => MaLoaiHoa; set => MaLoaiHoa = value; }
        public string TenLoaiHoa1 { get => TenLoaiHoa; set => TenLoaiHoa = value; }
        public string MoTa1 { get => MoTa; set => MoTa = value; }

        public LoaiHoa_DTO() { }

        public LoaiHoa_DTO(int maloaihoa, string tenloaihoa, string mota)
        {
            this.MaLoaiHoa = maloaihoa;
            this.TenLoaiHoa = tenloaihoa;
            this.MoTa = mota;
        }

        public LoaiHoa_DTO(DataRow row)
        {
            this.MaLoaiHoa = (int)row["maloaihoa"];
            this.TenLoaiHoa = row["tenloaihoa"].ToString;
            this.MoTa = row["mota"].ToString;
        }
    }
}
