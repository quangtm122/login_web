using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginMvc; 

namespace LoginWeb.Models
{
    public class AccountModel : IAccountModel
    {
        public User CheckLogin(string userName, string passWord)
        {
            using (var db = new LoginEntities1())
            {
                return db.Users.Where(x => x.userName == userName && x.passWord == passWord).FirstOrDefault();
               
            }
        }
    }
}