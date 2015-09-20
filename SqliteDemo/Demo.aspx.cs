using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLite;
using SqliteDemo.Model;

namespace SqliteDemo
{
    public partial class Demo : System.Web.UI.Page
    {
        private SQLiteConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            var path = Server.MapPath("~/App_Data/Demo.db");
            con = new SQLiteConnection(path);
            //con.CreateTable<User>();//创建表 只需执行一次

            if (!string.IsNullOrEmpty(Request["id"]))
            {
                con.Delete<User>(Request["id"]);
                Response.Redirect("Demo.aspx");
            }

            var cmd = con.CreateCommand("select * from User");
            var list = cmd.ExecuteQuery<User>();
            foreach (var item in list)
            {
                Response.Write(string.Format("{0}-{1}-{2}   <a href='Demo.aspx?id={3}'>删除</a><br>", item.Name,item.PassWord,item.CreateTime,item.ID));
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            var rand = new Random().Next(100, 999);
            User user = new User();
            user.Name = "ceshi"+rand;
            user.PassWord = "123456"+rand;
            user.CreateTime = DateTime.Now;
            con.Insert(user);//添加数据
            Response.Redirect("Demo.aspx");
        }
    }
}