using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Produkte_Verwaltung.BLL
{
    class neues_Produkt
    {

        //produktnummer_üperprüfen

        public DataTable get_alle_sorte()
        {
            DAL.Datenbank DAL = new DAL.Datenbank();
                       
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_alle_sorte", null);
            DAL.ausmachen();
            return Dt;

        }

        public void produkt_hinzufügen(int snr, string pname, string pnr,
            int pmenge, string pkosten, byte[] pimage)

        {
            DAL.Datenbank DAL = new DAL.Datenbank();
            DAL.oeffnen();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@PNR", SqlDbType.VarChar, 50);
            param[0].Value = pnr;

            param[1] = new SqlParameter("@PNAME", SqlDbType.VarChar, 50);
            param[1].Value = pname;

            param[2] = new SqlParameter("@PMENGE", SqlDbType.Int);
            param[2].Value = pmenge;

            param[3] = new SqlParameter("@PKOSTEN", SqlDbType.VarChar, 50);
            param[3].Value = pkosten;

            param[4] = new SqlParameter("@PIMAGE", SqlDbType.Binary);
            param[4].Value = pimage;

            param[5] = new SqlParameter("@SNR", SqlDbType.Int);
            param[5].Value = snr;

            DAL.sqlcommand("add_Produkt", param);
            DAL.ausmachen();
        }

        public DataTable produktnummer_üperprüfene(string ID)
        {
            DAL.Datenbank DAL = new DAL.Datenbank();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.selectData("produktnummer_üperprüfen", param);
            DAL.ausmachen();
            return Dt;

        }

        public DataTable get_alle_Produkte()
        {
            DAL.Datenbank DAL = new DAL.Datenbank();

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_alle_Produkte", null);
            DAL.ausmachen();
            return Dt;

        }

        public DataTable Produke_suchen(string ID)
        {
            DAL.Datenbank DAL = new DAL.Datenbank();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.selectData("Produkt_Suchen", param);
            DAL.ausmachen();
            return Dt;


        }

        public void produkt_löschen(string ID)

        {
            DAL.Datenbank DAL = new DAL.Datenbank();
            DAL.oeffnen();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAL.sqlcommand("Produkt_löschen", param);
            DAL.ausmachen();
        }
    }
}
