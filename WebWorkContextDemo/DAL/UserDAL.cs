using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorkContextDemo.DAL
{
    public class UserDAL : BaseDAL
    {
        public string GetUserAge()
        {
            return WorkContext.UserId.ToString();
        }
    }
}