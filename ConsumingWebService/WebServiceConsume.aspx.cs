using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumingWebService
{
    public partial class WebServiceConsume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Disp();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyServiceReference.MyWebServiceSoapClient client = new MyServiceReference.MyWebServiceSoapClient();
           int result =  client.Addition(int.Parse(TextBox1.Text),int.Parse(TextBox2.Text));
            Label1.Text = "Sum of Two Number is = " + result.ToString();
        }

        void Disp()
        {
            MyServiceReference.MyWebServiceSoapClient client = new MyServiceReference.MyWebServiceSoapClient();
            GridView1.DataSource = client.Get();
            GridView1.DataBind();
        }
    }
}