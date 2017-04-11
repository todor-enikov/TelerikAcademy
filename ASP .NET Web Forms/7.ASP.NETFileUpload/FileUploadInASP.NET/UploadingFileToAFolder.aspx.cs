using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadInASP.NET
{
    public partial class UploadingFileToAFolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {

            if (this.FileUpload.HasFile)
            {
                try
                {
                    if (this.FileUpload.PostedFile.ContentType == "image/jpeg")
                    {
                        if (this.FileUpload.PostedFile.ContentLength < 10 * 1024000)
                        {
                            string filename = Path.GetFileName(this.FileUpload.FileName);
                            this.FileUpload.SaveAs(Server.MapPath("~/Uploaded_Files/" + filename));
                            this.StatusLabel.Text = "Upload status: You successfully uploaded file into Uploaded_Files folder. Congrats! :)";
                        }
                        else
                        {
                            this.StatusLabel.Text = "Upload status: The size of the image should be no more than 10 mb!";
                        }
                    }
                    else
                    {
                        this.StatusLabel.Text = "Upload status: You can upload just jpeg files.";
                    }
                }
                catch (Exception ex)
                {

                    this.StatusLabel.Text = "Upload status: File cannot be uploaded, because of that exception: " + ex.Message;
                }
            }
            else
            {
                this.StatusLabel.Text = "Upload status: Please choose file!";
            }
        }
    }
}