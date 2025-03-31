using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Account_DTO
    {
        private string tenht;
        private string tendn;
        private string mk;
        private int loaitk;


        public string Tenht { get => tenht; set => tenht = value; }
        public string Tendn { get => tendn; set => tendn = value; }
        public string Mk { get => mk; set => mk = value; }
        public int Loaitk { get => loaitk; set => loaitk = value; }

        private Account_DTO() { }
        public Account_DTO(string hienthi, string user, string pass, int quyen)
        {
            this.tenht = hienthi;
            this.tendn = user;
            this.mk = pass;
            this.loaitk = quyen;
        }

        public Account_DTO(DataRow row)
        {
            this.tenht = row["Tenht"].ToString();
            this.tendn = row["Tendn"].ToString();
            this.mk = row["Mk"].ToString();
            this.loaitk = (int)row["Loaitk"];
        }
    }
}
