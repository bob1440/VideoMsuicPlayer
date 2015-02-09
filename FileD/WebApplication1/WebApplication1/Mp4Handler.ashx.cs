using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


namespace WebApplication1
{
    /// <summary>
    ///Mp4Handler 的摘要描述
    /// </summary>
    public class Mp4Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //檔案名稱
            string txt = HttpContext.Current.Server.UrlDecode(context.Request.QueryString["txt"]);
            

            string filePath = MainParm.Instance.Dir + txt;
            byte[] buffer = File.ReadAllBytes(filePath);

            context.Response.Clear();
            context.Response.Cache.SetCacheability(HttpCacheability.Public);
            context.Response.Cache.SetLastModified(DateTime.Now);
            context.Response.AppendHeader("Content-Type", "video/mp4");
            context.Response.AddHeader("Content-Disposition", "attachment;filename=file.mp4");
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