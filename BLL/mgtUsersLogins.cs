using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class mgtUsersLogins
    {
        public static bool Authentification(string pLogin, string pMotDePasse)
        {
            return ADO_UsersLogins.Authentification(pLogin, pMotDePasse);
        }
    }
}
