using Lab1App.DAO;
using Lab1App.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1App.NEGOCIO
{
    class ClsNegocioLoguin
    {

        ClsDao Dao = new ClsDao();

        public Boolean acceder(ClsDominio objetoDominio ) {
            for (int i=0; i<Dao.users.Length;i++) { 
            if (objetoDominio.User.Equals(Dao.users[i]) && objetoDominio.Pass.Equals(Dao.pass[i])) 
            {
                return true;
            }
            }
            return false;
        }

    }
}
