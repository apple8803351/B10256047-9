using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class work2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //當載入時 可以調整主版頁面
    protected void Page_PreInit(object sender, EventArgs e)
    {
        DateTime dateTime = DateTime.Now;

        int dayOfWeek = (int)dateTime.DayOfWeek;

        //如果是星期一 三 五 就顯示主版頁面一
        if (dayOfWeek == 1 || dayOfWeek == 3 || dayOfWeek == 5)
        {
            Page.Title = "主版頁面一";
            Page.MasterPageFile = "MasterPage1.master";
        }
        else
        {
            Page.Title = "主版頁面二";
            Page.MasterPageFile = "MasterPage2.master";
        }
    }
}