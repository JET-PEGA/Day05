using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day05
{
    /// <summary>
    /// 泛型處理常式
    /// </summary>
    public class MyHandler : IHttpHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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