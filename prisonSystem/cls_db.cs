using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Configuration;
using System.Data;
namespace prisonSystem
{
    class cls_db
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["conDB"].ConnectionString);
        OracleCommand cmd;

        public DataTable PrisonerData()
        {
            DataTable tb = new DataTable();
            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from guard";
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public string cmnd;
        public DataTable guardData()
        {
            DataTable tb = new DataTable();
            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.Connection = con;
            switch (cmnd)
            { 
           
                case "add":
                    cmd.CommandText = "insert into guard(id,age,)";
                    break;
                case "delete":
                    cmd.CommandText = "select * from guard";
                    break;
                case "edit":
                    cmd.CommandText = "select * from guard";
                    break;
                case "view":
                    cmd.CommandText = "select * from guard";
                    break;
            }

            cmd.CommandText = "select * from guard";
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
       
    }
}
