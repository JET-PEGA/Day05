using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClient
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get 測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGet_Click(object sender, EventArgs e)
        {
            txtResponse.Text = Get<string>(new Uri("http://localhost:34160/api/MyWebApi/get"));

        }

        /// <summary>
        /// Post 測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPost_Click(object sender, EventArgs e)
        {
            txtResponse.Text = Post<int>(new Uri("http://localhost:34160/api/MyWebApi/Post/1"), 1);

        }

        /// <summary>
        /// Post
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private dynamic Post<T>(Uri requestUri, T data)
        {
            HttpClient httpClient = new HttpClient();
            dynamic ret = default(dynamic);
            HttpResponseMessage response = default(HttpResponseMessage);
            try
            {
                httpClient.DefaultRequestHeaders.Host = requestUri.Host;
                response = httpClient.PostAsJsonAsync<T>(requestUri, data).Result;
                string result = response.Content.ReadAsStringAsync().Result;
                ret = JsonConvert.DeserializeObject<dynamic>(result);
            }
            catch (Exception)
            {
                throw;
            }
            return ret;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        private dynamic Get<T>(Uri requestUri)
        {
            HttpClient httpClient = new HttpClient();
            dynamic ret = default(dynamic);
            try
            {
                var response = httpClient.GetStringAsync(requestUri);
                ret = JsonConvert.DeserializeObject<dynamic>(response.Result);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ret;
        }


    }
}
