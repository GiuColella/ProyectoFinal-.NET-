using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CapaDatos;

namespace _2.CapaLogica
{
    public class UserModel
    {
        Users users = new Users();
        public bool loginUser(string user,string pass)
        {
            return users.Login(user, pass);
        }
    }
}
