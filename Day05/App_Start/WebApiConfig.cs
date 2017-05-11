using System.Web.Http;

namespace Day05
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 設定和服務

            // Web API 路由
            config.MapHttpAttributeRoutes();

            // URL上id參數可有可無，有則尋找有id參數的Action，無則搜尋沒又參數的Action
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //URL上id參數可有可無，只尋找有id參數的Action，強迫帶入
            config.Routes.MapHttpRoute(
                name: "R1",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = 1 }
            );


            //config.Routes.MapHttpRoute(
            //    name: "R2",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);


            //config.Routes.MapHttpRoute(
            //    name: "R3",
            //    routeTemplate: "api/{controller}/{name}",
            //    defaults: new { id = RouteParameter.Optional }
            //);



            //config.Routes.MapHttpRoute(
            //    name: "R4",
            //    routeTemplate: "test/{controller}/{action}"
            //);


        }
    }
}
