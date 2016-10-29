using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace $safeprojectname$
{
    public partial class asknumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



           
            
        }

        protected void submitform (object sender ,EventArgs e)
         {

            foreach (string key in Request.Form.AllKeys)
            {
                Response.Write("<script> alert(\""+Request.Form[key]+"\");</script>");
               
            }
            
            int snum;
            int e_num;
            int i_num;
            if ((!int.TryParse(start_number.Value,out snum)) || (!int.TryParse(interval_num.Value, out i_num)) || (!int.TryParse(end_number.Value, out e_num)))
            {

                Response.Write("<script> alert(\"Please Enter a number in both field\");</script>");
                xyz.InnerHtml = "";
            }
            else   {
               // Response.Write(Request.Form["start_number"]);
                xyz.InnerHtml =""+ (snum + e_num)+"k"+ start_number.Value;

                //send variable to gamepage.aspx

                Session["20"] = snum;
                Session["21"] = e_num;
                Session["22"] = i_num;
                Response.Redirect("gamepage.aspx");
                //reset all
                

           }
            foreach (Control ctrl in Form.Controls)
            {
                // Response.Write ("<script> alert(\" "+ctrl.GetType()+"\");</script>");
                if (ctrl.GetType() == typeof(System.Web.UI.HtmlControls.HtmlInputText))
                {
                    ((System.Web.UI.HtmlControls.HtmlInputText)(ctrl)).Value = string.Empty;
                }

            }



        }

       
    }
}