using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebWorkContextDemo.Models;

namespace WebWorkContextDemo.BLL
{
    public class BaseBLL
    {
        public virtual WebWorkContext WorkContext { get; set; }
    }
}