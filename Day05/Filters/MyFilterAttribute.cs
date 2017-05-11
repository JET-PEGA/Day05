using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Day05.Filters
{
    public class MyFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Action 被執行前
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {

        }
    }
}