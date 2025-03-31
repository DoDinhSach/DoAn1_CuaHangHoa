using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if(instance == null) instance = new AccountDAL(); return instance;}
            private set { instance = value; }
        }
        private AccountDAL() { }
        public bool Login(string username, string pass) 
        {
            string query = "USP_Login @Username, @Pass";
            DataTable result = DataProvier.Instance.ExecuteQuery(query, new object[] { username, pass });
            return result.Rows.Count > 0;

        }

        public int Quyen(string user)
        {
            string query = $"select loaitk from TaiKhoan where tendn = '{user}'";


            DataTable result = DataProvier.Instance.ExecuteQuery(query);
            int quyen = 0;
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                quyen = (int)row["loaitk"];
            }
            return quyen;
        }
    }
}
