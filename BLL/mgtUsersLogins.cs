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
            DataTable mesDonnes = new DataTable();
            mesDonnes = ADO_UsersLogins.Authentification(pLogin, pMotDePasse);

            foreach (DataRow occurence in mesDonnes.Rows)
            {
                if (String.IsNullOrWhiteSpace(occurence["Id"].ToString()))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
