using Day05.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Stimulsoft.Report;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace Day05.Controllers
{
    /// <summary>
    /// 進階練習
    /// </summary>
    public class MyTestController : ApiController
    {
        /// <summary>
        /// 下載一個PDF報表 (記得把範本放到 D:\DEMO_1.mrt) (R4)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public HttpResponseMessage GetPdf()
        {
            HttpContext httpContext = HttpContext.Current;                      // 取得目前的 HttpContext
            HttpResponseMessage responseMessage = default(HttpResponseMessage); // 回應訊息物件
            byte[] content = GetPdfBinaryArray();
            responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            responseMessage.Content = new ByteArrayContent(content);
            responseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
            string fileNme = string.Format("{0}.pdf", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            responseMessage.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = fileNme };
            return responseMessage;
        }

        /// <summary>
        /// 取得自訂JSON (R4)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public HttpResponseMessage GetJson()
        {
            HttpContext httpContext = HttpContext.Current;                      // 取得目前的 HttpContext
            HttpResponseMessage responseMessage = default(HttpResponseMessage); // 回應訊息物件
            JObject content = JObject.FromObject(GetDataSet());
            responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            responseMessage.Content = new ObjectContent(typeof(JObject), content, new JsonMediaTypeFormatter());
            return responseMessage;
        }

        /// <summary>
        /// 取得自訂Xml
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public HttpResponseMessage GetXml()
        {
            HttpContext httpContext = HttpContext.Current;                      // 取得目前的 HttpContext
            HttpResponseMessage responseMessage = default(HttpResponseMessage); // 回應訊息物件
            JObject content = JObject.FromObject(GetDataSet());
            responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            XmlDocument doc = JsonConvert.DeserializeXmlNode(content.ToString(), "root");
            XmlElement element = doc.DocumentElement;
            responseMessage.Content = new ObjectContent(typeof(XmlElement), element, new XmlMediaTypeFormatter());
            return responseMessage;
        }

        /// <summary>
        /// 上傳檔案 ()
        /// </summary>
        /// <returns></returns>
        public string PostFiles()
        {
            HttpContext httpContext = HttpContext.Current;              // 取得目前的 HttpContext
            string fileName = string.Empty;

            foreach (string file in httpContext.Request.Files)
            {
                HttpPostedFile postedFile = httpContext.Request.Files[file];
                fileName = Path.GetFileName(postedFile.FileName);
                SaveFile(postedFile.InputStream, @"d:\Webapi_", postedFile.FileName);
            }

            return fileName;
        }

        [MyFilterAttribute()]
        public void FilterTest()
        {
        }

        // 

        //=========================================================================================================================================


        /// <summary>
        /// 取得 DEMO PDF 的檔案串流 (記得把範本放到 D:\DEMO_1.mrt)
        /// </summary>
        /// <returns></returns>
        private byte[] GetPdfBinaryArray()
        {
            byte[] content = null;
            string path = @"D:\\DEMO_1.mrt";
            // 建立綁定資料
            string ret = string.Empty;
            StiReport report = new StiReport();
            report.Load(path);
            report.RegData(GetDataSet());
            report.Render();
            using (MemoryStream ms = new MemoryStream())
            {
                report.ExportDocument(StiExportFormat.Pdf, ms);
                content = ms.ToArray();
            }
            return content;
        }

        /// <summary>
        /// 取得測試的 DataSet
        /// </summary>
        /// <returns></returns>
        private DataSet GetDataSet()
        {
            DataSet ds = new DataSet("DEMO");
            DataTable dt = new DataTable("Data");
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");
            dt.Rows.Add("LA01", "Jet");
            dt.Rows.Add("LA02", "Eric");
            dt.Rows.Add("LA03", "David");
            ds.Tables.Add(dt);
            return ds;
        }

        /// <summary>
        /// 儲存檔案
        /// </summary>
        /// <param name="stream">資料串流</param>
        /// <param name="filePath">檔案路徑</param>
        /// <param name="fileName">檔案名稱</param>
        /// <returns></returns>
        private bool SaveFile(Stream stream, string filePath, string fileName)
        {
            bool ret = false;
            string fullPath = Path.Combine(filePath, fileName);

            if (File.Exists(fullPath)) // 若檔案存在，刪除檔案
                File.Delete(fullPath);

            if (!Directory.Exists(filePath)) // 若目錄不存在，建立目錄
                Directory.CreateDirectory(filePath);

            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                stream.CopyTo(fs);
                fs.Close();
                stream.Seek(0, SeekOrigin.Begin);
                stream.Position = 0;
                ret = true;
            }

            return ret;
        }
    }
}
