using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebWorkContextDemo.BLL;

namespace WebWorkContextDemo.Controllers
{
    public class HomeController : BaseController
    {

        UserBLL bll = new UserBLL();

        /// <summary>
        /// 重写Initialize，给BLL设置WebWorkContext
        /// </summary>
        /// <param name="requestContext"></param>
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            bll.WorkContext = WorkContext;
        }


        public ActionResult Index()
        {
            var userId = WorkContext.UserId;
            var userName = WorkContext.UserName;

            if (WorkContext.IsLogin)
            {
                string age = bll.GetUserAge();
                ViewBag.Age = age;
            } 
            return View();
        }
    }
}