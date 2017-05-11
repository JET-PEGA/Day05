using System.Web;

namespace Day05.Modules
{
    public class MyModule : IHttpModule
    {
        /// <summary>
        /// 繼承 IHttpModule 必須實作
        /// </summary>
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="app"></param>
        public void Init(HttpApplication app)
        {
            // 開始請求之處理程序
            app.BeginRequest += (s, e) =>
            {
               // app.Request.Headers.Add("QAccount", "Jet");
            };

            // 結束請求之處理程序
            app.EndRequest += (s, e) =>
            {

            };
        }
    }
}