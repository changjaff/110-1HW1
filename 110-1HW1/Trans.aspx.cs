using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW1
{
    public partial class Trans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double d_Value = 3.982;  //建立d_Value變數為3.982

            double d_Value2 = (d_Value * d_Value) * 0.3025; //d_Value 數值相乘後(算出平方公尺) 再乘以0.3025/坪

            Response.Write("d_Value = " + d_Value + " * " + d_Value + " = " + d_Value2); //印出結果
        }
    }
}