using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class MgtUsersLogins
    {
        public static bool Authentification(string pLogin, string pMotDePasse)
        {
            return ADO_UsersLogins.Authentification(pLogin, pMotDePasse);
        }
    }
}
