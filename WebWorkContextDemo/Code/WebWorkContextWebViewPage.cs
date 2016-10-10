
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebWorkContextDemo.Controllers;
using WebWorkContextDemo.Models;

namespace WebWorkContextDemo
{
    public abstract class WebWorkContextWebViewPage<TModel> : System.Web.Mvc.WebViewPage<TModel>
    {
        public WebWorkContext WorkContext; 
        public sealed override void InitHelpers()
        {
            base.InitHelpers();
            BaseController baseController = ((this.ViewContext.Controller) as BaseController);
            if (baseController != null)
            {
                WorkContext = baseController.WorkContext; 
            }

        }
    }
}