using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorkContextDemo.Models
{
    public class WebWorkContext
    {

        /// <summary>
        /// 判断用户是否登录
        /// </summary>
        public bool IsLogin { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// 是否是Get请求
        /// </summary>
        public bool IsGet { get; set; }


        /// <summary>
        /// 是否是Ajax请求
        /// </summary>
        public bool IsAjax { get; set; }


    }
}