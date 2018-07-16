using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Produkte_Verwaltung.DAL
{
    class Datenbank
    {
        SqlConnection sqlconnect;

        //Datanbankzugriff
        public Datenbank()
        {
            sqlconnect = new SqlConnection(@"Server=.\SQLEXPRESS; Database=ProdukteDB; Integrated Security=true");
        }
        
        // Verbindung öffnen

        public void oeffnen()
        {

            if (sqlconnect.State!=ConnectionState.Open)
            {
                sqlconnect.Open();
            }
        }

        // Verbindung zumachen

        public void ausmachen()
        {
            if (sqlconnect.State != ConnectionState.Closed)
            {
                sqlconnect.Close();
            }
        }

        // Data lesen von Datenbank

        public DataTable selectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnect;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        // add..update..delete von Datenbank
        public void sqlcommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnect;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery(); 
        }


    }
}
