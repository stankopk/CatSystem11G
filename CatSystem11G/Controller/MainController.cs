using CatSystem11G.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystem11G.Controller
{
    internal class MainController
    {
        public bool CheckIfRegistered(string username, string password)
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                return db.User.ToList().Where(u => u.UserName == username &&
                u.Password == password).Any();
            }
        }
    }
}
