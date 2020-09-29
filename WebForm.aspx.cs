using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections.Generic;

namespace Semple_image
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upload(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Request.PhysicalApplicationPath + "Images\\" + FileUpload1.FileName.ToString());
            List<ListItem> files = new List<ListItem>();
            Repeater1.DataSource = files;
            Repeater1.DataBind();

            Label1.Text = "saved";
           
            
        }
    }
}