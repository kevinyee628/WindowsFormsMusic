using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic
{
    public partial class BoseMusic : Form
    {
        public BoseMusic()
        {
            InitializeComponent();
        }

        //查看音乐
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //登录
        private void Button2_Click(object sender, EventArgs e)
        {
            //获取用户名
            string username = textBox1.Text;
            //获取密码
            string password = textBox2.Text;
            //判断用户名密码是否正确
            if ("xiaoming".Equals(username) && "123456".Equals(password))
            {
                MessageBox.Show("登录成功！");
                //TODO:新的窗口

            }
            else
            {
                MessageBox.Show("账号或密码错误！");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {

        }
    }
    //public partial class BoseMusicSuccess : Form
    //{
    //}
}
