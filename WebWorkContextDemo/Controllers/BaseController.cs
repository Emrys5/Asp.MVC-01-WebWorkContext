using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebWorkContextDemo.Models;

namespace WebWorkContextDemo.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// 创建上下文Context
        /// </summary>
        public WebWorkContext WorkContext = new WebWorkContext();

        /// <summary>
        /// 重写Controller中的Initialize方法。在此方法中获取用户和其他的信息
        /// </summary>
        /// <param name="requestContext"></param>
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            // 判断用户信息
            if (!string.IsNullOrEmpty(Convert.ToString(Session["USERID"])))
            {
                WorkContext.IsLogin = true;
                WorkContext.UserId = Convert.ToInt32(Session["USERID"]);
                WorkContext.UserName = Convert.ToString(Session["USERNAME"]);
                WorkContext.UserEmail = Convert.ToString(Session["USEREMAIL"]);
            }


            // 测试模拟登录 
            WorkContext.IsLogin = true;
            WorkContext.UserId = 10;
            WorkContext.UserName = "Emrys";
            WorkContext.UserEmail = "9097206@qq.com";


            // 判断是否是Get请求
            WorkContext.IsGet = requestContext.HttpContext.Request.HttpMethod == "GET";

            // 判断是否是Ajax请求
            WorkContext.IsAjax = requestContext.HttpContext.Request.IsAjaxRequest();

        }

    }
}