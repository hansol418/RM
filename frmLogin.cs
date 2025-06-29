using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 데이터베이스를 생성하고 유저테이블을 생성해야한다.

            if(MainClass.IsValidUser(txtUser.Text, txtPass.Text) == false)
            {
                guna2MessageDialog1.Show("유효하지않은 유저네임 또는 패스워드입니다");
                return;
            }
            else
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }

            // 첫번째로 유저를 삽입해야한다.
        }
    }
}
