using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sqlitehelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        SQLiteHelper h;

        private void Form1_Load(object sender, EventArgs e)
        {
            h=new SQLiteHelper();
           // SQLiteHelper.CreateDB("alarm.db");//创建数据库
            SQLiteHelper.SetConnectionString("alarm.db");//创建连接字符串


            try
            {
                h.ExecuteNonQuery("create table a1(id int, name text,age int)", null);//创建a1表
            }
            catch (Exception)
            {

               
            }
           
        }


        private void button3_Click(object sender, EventArgs e)//增加
        {
            h.ExecuteNonQuery("insert into  a1 values(5,'q1',20)", null);
        }

        private void button4_Click(object sender, EventArgs e)//删除
        {
            h.ExecuteNonQuery("delete from  a1 where id=5", null);
        }

        private void button5_Click(object sender, EventArgs e)//修改
        {
            h.ExecuteNonQuery(" update  a1 set age=40 where id=4", null);
        }
    }
}
