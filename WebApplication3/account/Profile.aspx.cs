using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Repository;
using WebApplication3.Services;
using System.IO;

namespace WebApplication3.account
{
    public partial class Profile : System.Web.UI.Page
    {
        ITest1 test_Rep;
        public Profile()
        {
            test_Rep = new Test1();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void btnSendImage_Click(object sender, EventArgs e)
        //{
        //    if (FileUpload1.HasFile)
        //    {
        //        string SavePath = Server.MapPath("../Images");
        //        if (!Directory.Exists(SavePath))
        //        {
        //            Directory.CreateDirectory(SavePath);
        //        }

        //        foreach (HttpPostedFile file in FileUpload1.PostedFiles)
        //        {
        //            string fileName = Path.GetFileName(file.FileName);
        //            string filePath = Path.Combine(SavePath, fileName);
        //            file.SaveAs(filePath);
        //            test_Rep.UpdatePersonById(4, filePath);
        //            lblSelectPhoto.Visible = false;
        //        }
        //    }
        //    else
        //    {
        //        lblSelectPhoto.Text = "Please select a photo first!!!";
        //    }
        //}
    }
}