using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Produkte_Verwaltung.BLL
{
    class Anmeldung
    {

        public DataTable anmelden(string BNr, string Pass)
        {
            DAL.Datenbank DAL = new DAL.Datenbank();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = BNr;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = Pass;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("SP_LOGIN", param);
            DAL.ausmachen();
            return Dt;

        }
    }
}
