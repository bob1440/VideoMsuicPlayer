using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.IO;

namespace WebApplication1
{
    /// <summary>
    ///Handler1 的摘要描述
    /// </summary>
    public class Mp3Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //// 將 MIME 類型設為 MPEG3
            //context.Response.ContentType = "audio/mpeg";

            //// 這個就是想要傳入產生發音的文字
            //string txt = HttpContext.Current.Server.UrlDecode(context.Request.QueryString["txt"]);


            //// 抓到檔名
            //string fileName = "1770533184_2758651_l" + ".mp3";
            //string filePath = "D:\\music\\" + fileName;

            //// 將檔案以 FileStream 方式打開
            //FileStream fs = new FileStream(filePath, FileMode.Open);
            //byte[] bytes = new byte[(int)fs.Length];
            //fs.Read(bytes, 0, bytes.Length);
            //fs.Close();

            ////// 設定瀏覽器以下載文件方式打開
            //context.Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
            //context.Response.BinaryWrite(bytes);
            //context.Response.Flush();
            //context.Response.End();

            //檔案名稱
            string txt = HttpContext.Current.Server.UrlDecode(context.Request.QueryString["txt"]);


            string filePath = "D:\\music\\"+txt;
            byte[] buffer = File.ReadAllBytes(filePath);

            context.Response.Clear();
            context.Response.Cache.SetCacheability(HttpCacheability.Public);
            context.Response.Cache.SetLastModified(DateTime.Now);
            context.Response.AppendHeader("Content-Type", "audio/mpeg3");
            context.Response.AddHeader("Content-Disposition", "attachment;filename=file.mp3");
            context.Response.AppendHeader("Content-Length", buffer.Length.ToString());

            context.Response.BinaryWrite(buffer);


           

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}