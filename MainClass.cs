using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RM
{
    class MainClass
    {

        public static readonly string con_string = "Data Source=RUKE-PC\\SQLEXPRESS; Initial Catalog=RM; Persist Security Info=True; User ID=sa; Password=std001;";
        public static SqlConnection con = new SqlConnection(con_string);

       
        //유저 검증을 확인하는 메서드

        public static bool IsValidUser(string user, string pass)
        {
            bool isvalid = false;

            string qry = @"Select * from users where username = '" + user + "' and upass ='" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                isvalid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }

            return isvalid;
        }

        // 유저네임을 위한 속성 생성

        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        
    }
}
