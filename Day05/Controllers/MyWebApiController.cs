using Day05.Models;
using System.Web.Http;

namespace Day05.Controllers
{
    /// <summary>
    /// 基礎練習 (需要繼承 ApiController)
    /// </summary>
    public class MyWebApiController : ApiController
    {
        /// <summary>
        ///  webClient會用到
        /// </summary>
        /// <returns></returns>
        //public string Get()
        //{
        //    return $"Hello World! (Get)";
        //}

        /// <summary>
        /// Get 測試
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return $"Hello World! (Get){id}";
        }

        /// <summary>
        /// 測試兩個Get 不指名Action會報錯(R2)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetHello(int id)
        {
            return $"Hello World! (GetGetHello){id}";
        }

        /// <summary>
        /// Post測試(DefaultApi) webClient會用到
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Post(int id)
        {
            return "Hello World! (Post)";
        }

        /// <summary>
        /// Get 回傳物件測試，用Chrome、IE分別測試一下(R3)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserInfo GetUserInfo(string name)
        {
            return new UserInfo() { ID = "LA0900xxx", Name = name };
        }


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public string PostUserName(UserInfo userInfo)
        //{
        //    return userInfo.Name;
        //}



    }
}
