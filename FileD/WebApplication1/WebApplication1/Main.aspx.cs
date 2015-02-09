using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Hosting;

namespace WebApplication1
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Put all file names in root directory into array.
           // string[] array1 = Directory.GetFiles(@"\");

            //// Put all txt files in root directory into array.
           // List<string> array2 = Directory.GetFiles(@"D:\music", "*.mp3").ToList<string>(); // <-- Case-insensitive
          //  array2.AddRange(Directory.GetFiles(@"D:\music", "*.ape").ToList<string>());

            List<string> array2 = Directory.GetFiles(Server.MapPath("/music"), "*.mp4").ToList<string>(); // <-- Case-insensitive
          
            //List<string> array2 = Directory.GetFiles(MainParm.Instance.Dir, "*.mp4").ToList<string>(); // <-- Case-insensitive
          
            // Display all files.
            Console.WriteLine("--- Files: ---");
            foreach (string name in array2)
            {
               
                Response.Write("<div><a href='/PlayOneMedia.aspx?mn="+name.Substring((name.LastIndexOf("\\")+1))+"'>aaa</a></div>");

          //      Response.Write("<div>"+ urlconvertor(name) + "</div>");
            }

            
        }



        private string urlconvertor(string imagesurl1)
        {
            //获取程序根目录
            string tmpRootDir = Server.MapPath(System.Web.HttpContext.Current.Request.ApplicationPath.ToString());
            Response.Write(tmpRootDir);
            //转换成URL相对路径
            string imagesurl2 = imagesurl1.Replace(tmpRootDir, "");
            imagesurl2 = imagesurl2.Replace(@"/", @"/");
            return imagesurl2;
        }
    }

  
}