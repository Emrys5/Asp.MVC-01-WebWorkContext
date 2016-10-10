using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebWorkContextDemo.DAL;
using WebWorkContextDemo.Models;

namespace WebWorkContextDemo.BLL
{
    public class UserBLL : BaseBLL
    {
        UserDAL dal = new UserDAL();

        public override WebWorkContext WorkContext
        {
            get
            {
                return base.WorkContext;
            }

            set
            {
                base.WorkContext = value;
                dal.WorkContext = value;
            }
        }


        public string GetBLLUserAge()
        {
            return WorkContext.UserId.ToString();
        }

        public string GetUserAge()
        {
            return dal.GetUserAge();
        }
    }
}